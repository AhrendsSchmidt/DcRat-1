using System.Collections.Generic;

namespace Server
{
    class Settings
    {
        public static  List<Clients> Controler = new List<Clients>();
        public static  List<Clients> Online = new List<Clients>();
        public static long Sent = 0;
        public static long Received = 0;
        public static string XorKey = "";
        public static string Password = "";
        public static int Port = 0;
    }
}
