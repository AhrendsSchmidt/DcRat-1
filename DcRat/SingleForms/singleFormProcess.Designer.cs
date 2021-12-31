
namespace DcRat.SingleForms
{
    partial class singleFormProcess
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
            this.paneltop = new System.Windows.Forms.Panel();
            this.labelDcRat = new System.Windows.Forms.Label();
            this.buttonmin = new System.Windows.Forms.Button();
            this.buttonmax = new System.Windows.Forms.Button();
            this.buttonclose = new System.Windows.Forms.Button();
            this.listViewprocess = new System.Windows.Forms.ListView();
            this.columnHeadername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadercpu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadermemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderpid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderdescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadercompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripprocess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMinidumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createFullDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listViewhandle = new System.Windows.Forms.ListView();
            this.columnHeadertype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderhandlename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewdll = new System.Windows.Forms.ListView();
            this.columnHeaderdllname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderpath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paneltop.SuspendLayout();
            this.contextMenuStripprocess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.labelDcRat);
            this.paneltop.Controls.Add(this.buttonmin);
            this.paneltop.Controls.Add(this.buttonmax);
            this.paneltop.Controls.Add(this.buttonclose);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.ForeColor = System.Drawing.SystemColors.Desktop;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(933, 45);
            this.paneltop.TabIndex = 2;
            this.paneltop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltop_MouseDown);
            // 
            // labelDcRat
            // 
            this.labelDcRat.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDcRat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelDcRat.Location = new System.Drawing.Point(0, 0);
            this.labelDcRat.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
            this.labelDcRat.Name = "labelDcRat";
            this.labelDcRat.Size = new System.Drawing.Size(795, 45);
            this.labelDcRat.TabIndex = 1;
            this.labelDcRat.Text = "DcRat - Process - ";
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
            // listViewprocess
            // 
            this.listViewprocess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadername,
            this.columnHeadercpu,
            this.columnHeadermemory,
            this.columnHeaderpid,
            this.columnHeaderdescription,
            this.columnHeadercompany});
            this.listViewprocess.ContextMenuStrip = this.contextMenuStripprocess;
            this.listViewprocess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewprocess.HideSelection = false;
            this.listViewprocess.Location = new System.Drawing.Point(0, 0);
            this.listViewprocess.Name = "listViewprocess";
            this.listViewprocess.OwnerDraw = true;
            this.listViewprocess.Size = new System.Drawing.Size(933, 258);
            this.listViewprocess.TabIndex = 3;
            this.listViewprocess.UseCompatibleStateImageBehavior = false;
            this.listViewprocess.View = System.Windows.Forms.View.Details;
            this.listViewprocess.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewprocess_DrawColumnHeader);
            this.listViewprocess.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listViewprocess_DrawItem);
            // 
            // columnHeadername
            // 
            this.columnHeadername.Text = "Process Name";
            this.columnHeadername.Width = 183;
            // 
            // columnHeadercpu
            // 
            this.columnHeadercpu.Text = "CPU";
            // 
            // columnHeadermemory
            // 
            this.columnHeadermemory.Text = "Memory";
            this.columnHeadermemory.Width = 93;
            // 
            // columnHeaderpid
            // 
            this.columnHeaderpid.Text = "PID";
            this.columnHeaderpid.Width = 72;
            // 
            // columnHeaderdescription
            // 
            this.columnHeaderdescription.Text = "Description";
            this.columnHeaderdescription.Width = 248;
            // 
            // columnHeadercompany
            // 
            this.columnHeadercompany.Text = "Company Name";
            this.columnHeadercompany.Width = 255;
            // 
            // contextMenuStripprocess
            // 
            this.contextMenuStripprocess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripprocess.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStripprocess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.createDumpToolStripMenuItem});
            this.contextMenuStripprocess.Name = "contextMenuStrip1";
            this.contextMenuStripprocess.Size = new System.Drawing.Size(161, 118);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Image = global::DcRat.Properties.Resources.times_circle_dark;
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.killToolStripMenuItem.Text = "Kill";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::DcRat.Properties.Resources.refresh_dark;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // createDumpToolStripMenuItem
            // 
            this.createDumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMinidumpToolStripMenuItem,
            this.createFullDumpToolStripMenuItem});
            this.createDumpToolStripMenuItem.Image = global::DcRat.Properties.Resources.dump_dark;
            this.createDumpToolStripMenuItem.Name = "createDumpToolStripMenuItem";
            this.createDumpToolStripMenuItem.Size = new System.Drawing.Size(160, 38);
            this.createDumpToolStripMenuItem.Text = "Create Dump";
            // 
            // createMinidumpToolStripMenuItem
            // 
            this.createMinidumpToolStripMenuItem.Image = global::DcRat.Properties.Resources.dump_dark;
            this.createMinidumpToolStripMenuItem.Name = "createMinidumpToolStripMenuItem";
            this.createMinidumpToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.createMinidumpToolStripMenuItem.Text = "Create Minidump";
            // 
            // createFullDumpToolStripMenuItem
            // 
            this.createFullDumpToolStripMenuItem.Image = global::DcRat.Properties.Resources.dump_dark;
            this.createFullDumpToolStripMenuItem.Name = "createFullDumpToolStripMenuItem";
            this.createFullDumpToolStripMenuItem.Size = new System.Drawing.Size(183, 38);
            this.createFullDumpToolStripMenuItem.Text = "Create Full Dump";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewprocess);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(933, 517);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listViewhandle);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listViewdll);
            this.splitContainer2.Size = new System.Drawing.Size(933, 255);
            this.splitContainer2.SplitterDistance = 457;
            this.splitContainer2.TabIndex = 1;
            // 
            // listViewhandle
            // 
            this.listViewhandle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadertype,
            this.columnHeaderhandlename});
            this.listViewhandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewhandle.HideSelection = false;
            this.listViewhandle.Location = new System.Drawing.Point(0, 0);
            this.listViewhandle.Name = "listViewhandle";
            this.listViewhandle.OwnerDraw = true;
            this.listViewhandle.Size = new System.Drawing.Size(457, 255);
            this.listViewhandle.TabIndex = 1;
            this.listViewhandle.UseCompatibleStateImageBehavior = false;
            this.listViewhandle.View = System.Windows.Forms.View.Details;
            this.listViewhandle.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewhandle_DrawColumnHeader);
            this.listViewhandle.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listViewhandle_DrawItem);
            // 
            // columnHeadertype
            // 
            this.columnHeadertype.Text = "Type";
            this.columnHeadertype.Width = 86;
            // 
            // columnHeaderhandlename
            // 
            this.columnHeaderhandlename.Text = "Name";
            this.columnHeaderhandlename.Width = 329;
            // 
            // listViewdll
            // 
            this.listViewdll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderdllname,
            this.columnHeaderpath});
            this.listViewdll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewdll.HideSelection = false;
            this.listViewdll.Location = new System.Drawing.Point(0, 0);
            this.listViewdll.Name = "listViewdll";
            this.listViewdll.OwnerDraw = true;
            this.listViewdll.Size = new System.Drawing.Size(472, 255);
            this.listViewdll.TabIndex = 0;
            this.listViewdll.UseCompatibleStateImageBehavior = false;
            this.listViewdll.View = System.Windows.Forms.View.Details;
            this.listViewdll.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewdll_DrawColumnHeader);
            this.listViewdll.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listViewdll_DrawItem);
            // 
            // columnHeaderdllname
            // 
            this.columnHeaderdllname.Text = "Name";
            this.columnHeaderdllname.Width = 85;
            // 
            // columnHeaderpath
            // 
            this.columnHeaderpath.Text = "Path";
            this.columnHeaderpath.Width = 375;
            // 
            // singleFormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.paneltop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "singleFormProcess";
            this.Text = "singleFormProcess";
            this.paneltop.ResumeLayout(false);
            this.contextMenuStripprocess.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelDcRat;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.ListView listViewprocess;
        private System.Windows.Forms.ColumnHeader columnHeadername;
        private System.Windows.Forms.ColumnHeader columnHeadercpu;
        private System.Windows.Forms.ColumnHeader columnHeadermemory;
        private System.Windows.Forms.ColumnHeader columnHeaderpid;
        private System.Windows.Forms.ColumnHeader columnHeaderdescription;
        private System.Windows.Forms.ColumnHeader columnHeadercompany;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripprocess;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMinidumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createFullDumpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listViewhandle;
        private System.Windows.Forms.ColumnHeader columnHeadertype;
        private System.Windows.Forms.ColumnHeader columnHeaderhandlename;
        private System.Windows.Forms.ListView listViewdll;
        private System.Windows.Forms.ColumnHeader columnHeaderdllname;
        private System.Windows.Forms.ColumnHeader columnHeaderpath;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}