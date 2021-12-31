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

namespace DcRat.ChildForms
{
    public partial class singleFormDevice : Form
    {
        public singleFormDevice()
        {
            InitializeComponent();
            InitBorder();
            SetTheme();
        }

        #region Theme
        private void SetTheme()
        {
            bool darkTheme = Settings.Default.darkTheme;

            Color colorSide = darkTheme ? Settings.Default.colorsidedark : Settings.Default.colorside;
            Color colorText = darkTheme ? Settings.Default.colortextdark : Settings.Default.colortext;

            this.BackColor = colorSide;
            this.ForeColor = colorText;

            paneltop.BackColor = colorSide;
            buttonmax.BackColor = colorSide;
            buttonmin.BackColor = colorSide;
            labelDcRat.BackColor = colorSide;
            labelDcRat.ForeColor = colorText;
            buttonclose.BackColor = colorSide;

            buttonclose.Image = darkTheme ? Resources.close : Resources.close_dark;
            buttonmax.Image = darkTheme ? Resources.max : Resources.max_dark;
            buttonmin.Image = darkTheme ? Resources.min : Resources.min_dark;

            treeViewdevice.ForeColor = colorText;
            treeViewdevice.BackColor = colorSide;
        }
        #endregion

        #region Border
        private Point mousePoint = new Point();
        Label[] labels = new Label[4];
        private int lastWidth = 0;
        private int lastHeight = 0;
        void InitBorder()
        {

            labels[0] = new Label();
            labels[1] = new Label();
            labels[2] = new Label();
            labels[3] = new Label();

            labels[0].BackColor = labels[2].BackColor = labels[1].BackColor = labels[3].BackColor = Color.FromArgb(188, 182, 211); //边框颜色

            Controls.Add(labels[0]);
            Controls.Add(labels[1]);
            Controls.Add(labels[2]);
            Controls.Add(labels[3]);

            labels[0].Cursor = labels[2].Cursor = Cursors.SizeWE;
            labels[1].Cursor = labels[3].Cursor = Cursors.SizeNS;

            labels[0].MouseDown += BorderMouseDown;
            labels[1].MouseDown += BorderMouseDown;
            labels[2].MouseDown += BorderMouseDown;
            labels[3].MouseDown += BorderMouseDown;

            labels[0].MouseMove += WMouseMove;
            labels[2].MouseMove += EMouseMove;
            labels[1].MouseMove += NMouseMove;
            labels[3].MouseMove += SMouseMove;

            labels[0].Dock = DockStyle.Left;
            labels[2].Dock = DockStyle.Right;
            labels[1].Dock = DockStyle.Top;
            labels[3].Dock = DockStyle.Bottom;

            UpdateBorder();
        }

        private void BorderMouseDown(object sender, MouseEventArgs e)
        {
            lastWidth = Width;
            lastHeight = Height;
            this.mousePoint.X = MousePosition.X;
            this.mousePoint.Y = MousePosition.Y;
        }

        private void WMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Width != MinimumSize.Width)
                {
                    Left = MousePosition.X;
                }


                if (lastWidth - (Control.MousePosition.X - mousePoint.X) <= 1000)
                {
                    this.Width = 1000;
                }
                else
                {
                    this.Width = lastWidth - (Control.MousePosition.X - mousePoint.X);
                }
            }

        }
        private void EMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lastWidth + (Control.MousePosition.X - mousePoint.X) <= 1000)
                {
                    this.Width = 1000;
                }
                else
                {
                    this.Width = lastWidth + (Control.MousePosition.X - mousePoint.X);
                }
            }

        }
        private void NMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Height != MinimumSize.Height)
                {
                    Top = MousePosition.Y;
                }

                if (lastHeight - (Control.MousePosition.Y - mousePoint.Y) <= 600)
                {
                    this.Height = 600;
                }
                else
                {
                    this.Height = lastHeight - (Control.MousePosition.Y - mousePoint.Y);
                }
            }

        }
        private void SMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lastHeight + (Control.MousePosition.Y - mousePoint.Y) <= 600)
                {
                    this.Height = 600;
                }
                else
                {
                    this.Height = lastHeight + (Control.MousePosition.Y - mousePoint.Y);
                }
            }

        }

        private void UpdateBorder()
        {
            labels[1].Height = labels[3].Height = 2;
            labels[0].Width = labels[2].Width = 2;
        }

        #endregion

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
        private void buttonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
            {
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
