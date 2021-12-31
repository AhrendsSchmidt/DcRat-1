
namespace DcRat.ChildForms
{
    partial class childFormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelabout = new System.Windows.Forms.Label();
            this.updateUI = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelabout
            // 
            this.labelabout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelabout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelabout.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelabout.Location = new System.Drawing.Point(0, 0);
            this.labelabout.Name = "labelabout";
            this.labelabout.Size = new System.Drawing.Size(819, 506);
            this.labelabout.TabIndex = 0;
            this.labelabout.Text = "This is a new version of DcRat";
            // 
            // updateUI
            // 
            this.updateUI.Enabled = true;
            this.updateUI.Interval = 1000;
            this.updateUI.Tick += new System.EventHandler(this.updateUI_Tick);
            // 
            // childFormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 506);
            this.Controls.Add(this.labelabout);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "childFormAbout";
            this.Text = "childFormAbout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelabout;
        private System.Windows.Forms.Timer updateUI;
    }
}