using DcRat.ChildForms;
using DcRat.Properties;
using DcRat.TCPSocket;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcRat
{
    public partial class FormMain : Form
    {
        #region Childforms
        childFormAbout childForm_About;
        childFormBuilder childForm_Builder;
        childFormSettings childForm_Settings;
        childFormTasks childForm_Tasks;
        public static childFormHome childForm_Home = new childFormHome();
        bool childFormAbout_on = false;
        bool childFormBuilder_on = false;
        bool childFormSettings_on = false;
        bool childFormTasks_on = false;
        #endregion

        public FormMain()
        {
            InitializeComponent();
            InitBorder();
            openChildForm(childForm_Home);
            SetTheme();
        }
        #region Theme
        public void SetTheme()
        {
            bool darkTheme = Settings.Default.darkTheme;

            Color colorSide = darkTheme ? Settings.Default.colorsidedark : Settings.Default.colorside;
            Color colorText = darkTheme ? Settings.Default.colortextdark : Settings.Default.colortext;

            this.BackColor = colorSide;
            this.ForeColor = colorText;

            panelleft.BackColor = colorSide;
            paneltop.BackColor = colorSide;
            buttonabout.BackColor = colorSide;
            buttonbuilder.BackColor = colorSide;
            buttonclose.BackColor = colorSide;
            buttonhome.BackColor = colorSide;
            buttonmax.BackColor = colorSide;
            buttonmin.BackColor = colorSide;
            buttonsettings.BackColor = colorSide;
            buttonside.BackColor = colorSide;
            buttontasks.BackColor = colorSide;
            labelDcRat.BackColor = colorSide;

            buttonabout.ForeColor = colorText;
            buttonbuilder.ForeColor = colorText;
            buttonhome.ForeColor = colorText;
            buttonsettings.ForeColor = colorText;
            buttontasks.ForeColor = colorText;
            labelDcRat.ForeColor = colorText;

            buttonabout.Image = darkTheme ? Resources.about : Resources.about_dark;
            buttonbuilder.Image = darkTheme ? Resources.icon_config : Resources.icon_config_dark;
            buttonclose.Image = darkTheme ? Resources.close : Resources.close_dark;
            buttonhome.Image = darkTheme ? Resources.home : Resources.home__dark;
            buttonmax.Image = darkTheme ? Resources.max : Resources.max_dark;
            buttonmin.Image = darkTheme ? Resources.min : Resources.min_dark;
            buttonsettings.Image = darkTheme ? Resources.setting : Resources.setting_dark;
            buttonside.Image = darkTheme ? Resources.distanceTabel : Resources.distanceTabel_dark;
            buttontasks.Image = darkTheme ? Resources.task : Resources.task_dark;
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

        #region ChildForm


        private void openChildForm(Form frm)
        {
            //关闭原有的子窗体
            foreach (Control item in this.panelchild.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Hide();
                }
            }
            frm.TopLevel = false;
            frm.Parent = this.panelchild;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
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

        private void buttonclose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Move_panel_side(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }
        private void buttonabout_Click(object sender, EventArgs e)
        {
            Move_panel_side(buttonabout);
            if (!childFormAbout_on)
            {
                childForm_About = new childFormAbout();
                childFormAbout_on = true;
            }
            openChildForm(childForm_About);
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            Move_panel_side(buttonhome);
            openChildForm(childForm_Home);
        }

        private void buttontasks_Click(object sender, EventArgs e)
        {
            Move_panel_side(buttontasks);
            if (!childFormTasks_on)
            {
                childForm_Tasks = new childFormTasks();
                childFormTasks_on = true;
            }
            openChildForm(childForm_Tasks);
        }

        private void buttonsettings_Click(object sender, EventArgs e)
        {
            Move_panel_side(buttonsettings);
            if (!childFormSettings_on)
            {
                childForm_Settings = new childFormSettings();
                childFormSettings_on = true;
            }
            openChildForm(childForm_Settings);
        }

        private void buttonbuilder_Click(object sender, EventArgs e)
        {
            Move_panel_side(buttonbuilder);
            if (!childFormBuilder_on)
            {
                childForm_Builder = new childFormBuilder();
                childFormBuilder_on = true;
            }
            openChildForm(childForm_Builder);
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

        private void buttonmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool previoustheme = false;
        private double previousopacity = 97;
        private void updateUI_Tick(object sender, EventArgs e)
        {
            if (previoustheme != Settings.Default.darkTheme)
            {
                previoustheme = Settings.Default.darkTheme;
                SetTheme();
            }
            if (previousopacity != Settings.Default.opacity)
            {
                previousopacity = Settings.Default.opacity;

                this.Opacity = (Settings.Default.opacity) / 100;
            }
        }

        private void buttonside_Click(object sender, EventArgs e)
        {
            if (panelleft.Width == 0)
            {
                panelleft.Width = 165;
            }
            else
            {
                panelleft.Width = 0;
            }
        }

        public async static void Connect()
        {
            try
            {
                await Task.Delay(1000);
                Connection.InitializeClient();
                while (true)
                {
                    if (!Connection.IsConnected) 
                    {
                        MessageBox.Show("Error connection");
                        Environment.Exit(0);
                    }
                    //Connection.Reconnect();
                    Thread.Sleep(new Random().Next(5000));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}
