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
    public partial class childFormAbout : Form
    {
        public childFormAbout()
        {
            InitializeComponent();
            SetTheme();
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

            labelabout.BackColor = colorSide;
            labelabout.ForeColor = colorText;
        }
    }
}
