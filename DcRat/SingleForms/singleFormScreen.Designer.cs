
namespace DcRat.SingleForms
{
    partial class singleFormScreen
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.labelDcRat = new System.Windows.Forms.Label();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonmax = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.toolStripscreen = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonstart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonstop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorstart = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelquality = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxquality = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelswichscreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtoncapture = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonmouse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonkeyboard = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxscreen = new System.Windows.Forms.PictureBox();
            this.paneltop.SuspendLayout();
            this.toolStripscreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.labelDcRat);
            this.paneltop.Controls.Add(this.buttonmin);
            this.paneltop.Controls.Add(this.buttonmax);
            this.paneltop.Controls.Add(this.buttonclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(933, 45);
            this.paneltop.TabIndex = 1;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // labelDcRat
            // 
            this.labelDcRat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDcRat.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcRat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelDcRat.Location = new System.Drawing.Point(0, 0);
            this.labelDcRat.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.labelDcRat.Name = "labelDcRat";
            this.labelDcRat.Size = new System.Drawing.Size(795, 45);
            this.labelDcRat.TabIndex = 1;
            this.labelDcRat.Text = "DcRat - Screen - ";
            this.labelDcRat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDcRat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDcRat_MouseDown);
            // 
            // buttonmin
            // 
            this.buttonmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonmin.FlatAppearance.BorderSize = 0;
            this.buttonmin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmin.Image = global::DcRat.Properties.Resources.min_dark;
            this.buttonmin.Location = new System.Drawing.Point(801, 3);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(39, 39);
            this.buttonmin.TabIndex = 0;
            this.buttonmin.UseVisualStyleBackColor = false;
            this.buttonmin.Click += new System.EventHandler(this.buttonmin_Click);
            // 
            // buttonmax
            // 
            this.buttonmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmax.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonmax.FlatAppearance.BorderSize = 0;
            this.buttonmax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmax.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmax.Image = global::DcRat.Properties.Resources.max_dark;
            this.buttonmax.Location = new System.Drawing.Point(846, 3);
            this.buttonmax.Name = "buttonmax";
            this.buttonmax.Size = new System.Drawing.Size(39, 39);
            this.buttonmax.TabIndex = 0;
            this.buttonmax.UseVisualStyleBackColor = false;
            this.buttonmax.Click += new System.EventHandler(this.buttonmax_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonclose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonclose.Image = global::DcRat.Properties.Resources.close_dark;
            this.buttonclose.Location = new System.Drawing.Point(891, 3);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(39, 39);
            this.buttonclose.TabIndex = 0;
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // toolStripscreen
            // 
            this.toolStripscreen.AutoSize = false;
            this.toolStripscreen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripscreen.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripscreen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonstart,
            this.toolStripButtonstop,
            this.toolStripSeparatorstart,
            this.toolStripLabelquality,
            this.toolStripComboBoxquality,
            this.toolStripSeparator2,
            this.toolStripLabelswichscreen,
            this.toolStripSeparator3,
            this.toolStripButtoncapture,
            this.toolStripSeparator4,
            this.toolStripButtonmouse,
            this.toolStripSeparator5,
            this.toolStripButtonkeyboard});
            this.toolStripscreen.Location = new System.Drawing.Point(0, 45);
            this.toolStripscreen.Name = "toolStripscreen";
            this.toolStripscreen.Size = new System.Drawing.Size(933, 45);
            this.toolStripscreen.TabIndex = 3;
            this.toolStripscreen.Text = "toolStrip1";
            // 
            // toolStripButtonstart
            // 
            this.toolStripButtonstart.Image = global::DcRat.Properties.Resources.play_circle_dark;
            this.toolStripButtonstart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonstart.Name = "toolStripButtonstart";
            this.toolStripButtonstart.Size = new System.Drawing.Size(67, 42);
            this.toolStripButtonstart.Text = "Start";
            this.toolStripButtonstart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripButtonstop
            // 
            this.toolStripButtonstop.Image = global::DcRat.Properties.Resources.stop_circle_dark;
            this.toolStripButtonstop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonstop.Name = "toolStripButtonstop";
            this.toolStripButtonstop.Size = new System.Drawing.Size(67, 42);
            this.toolStripButtonstop.Text = "Stop";
            this.toolStripButtonstop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparatorstart
            // 
            this.toolStripSeparatorstart.Name = "toolStripSeparatorstart";
            this.toolStripSeparatorstart.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabelquality
            // 
            this.toolStripLabelquality.Name = "toolStripLabelquality";
            this.toolStripLabelquality.Size = new System.Drawing.Size(48, 42);
            this.toolStripLabelquality.Text = "Quality:";
            // 
            // toolStripComboBoxquality
            // 
            this.toolStripComboBoxquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxquality.Name = "toolStripComboBoxquality";
            this.toolStripComboBoxquality.Size = new System.Drawing.Size(121, 45);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabelswichscreen
            // 
            this.toolStripLabelswichscreen.Image = global::DcRat.Properties.Resources.display_arrow_right_dark;
            this.toolStripLabelswichscreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabelswichscreen.Name = "toolStripLabelswichscreen";
            this.toolStripLabelswichscreen.Size = new System.Drawing.Size(117, 42);
            this.toolStripLabelswichscreen.Text = "Swich Screens";
            this.toolStripLabelswichscreen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButtoncapture
            // 
            this.toolStripButtoncapture.Image = global::DcRat.Properties.Resources.picture_dark;
            this.toolStripButtoncapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtoncapture.Name = "toolStripButtoncapture";
            this.toolStripButtoncapture.Size = new System.Drawing.Size(85, 42);
            this.toolStripButtoncapture.Text = "Capture";
            this.toolStripButtoncapture.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButtonmouse
            // 
            this.toolStripButtonmouse.Image = global::DcRat.Properties.Resources.mouse_dark;
            this.toolStripButtonmouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonmouse.Name = "toolStripButtonmouse";
            this.toolStripButtonmouse.Size = new System.Drawing.Size(79, 42);
            this.toolStripButtonmouse.Text = "Mouse";
            this.toolStripButtonmouse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButtonkeyboard
            // 
            this.toolStripButtonkeyboard.Image = global::DcRat.Properties.Resources.keyboard_dark;
            this.toolStripButtonkeyboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonkeyboard.Name = "toolStripButtonkeyboard";
            this.toolStripButtonkeyboard.Size = new System.Drawing.Size(93, 42);
            this.toolStripButtonkeyboard.Text = "Keyboard";
            this.toolStripButtonkeyboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // pictureBoxscreen
            // 
            this.pictureBoxscreen.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBoxscreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxscreen.Location = new System.Drawing.Point(0, 90);
            this.pictureBoxscreen.Name = "pictureBoxscreen";
            this.pictureBoxscreen.Size = new System.Drawing.Size(933, 472);
            this.pictureBoxscreen.TabIndex = 4;
            this.pictureBoxscreen.TabStop = false;
            // 
            // singleFormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.pictureBoxscreen);
            this.Controls.Add(this.toolStripscreen);
            this.Controls.Add(this.paneltop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "singleFormScreen";
            this.Text = "singleFormScreen";
            this.paneltop.ResumeLayout(false);
            this.toolStripscreen.ResumeLayout(false);
            this.toolStripscreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxscreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelDcRat;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.ToolStrip toolStripscreen;
        private System.Windows.Forms.ToolStripButton toolStripButtonstart;
        private System.Windows.Forms.ToolStripButton toolStripButtonstop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorstart;
        private System.Windows.Forms.ToolStripLabel toolStripLabelquality;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxquality;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripLabelswichscreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtoncapture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonmouse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonkeyboard;
        private System.Windows.Forms.PictureBox pictureBoxscreen;
    }
}