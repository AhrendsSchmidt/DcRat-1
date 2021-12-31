using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Server.MessagePack;

namespace Server
{
    class HandlePacket
    {
        public static void Read(Clients Client, byte[] Data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes(Data);
                switch (unpack_msgpack.ForcePathObject("Packet").AsString)
                {
                    case "ClientInfo":
                        { 
                            Console.WriteLine(unpack_msgpack.ForcePathObject("User").AsString);
                            Console.WriteLine(unpack_msgpack.ForcePathObject("OS").AsString);
                            Settings.Online.Add(Client);
                        }                        
                        break;

                    case "Controler":
                        {
                            //Check();
                            Console.WriteLine("Controler Connected");
                            Settings.Controler.Add(Client);
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
                                //if (Client.ID == unpack_msgpack.ForcePathObject("ID").AsString)
                                //{
                                //    ThreadPool.QueueUserWorkItem(CL.BeginSend, unpack_msgpack.Encode2Bytes());
                                //}                                
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
