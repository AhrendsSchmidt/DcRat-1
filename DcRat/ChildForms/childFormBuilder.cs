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
    public partial class childFormBuilder : Form
    {
        public childFormBuilder()
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

            groupBoxassembly.ForeColor = colorText;
            groupBoxipport.ForeColor = colorText;
            groupBoxothers.ForeColor = colorText;
            textBoxlink.BackColor = colorSide;
            textBoxlink.ForeColor = colorText;
            textBoxicon.BackColor = colorSide;
            textBoxicon.ForeColor = colorText;
            textBoxip.BackColor = colorSide;
            textBoxip.ForeColor = colorText;
            listBoxIP.BackColor = colorSide;
            listBoxIP.ForeColor = colorText;
            listBoxPort.ForeColor = colorText;
            listBoxPort.BackColor = colorSide;
            textBoxport.ForeColor = colorText;
            textBoxport.BackColor = colorSide;
            textBoxproduct.BackColor = colorSide;
            textBoxcompany.BackColor = colorSide;
            textBoxcopyright.BackColor = colorSide;
            textBoxdescription.BackColor = colorSide;
            textBoxfileversion.BackColor = colorSide;
            textBoxoriginalfilename.BackColor = colorSide;
            textBoxproductversion.BackColor = colorSide;
            textBoxtrademarks.BackColor = colorSide;
            textBoxproduct.ForeColor = colorText;
            textBoxcompany.ForeColor = colorText;
            textBoxcopyright.ForeColor = colorText;
            textBoxdescription.ForeColor = colorText;
            textBoxfileversion.ForeColor = colorText;
            textBoxoriginalfilename.ForeColor = colorText;
            textBoxproductversion.ForeColor = colorText;
            textBoxtrademarks.ForeColor = colorText;
            textBoxgroup.ForeColor = colorText;
            textBoxgroup.BackColor = colorSide;
            numericUpDownsleep.BackColor = colorSide;
            numericUpDownsleep.ForeColor = colorText;

        }
    }
}
