
namespace DcRat
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paneltop = new System.Windows.Forms.Panel();
            this.buttonside = new System.Windows.Forms.Button();
            this.labelDcRat = new System.Windows.Forms.Label();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonmax = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.panelleft = new System.Windows.Forms.Panel();
            this.panelside = new System.Windows.Forms.Panel();
            this.buttonsettings = new System.Windows.Forms.Button();
            this.buttonabout = new System.Windows.Forms.Button();
            this.buttontasks = new System.Windows.Forms.Button();
            this.buttonbuilder = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.panelchild = new System.Windows.Forms.Panel();
            this.updateUI = new System.Windows.Forms.Timer(this.components);
            this.paneltop.SuspendLayout();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.SystemColors.Control;
            this.paneltop.Controls.Add(this.buttonside);
            this.paneltop.Controls.Add(this.labelDcRat);
            this.paneltop.Controls.Add(this.buttonmin);
            this.paneltop.Controls.Add(this.buttonmax);
            this.paneltop.Controls.Add(this.buttonclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1200, 45);
            this.paneltop.TabIndex = 0;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // buttonside
            // 
            this.buttonside.BackColor = System.Drawing.SystemColors.Control;
            this.buttonside.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonside.FlatAppearance.BorderSize = 0;
            this.buttonside.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonside.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonside.Image = global::DcRat.Properties.Resources.distanceTabel_dark;
            this.buttonside.Location = new System.Drawing.Point(0, 0);
            this.buttonside.Margin = new System.Windows.Forms.Padding(0);
            this.buttonside.Name = "buttonside";
            this.buttonside.Size = new System.Drawing.Size(45, 45);
            this.buttonside.TabIndex = 0;
            this.buttonside.UseVisualStyleBackColor = false;
            this.buttonside.Click += new System.EventHandler(this.buttonside_Click);
            // 
            // labelDcRat
            // 
            this.labelDcRat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDcRat.BackColor = System.Drawing.SystemColors.Control;
            this.labelDcRat.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcRat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelDcRat.Location = new System.Drawing.Point(41, 0);
            this.labelDcRat.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.labelDcRat.Name = "labelDcRat";
            this.labelDcRat.Size = new System.Drawing.Size(1027, 45);
            this.labelDcRat.TabIndex = 1;
            this.labelDcRat.Text = "DcRat - Dev Version";
            this.labelDcRat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDcRat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDcRat_MouseDown);
            // 
            // buttonmin
            // 
            this.buttonmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmin.BackColor = System.Drawing.SystemColors.Control;
            this.buttonmin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonmin.FlatAppearance.BorderSize = 0;
            this.buttonmin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonmin.Image = global::DcRat.Properties.Resources.min_dark;
            this.buttonmin.Location = new System.Drawing.Point(1074, 3);
            this.buttonmin.Name = "buttonmin";
            this.buttonmin.Size = new System.Drawing.Size(37, 39);
            this.buttonmin.TabIndex = 0;
            this.buttonmin.UseVisualStyleBackColor = false;
            this.buttonmin.Click += new System.EventHandler(this.buttonmin_Click);
            // 
            // buttonmax
            // 
            this.buttonmax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonmax.BackColor = System.Drawing.SystemColors.Control;
            this.buttonmax.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonmax.FlatAppearance.BorderSize = 0;
            this.buttonmax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonmax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmax.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonmax.Image = global::DcRat.Properties.Resources.max_dark;
            this.buttonmax.Location = new System.Drawing.Point(1117, 3);
            this.buttonmax.Name = "buttonmax";
            this.buttonmax.Size = new System.Drawing.Size(37, 39);
            this.buttonmax.TabIndex = 0;
            this.buttonmax.UseVisualStyleBackColor = false;
            this.buttonmax.Click += new System.EventHandler(this.buttonmax_Click);
            // 
            // buttonclose
            // 
            this.buttonclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonclose.BackColor = System.Drawing.SystemColors.Control;
            this.buttonclose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonclose.FlatAppearance.BorderSize = 0;
            this.buttonclose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonclose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.buttonclose.Image = global::DcRat.Properties.Resources.close_dark;
            this.buttonclose.Location = new System.Drawing.Point(1160, 3);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(37, 39);
            this.buttonclose.TabIndex = 0;
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.SystemColors.Control;
            this.panelleft.Controls.Add(this.panelside);
            this.panelleft.Controls.Add(this.buttonsettings);
            this.panelleft.Controls.Add(this.buttonabout);
            this.panelleft.Controls.Add(this.buttontasks);
            this.panelleft.Controls.Add(this.buttonbuilder);
            this.panelleft.Controls.Add(this.buttonhome);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 45);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(165, 555);
            this.panelleft.TabIndex = 1;
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelside.Location = new System.Drawing.Point(3, 3);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(10, 67);
            this.panelside.TabIndex = 20;
            // 
            // buttonsettings
            // 
            this.buttonsettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsettings.BackColor = System.Drawing.SystemColors.Control;
            this.buttonsettings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonsettings.FlatAppearance.BorderSize = 0;
            this.buttonsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonsettings.Image = global::DcRat.Properties.Resources.setting_dark;
            this.buttonsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsettings.Location = new System.Drawing.Point(3, 412);
            this.buttonsettings.Name = "buttonsettings";
            this.buttonsettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonsettings.Size = new System.Drawing.Size(159, 67);
            this.buttonsettings.TabIndex = 1;
            this.buttonsettings.Text = "    Settings";
            this.buttonsettings.UseVisualStyleBackColor = false;
            this.buttonsettings.Click += new System.EventHandler(this.buttonsettings_Click);
            // 
            // buttonabout
            // 
            this.buttonabout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonabout.BackColor = System.Drawing.SystemColors.Control;
            this.buttonabout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonabout.FlatAppearance.BorderSize = 0;
            this.buttonabout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonabout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonabout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonabout.Image = global::DcRat.Properties.Resources.about_dark;
            this.buttonabout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonabout.Location = new System.Drawing.Point(3, 485);
            this.buttonabout.Name = "buttonabout";
            this.buttonabout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonabout.Size = new System.Drawing.Size(159, 67);
            this.buttonabout.TabIndex = 1;
            this.buttonabout.Text = "    About";
            this.buttonabout.UseVisualStyleBackColor = false;
            this.buttonabout.Click += new System.EventHandler(this.buttonabout_Click);
            // 
            // buttontasks
            // 
            this.buttontasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttontasks.BackColor = System.Drawing.SystemColors.Control;
            this.buttontasks.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttontasks.FlatAppearance.BorderSize = 0;
            this.buttontasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontasks.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttontasks.Image = global::DcRat.Properties.Resources.task_dark;
            this.buttontasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttontasks.Location = new System.Drawing.Point(3, 149);
            this.buttontasks.Name = "buttontasks";
            this.buttontasks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttontasks.Size = new System.Drawing.Size(159, 67);
            this.buttontasks.TabIndex = 1;
            this.buttontasks.Text = "    Tasks";
            this.buttontasks.UseVisualStyleBackColor = false;
            this.buttontasks.Click += new System.EventHandler(this.buttontasks_Click);
            // 
            // buttonbuilder
            // 
            this.buttonbuilder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonbuilder.BackColor = System.Drawing.SystemColors.Control;
            this.buttonbuilder.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonbuilder.FlatAppearance.BorderSize = 0;
            this.buttonbuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbuilder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuilder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonbuilder.Image = global::DcRat.Properties.Resources.icon_config_dark;
            this.buttonbuilder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonbuilder.Location = new System.Drawing.Point(3, 76);
            this.buttonbuilder.Name = "buttonbuilder";
            this.buttonbuilder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonbuilder.Size = new System.Drawing.Size(159, 67);
            this.buttonbuilder.TabIndex = 1;
            this.buttonbuilder.Text = "    Builder";
            this.buttonbuilder.UseVisualStyleBackColor = false;
            this.buttonbuilder.Click += new System.EventHandler(this.buttonbuilder_Click);
            // 
            // buttonhome
            // 
            this.buttonhome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonhome.BackColor = System.Drawing.SystemColors.Control;
            this.buttonhome.FlatAppearance.BorderSize = 0;
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.buttonhome.Image = global::DcRat.Properties.Resources.home__dark;
            this.buttonhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonhome.Location = new System.Drawing.Point(3, 3);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonhome.Size = new System.Drawing.Size(159, 67);
            this.buttonhome.TabIndex = 0;
            this.buttonhome.Text = "    Home";
            this.buttonhome.UseVisualStyleBackColor = false;
            this.buttonhome.Click += new System.EventHandler(this.buttonhome_Click);
            // 
            // panelchild
            // 
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.Location = new System.Drawing.Point(165, 45);
            this.panelchild.Name = "panelchild";
            this.panelchild.Padding = new System.Windows.Forms.Padding(3);
            this.panelchild.Size = new System.Drawing.Size(1035, 555);
            this.panelchild.TabIndex = 2;
            // 
            // updateUI
            // 
            this.updateUI.Enabled = true;
            this.updateUI.Interval = 500;
            this.updateUI.Tick += new System.EventHandler(this.updateUI_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelchild);
            this.Controls.Add(this.panelleft);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Opacity = 0.97D;
            this.Text = "DcRat";
            this.paneltop.ResumeLayout(false);
            this.panelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Panel panelchild;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Button buttonsettings;
        private System.Windows.Forms.Button buttonabout;
        private System.Windows.Forms.Button buttontasks;
        private System.Windows.Forms.Button buttonbuilder;
        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Label labelDcRat;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonside;
        private System.Windows.Forms.Timer updateUI;
    }
}

