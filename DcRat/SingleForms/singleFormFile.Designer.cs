
namespace DcRat.SingleForms
{
    partial class singleFormFile
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
            this.toolStripfile = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonback = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxaddress = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtongoto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonrefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButtonjump = new System.Windows.Forms.ToolStripDropDownButton();
            this.appdataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.system32ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonnew = new System.Windows.Forms.ToolStripDropDownButton();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonupload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtondownload = new System.Windows.Forms.ToolStripButton();
            this.listViewfile = new System.Windows.Forms.ListView();
            this.columnHeadername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadersize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zip7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneltop.SuspendLayout();
            this.toolStripfile.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            this.paneltop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
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
            this.labelDcRat.Text = "DcRat - File - ";
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
            // toolStripfile
            // 
            this.toolStripfile.AutoSize = false;
            this.toolStripfile.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripfile.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonback,
            this.toolStripTextBoxaddress,
            this.toolStripButtongoto,
            this.toolStripSeparator1,
            this.toolStripButtonrefresh,
            this.toolStripSeparator2,
            this.toolStripDropDownButtonjump,
            this.toolStripButtonnew,
            this.toolStripSeparator3,
            this.toolStripButtonupload,
            this.toolStripButtondownload});
            this.toolStripfile.Location = new System.Drawing.Point(0, 45);
            this.toolStripfile.Name = "toolStripfile";
            this.toolStripfile.Size = new System.Drawing.Size(933, 45);
            this.toolStripfile.TabIndex = 2;
            this.toolStripfile.Text = "toolStrip1";
            // 
            // toolStripButtonback
            // 
            this.toolStripButtonback.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonback.Image = global::DcRat.Properties.Resources.pull_up_dark;
            this.toolStripButtonback.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonback.Name = "toolStripButtonback";
            this.toolStripButtonback.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonback.Text = "toolStripButton1";
            // 
            // toolStripTextBoxaddress
            // 
            this.toolStripTextBoxaddress.AutoSize = false;
            this.toolStripTextBoxaddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBoxaddress.Name = "toolStripTextBoxaddress";
            this.toolStripTextBoxaddress.Size = new System.Drawing.Size(400, 45);
            this.toolStripTextBoxaddress.Text = "C:\\Windows\\System32";
            // 
            // toolStripButtongoto
            // 
            this.toolStripButtongoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtongoto.Image = global::DcRat.Properties.Resources.round_right_dark;
            this.toolStripButtongoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtongoto.Name = "toolStripButtongoto";
            this.toolStripButtongoto.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtongoto.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButtonrefresh
            // 
            this.toolStripButtonrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonrefresh.Image = global::DcRat.Properties.Resources.refresh_dark;
            this.toolStripButtonrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonrefresh.Name = "toolStripButtonrefresh";
            this.toolStripButtonrefresh.Size = new System.Drawing.Size(36, 42);
            this.toolStripButtonrefresh.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripDropDownButtonjump
            // 
            this.toolStripDropDownButtonjump.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appdataToolStripMenuItem,
            this.desktopToolStripMenuItem,
            this.documentToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.system32ToolStripMenuItem,
            this.tempToolStripMenuItem});
            this.toolStripDropDownButtonjump.Image = global::DcRat.Properties.Resources.folder_open_dark;
            this.toolStripDropDownButtonjump.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonjump.Name = "toolStripDropDownButtonjump";
            this.toolStripDropDownButtonjump.Size = new System.Drawing.Size(81, 42);
            this.toolStripDropDownButtonjump.Text = "Jump";
            // 
            // appdataToolStripMenuItem
            // 
            this.appdataToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_dark;
            this.appdataToolStripMenuItem.Name = "appdataToolStripMenuItem";
            this.appdataToolStripMenuItem.Size = new System.Drawing.Size(146, 38);
            this.appdataToolStripMenuItem.Text = "Appdata";
            // 
            // desktopToolStripMenuItem
            // 
            this.desktopToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_dark;
            this.desktopToolStripMenuItem.Name = "desktopToolStripMenuItem";
            this.desktopToolStripMenuItem.Size = new System.Drawing.Size(146, 38);
            this.desktopToolStripMenuItem.Text = "Desktop";
            // 
            // documentToolStripMenuItem
            // 
            this.documentToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_dark;
            this.documentToolStripMenuItem.Name = "documentToolStripMenuItem";
            this.documentToolStripMenuItem.Size = new System.Drawing.Size(146, 38);
            this.documentToolStripMenuItem.Text = "Document";
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_dark;
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(146, 38);
            this.downloadToolStripMenuItem.Text = "Download";
            // 
            // system32ToolStripMenuItem
            // 
            this.system32ToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_dark;
            this.system32ToolStripMenuItem.Name = "system32ToolStripMenuItem";
            this.system32ToolStripMenuItem.Size = new System.Drawing.Size(146, 38);
            this.system32ToolStripMenuItem.Text = "System32";
            // 
            // tempToolStripMenuItem
            // 
            this.tempToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_dark;
            this.tempToolStripMenuItem.Name = "tempToolStripMenuItem";
            this.tempToolStripMenuItem.Size = new System.Drawing.Size(146, 38);
            this.tempToolStripMenuItem.Text = "Temp";
            // 
            // toolStripButtonnew
            // 
            this.toolStripButtonnew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.textToolStripMenuItem});
            this.toolStripButtonnew.Image = global::DcRat.Properties.Resources.plus_dark;
            this.toolStripButtonnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonnew.Name = "toolStripButtonnew";
            this.toolStripButtonnew.Size = new System.Drawing.Size(76, 42);
            this.toolStripButtonnew.Text = "New";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_dark;
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_1_dark;
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.textToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButtonupload
            // 
            this.toolStripButtonupload.Image = global::DcRat.Properties.Resources.upload_dark;
            this.toolStripButtonupload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonupload.Name = "toolStripButtonupload";
            this.toolStripButtonupload.Size = new System.Drawing.Size(81, 42);
            this.toolStripButtonupload.Text = "Upload";
            // 
            // toolStripButtondownload
            // 
            this.toolStripButtondownload.Image = global::DcRat.Properties.Resources.download_dark;
            this.toolStripButtondownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtondownload.Name = "toolStripButtondownload";
            this.toolStripButtondownload.Size = new System.Drawing.Size(97, 42);
            this.toolStripButtondownload.Text = "Download";
            // 
            // listViewfile
            // 
            this.listViewfile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadername,
            this.columnHeadertime,
            this.columnHeadertype,
            this.columnHeadersize});
            this.listViewfile.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewfile.HideSelection = false;
            this.listViewfile.Location = new System.Drawing.Point(0, 90);
            this.listViewfile.Name = "listViewfile";
            this.listViewfile.OwnerDraw = true;
            this.listViewfile.Size = new System.Drawing.Size(933, 472);
            this.listViewfile.TabIndex = 3;
            this.listViewfile.UseCompatibleStateImageBehavior = false;
            this.listViewfile.View = System.Windows.Forms.View.Details;
            this.listViewfile.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewfile_DrawColumnHeader);
            this.listViewfile.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listViewfile_DrawItem);
            // 
            // columnHeadername
            // 
            this.columnHeadername.Text = "Name";
            this.columnHeadername.Width = 172;
            // 
            // columnHeadertime
            // 
            this.columnHeadertime.Text = "Last Changed";
            this.columnHeadertime.Width = 186;
            // 
            // columnHeadertype
            // 
            this.columnHeadertype.Text = "Type";
            this.columnHeadertype.Width = 115;
            // 
            // columnHeadersize
            // 
            this.columnHeadersize.Text = "Size";
            this.columnHeadersize.Width = 219;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openWithToolStripMenuItem,
            this.zip7ToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator5,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.toolStripSeparator6,
            this.propertyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 364);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::DcRat.Properties.Resources.folder_open_dark;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiddenToolStripMenuItem,
            this.createNewDesktopToolStripMenuItem});
            this.openWithToolStripMenuItem.Image = global::DcRat.Properties.Resources.folder_open_dark;
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.openWithToolStripMenuItem.Text = "Open With";
            // 
            // hiddenToolStripMenuItem
            // 
            this.hiddenToolStripMenuItem.Image = global::DcRat.Properties.Resources.folder_open_dark;
            this.hiddenToolStripMenuItem.Name = "hiddenToolStripMenuItem";
            this.hiddenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.hiddenToolStripMenuItem.Text = "Hidden";
            // 
            // createNewDesktopToolStripMenuItem
            // 
            this.createNewDesktopToolStripMenuItem.Image = global::DcRat.Properties.Resources.folder_open_dark;
            this.createNewDesktopToolStripMenuItem.Name = "createNewDesktopToolStripMenuItem";
            this.createNewDesktopToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.createNewDesktopToolStripMenuItem.Text = "CreateNewDesktop";
            // 
            // zip7ToolStripMenuItem
            // 
            this.zip7ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zipToolStripMenuItem,
            this.unzipToolStripMenuItem});
            this.zip7ToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_zip_dark;
            this.zip7ToolStripMenuItem.Name = "zip7ToolStripMenuItem";
            this.zip7ToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.zip7ToolStripMenuItem.Text = "7-zip";
            // 
            // zipToolStripMenuItem
            // 
            this.zipToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_zip_dark;
            this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
            this.zipToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.zipToolStripMenuItem.Text = "Zip";
            // 
            // unzipToolStripMenuItem
            // 
            this.unzipToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_zip_dark;
            this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
            this.unzipToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.unzipToolStripMenuItem.Text = "Unzip";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(151, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::DcRat.Properties.Resources.copy_dark;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::DcRat.Properties.Resources.cut_dark;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_plus_dark;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(151, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DcRat.Properties.Resources.delete_dark;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Image = global::DcRat.Properties.Resources.file_1_dark;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(151, 6);
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Image = global::DcRat.Properties.Resources.database_set_dark;
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.propertyToolStripMenuItem.Text = "Property";
            // 
            // singleFormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.listViewfile);
            this.Controls.Add(this.toolStripfile);
            this.Controls.Add(this.paneltop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "singleFormFile";
            this.Text = "y";
            this.paneltop.ResumeLayout(false);
            this.toolStripfile.ResumeLayout(false);
            this.toolStripfile.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelDcRat;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.ToolStrip toolStripfile;
        private System.Windows.Forms.ToolStripButton toolStripButtonback;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxaddress;
        private System.Windows.Forms.ToolStripButton toolStripButtongoto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonrefresh;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonnew;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonupload;
        private System.Windows.Forms.ToolStripButton toolStripButtondownload;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonjump;
        private System.Windows.Forms.ToolStripMenuItem appdataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem system32ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tempToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ListView listViewfile;
        private System.Windows.Forms.ColumnHeader columnHeadername;
        private System.Windows.Forms.ColumnHeader columnHeadertime;
        private System.Windows.Forms.ColumnHeader columnHeadertype;
        private System.Windows.Forms.ColumnHeader columnHeadersize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zip7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
    }
}