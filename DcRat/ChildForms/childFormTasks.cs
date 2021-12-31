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

namespace DcRat.ChildForms
{
    public partial class childFormTasks : Form
    {
        public childFormTasks()
        {
            InitializeComponent();
            SetTheme();
        }

        private void listViewtasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewtasks.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewtasks.Items)
                {
                    item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
                    item.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                }
                foreach (ListViewItem item in listViewtasks.SelectedItems)
                {
                    //item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                    item.ForeColor = Color.White;
                    item.BackColor = Settings.Default.darkTheme ? ColorTranslator.FromHtml("#5D4529") : ColorTranslator.FromHtml("#758B98");
                }
                listViewtasks.Tag = listViewtasks.FocusedItem;
                listViewtasks.FocusedItem.Selected = false;
            }
        }
        ListViewItem lvHoveredItem;
        private void listViewtasks_MouseMove(object sender, MouseEventArgs e)
        {
            Color oItemColor = Settings.Default.darkTheme ? ColorTranslator.FromHtml("#2D333B") : Color.Lavender;
            Color oOriginalColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;

            ListViewItem lvCurrentItem = listViewtasks.GetItemAt(e.X, e.Y);


            if ((lvCurrentItem != null) && (lvCurrentItem != lvHoveredItem))
            {
                if (lvCurrentItem != listViewtasks.Tag)
                {
                    lvCurrentItem.BackColor = oItemColor;

                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
                else
                {
                    if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
                    {
                        lvHoveredItem.BackColor = oOriginalColor;
                    }

                    lvHoveredItem = lvCurrentItem;
                    return;
                }
            }


            if (lvCurrentItem == null)
            {
                if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
                {
                    lvHoveredItem.BackColor = oOriginalColor;
                    lvHoveredItem = null;
                }

            }
        }

        private void listViewtasks_MouseLeave(object sender, EventArgs e)
        {
            if ((lvHoveredItem != null) && (lvHoveredItem != listViewtasks.Tag))
            {
                lvHoveredItem.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
            }
            lvHoveredItem = null;
        }

        private void listViewtasks_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                return;
            }
            if (listViewtasks.SelectedIndices.Count == 0)
            {
                foreach (ListViewItem item in listViewtasks.Items)
                {
                    item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
                    item.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                }
                listViewtasks.Tag = null;
            }
        }

        private void listViewtasks_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            int tColumnCount;
            Rectangle tRect = new Rectangle();
            Point tPoint = new Point();
            Font tFont = new Font("Segoe UI", 9, FontStyle.Regular);
            SolidBrush tBackBrush = new SolidBrush(Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview);
            SolidBrush tFtontBrush;
            tFtontBrush = new SolidBrush(Settings.Default.darkTheme ? Settings.Default.colortextdark : Settings.Default.colortext);
            if (listViewtasks.Columns.Count == 0)
                return;
            tColumnCount = listViewtasks.Columns.Count;
            tRect.Y = 0;
            tRect.Height = e.Bounds.Height - 1;
            tPoint.Y = 3;
            for (int i = 0; i < tColumnCount; i++)
            {
                if (i == 0)
                {
                    tRect.X = 0;
                    tRect.Width = listViewtasks.Columns[i].Width;
                }
                else
                {
                    tRect.X += tRect.Width;
                    tRect.X += 1;
                    tRect.Width = listViewtasks.Columns[i].Width - 1;
                }
                e.Graphics.FillRectangle(tBackBrush, tRect);
                tPoint.X = tRect.X + 3;
                e.Graphics.DrawString(listViewtasks.Columns[i].Text, tFont, tFtontBrush, tPoint);
            }
        }

        private void listViewtasks_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
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

            listViewtasks.BackColor = darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
            listViewtasks.ForeColor = darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
            foreach (ListViewItem item in listViewtasks.Items)
            {
                if (listViewtasks.Tag != item)
                {
                    item.ForeColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewtextdark : Settings.Default.colorlistviewtext;
                    item.BackColor = Settings.Default.darkTheme ? Settings.Default.colorlistviewdark : Settings.Default.colorlistview;
                }
            }
        }
    }
}
