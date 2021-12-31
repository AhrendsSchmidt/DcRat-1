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
    public partial class childFormSettings : Form
    {
        public childFormSettings()
        {
            InitializeComponent();
        }

        private void childFormSettings_Load(object sender, EventArgs e)
        {
            radioButtonlight.Checked = !Settings.Default.darkTheme;
            radioButtondark.Checked = Settings.Default.darkTheme;
            trackBaropacity.Value = (int)Settings.Default.opacity;
            SetTheme();
        }

        private void SetTheme()
        {
            bool darkTheme = Settings.Default.darkTheme;

            Color colorSide = darkTheme ? Settings.Default.colorsidedark : Settings.Default.colorside;
            Color colorText = darkTheme ? Settings.Default.colortextdark : Settings.Default.colortext;

            this.BackColor = colorSide;
            this.ForeColor = colorText;

            groupBoxblock.ForeColor = colorText;
            groupBoxnotify.ForeColor = colorText;
            groupBoxtheme.ForeColor = colorText;
            buttonmailbind.ForeColor = colorText;
            textBoxblock.ForeColor = colorText;
            listBoxblock.ForeColor = colorText;
            listBoxblock.BackColor = colorSide;
            textBoxblock.BackColor = colorSide;
        }

        private void radioButtonlight_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.darkTheme = !radioButtonlight.Checked;
            SetTheme();
        }

        private void trackBaropacity_Scroll(object sender, EventArgs e)
        {
            Settings.Default.opacity = trackBaropacity.Value;
        }
    }
}
