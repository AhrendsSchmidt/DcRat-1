﻿using Client.MessagePack;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client
{
    class Settings
    {
        public static readonly string IP = "127.0.0.1";
        public static readonly int Port = 8848;
        public static readonly string Version = "0.0.1";
    }

    class Program
    {
        public static Socket Client { get; set; }
        private static byte[] Buffer { get; set; }
        private static long Buffersize { get; set; }
        private static bool BufferRecevied { get; set; }
        private static System.Threading.Timer Tick { get; set; }
        private static MemoryStream MS { get; set; }
        private static object SendSync { get; set; }

        static void Main(string[] args)
        {
            InitializeClient();
            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        public static void InitializeClient()
        {
            try
            {
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    ReceiveBufferSize = 50 * 1024,
                    SendBufferSize = 50 * 1024,
                    ReceiveTimeout = -1,
                    SendTimeout = -1,
                };
                Client.Connect(Settings.IP, Settings.Port);
                Debug.WriteLine("Connected!");
                Buffer = new byte[1];
                Buffersize = 0;
                BufferRecevied = false;
                MS = new MemoryStream();
                SendSync = new object();
                BeginSend(SendInfo());
                TimerCallback T = Ping;
                Tick = new System.Threading.Timer(T, null, new Random().Next(30 * 1000, 60 * 1000), new Random().Next(30 * 1000, 60 * 1000));
                Client.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, ReadServertData, null);
            }
            catch
            {
                Debug.WriteLine("Disconnected!");
                Thread.Sleep(new Random().Next(1 * 1000, 6 * 1000));
                Reconnect();
            }
        }

        public static void Reconnect()
        {
            if (Client.Connected) return;

            Tick?.Dispose();

            try
            {
                if (Client != null)
                {
                    Client.Close();
                    Client.Dispose();
                }
            }
            catch { }

            MS?.Dispose();

            InitializeClient();
        }

        public static byte[] SendInfo()
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Packet").AsString = "ClientInfo";
            msgpack.ForcePathObject("User").AsString = Environment.UserName.ToString();
            msgpack.ForcePathObject("OS").AsString = new ComputerInfo().OSFullName.ToString();
            return msgpack.Encode2Bytes();
        }

        public static void ReadServertData(IAsyncResult ar)
        {
            try
            {
                if (Client.Connected == false)
                {
                    Reconnect();
                    return;
                }

                int Recevied = Client.EndReceive(ar);

                if (Recevied > 0)
                {

                    if (BufferRecevied == false)
                    {
                        if (Buffer[0] == 0)
                        {
                            Buffersize = Convert.ToInt64(Encoding.UTF8.GetString(MS.ToArray()));
                            MS.Dispose();
                            MS = new MemoryStream();
                            if (Buffersize > 0)
                            {
                                Buffer = new byte[Buffersize - 1];
                                BufferRecevied = true;
                            }
                        }
                        else
                        {
                            MS.Write(Buffer, 0, Buffer.Length);
                        }
                    }
                    else
                    {
                        MS.Write(Buffer, 0, Recevied);
                        if (MS.Length == Buffersize)
                        {
                            ThreadPool.QueueUserWorkItem(Read, MS.ToArray());
                            MS.Dispose();
                            MS = new MemoryStream();
                            Buffer = new byte[1];
                            Buffersize = 0;
                            BufferRecevied = false;
                        }
                        else
                        {
                            Buffer = new byte[Buffersize - MS.Length];
                        }
                    }
                    Client.BeginReceive(Buffer, 0, Buffer.Length, SocketFlags.None, ReadServertData, null);
                }
                else
                {
                    Reconnect();
                }
            }
            catch
            {
                Reconnect();
            }
        }

        public static void Read(object Data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])Data);
                switch (unpack_msgpack.ForcePathObject("Packet").AsString)
                {

                    case "Ping":
                        {
                            Debug.WriteLine("Server Pinged me " + unpack_msgpack.ForcePathObject("Message").AsString);
                        }
                        break;
                }
            }
            catch { }
        }

        public static void Ping(object obj)
        {
            try
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "Ping";
                msgpack.ForcePathObject("Message").AsString = DateTime.Now.ToLongTimeString().ToString();
                BeginSend(msgpack.Encode2Bytes());
            }
            catch { }
        }

        public static void BeginSend(byte[] Msgs)
        {
            lock (SendSync)
            {
                if (Client.Connected)
                {
                    try
                    {
                        using (MemoryStream MS = new MemoryStream())
                        {
                            byte[] buffer = Msgs;
                            byte[] buffersize = Encoding.UTF8.GetBytes(buffer.Length.ToString() + Strings.ChrW(0));
                            MS.Write(buffersize, 0, buffersize.Length);
                            MS.Write(buffer, 0, buffer.Length);

                            Client.Poll(-1, SelectMode.SelectWrite);
                            Client.BeginSend(MS.ToArray(), 0, (int)(MS.Length), SocketFlags.None, EndSend, null);
                        }
                    }
                    catch
                    {
                        Reconnect();
                    }
                }
            }
        }

        public static void EndSend(IAsyncResult ar)
        {
            try
            {
                Client.EndSend(ar);
            }
            catch
            {
                Reconnect();
            }
        }
    }
}
