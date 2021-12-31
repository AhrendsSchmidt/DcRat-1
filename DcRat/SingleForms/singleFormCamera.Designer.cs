
namespace DcRat.SingleForms
{
    partial class singleFormCamera
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
            this.toolStripcamera = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonstart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonstop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelfps = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxfps = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelswitch = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxswitch = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtoncapture = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxcamera = new System.Windows.Forms.PictureBox();
            this.paneltop.SuspendLayout();
            this.toolStripcamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcamera)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.Control;
            this.paneltop.Controls.Add(this.labelDcRat);
            this.paneltop.Controls.Add(this.buttonmin);
            this.paneltop.Controls.Add(this.buttonmax);
            this.paneltop.Controls.Add(this.buttonclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(933, 45);
            this.paneltop.TabIndex = 2;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // labelDcRat
            // 
            this.labelDcRat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDcRat.BackColor = System.Drawing.SystemColors.Control;
            this.labelDcRat.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcRat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelDcRat.Location = new System.Drawing.Point(0, 0);
            this.labelDcRat.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.labelDcRat.Name = "labelDcRat";
            this.labelDcRat.Size = new System.Drawing.Size(795, 45);
            this.labelDcRat.TabIndex = 1;
            this.labelDcRat.Text = "DcRat - Camera - ";
            this.labelDcRat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDcRat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDcRat_MouseDown);
            // 
            // buttonmin
            // 
            this.buttonmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonmin.FlatAppearance.BorderSize = 0;
            this.buttonmin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
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
            this.buttonmax.BackColor = System.Drawing.SystemColors.Control;
            this.buttonmax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonmax.FlatAppearance.BorderSize = 0;
            this.buttonmax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
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
            this.buttonclose.BackColor = System.Drawing.SystemColors.Control;
            this.buttonclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonclose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonclose.Image = global::DcRat.Properties.Resources.close_dark;
            this.buttonclose.Location = new System.Drawing.Point(891, 3);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(39, 39);
            this.buttonclose.TabIndex = 0;
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // toolStripcamera
            // 
            this.toolStripcamera.AutoSize = false;
            this.toolStripcamera.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripcamera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripcamera.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripcamera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonstart,
            this.toolStripButtonstop,
            this.toolStripSeparator1,
            this.toolStripLabelfps,
            this.toolStripComboBoxfps,
            this.toolStripSeparator2,
            this.toolStripLabelswitch,
            this.toolStripComboBoxswitch,
            this.toolStripSeparator3,
            this.toolStripButtoncapture});
            this.toolStripcamera.Location = new System.Drawing.Point(0, 45);
            this.toolStripcamera.Name = "toolStripcamera";
            this.toolStripcamera.Size = new System.Drawing.Size(933, 45);
            this.toolStripcamera.TabIndex = 4;
            this.toolStripcamera.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabelfps
            // 
            this.toolStripLabelfps.Name = "toolStripLabelfps";
            this.toolStripLabelfps.Size = new System.Drawing.Size(28, 42);
            this.toolStripLabelfps.Text = "Fps:";
            // 
            // toolStripComboBoxfps
            // 
            this.toolStripComboBoxfps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxfps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxfps.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.toolStripComboBoxfps.Name = "toolStripComboBoxfps";
            this.toolStripComboBoxfps.Size = new System.Drawing.Size(120, 45);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabelswitch
            // 
            this.toolStripLabelswitch.Name = "toolStripLabelswitch";
            this.toolStripLabelswitch.Size = new System.Drawing.Size(45, 42);
            this.toolStripLabelswitch.Text = "Switch:";
            // 
            // toolStripComboBoxswitch
            // 
            this.toolStripComboBoxswitch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxswitch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripComboBoxswitch.Name = "toolStripComboBoxswitch";
            this.toolStripComboBoxswitch.Size = new System.Drawing.Size(200, 45);
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
            // pictureBoxcamera
            // 
            this.pictureBoxcamera.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBoxcamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxcamera.Location = new System.Drawing.Point(0, 90);
            this.pictureBoxcamera.Name = "pictureBoxcamera";
            this.pictureBoxcamera.Size = new System.Drawing.Size(933, 472);
            this.pictureBoxcamera.TabIndex = 5;
            this.pictureBoxcamera.TabStop = false;
            // 
            // singleFormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.pictureBoxcamera);
            this.Controls.Add(this.toolStripcamera);
            this.Controls.Add(this.paneltop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "singleFormCamera";
            this.Text = "singleFormCamera";
            this.paneltop.ResumeLayout(false);
            this.toolStripcamera.ResumeLayout(false);
            this.toolStripcamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcamera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelDcRat;
        private System.Windows.Forms.ToolStrip toolStripcamera;
        private System.Windows.Forms.ToolStripButton toolStripButtonstart;
        private System.Windows.Forms.ToolStripButton toolStripButtonstop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelfps;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxfps;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelswitch;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxswitch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtoncapture;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.PictureBox pictureBoxcamera;
    }
}