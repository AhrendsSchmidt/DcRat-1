using DcRat.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcRat.TCPSocket
{
    public class Clients
    {
        public string ID { get; set; }
        public ListViewItem LV { get; set; }
        public ClientInfo Info { get; set; }

        public class ClientInfo
        {
            public string HWID;
            public string IP;
            public string User;
            public string OS;
            public string Camera;
            public string InstallType;
            public string InstallTime;
            public string Path;
            public string Active;
            public string Version;
            public string Permission;
            public string AV;
            public string Group;
            public DateTime LastPing;
        }

        public Clients()
        {
            Info = new ClientInfo();
        }
    }
}
