using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Listener
    {
        private Socket listener { get; set; }

        public void Connect()
        {
            try
            {
                IPEndPoint IpEndPoint = new IPEndPoint(IPAddress.Any, Settings.Port);
                listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    SendBufferSize = 50 * 1024,
                    ReceiveBufferSize = 50 * 1024,
                };
                listener.Bind(IpEndPoint);
                listener.Listen(20);

                listener.BeginAccept(EndAccept, null);
            }
            catch (Exception ex)
            {
                Environment.Exit(0);
            }
        }

        private void EndAccept(IAsyncResult ar)
        {
            try
            {
                Clients CL = new Clients(listener.EndAccept(ar));
            }
            catch { }

            finally 
            {
                listener.BeginAccept(EndAccept, null);
            }
        }
    }
}