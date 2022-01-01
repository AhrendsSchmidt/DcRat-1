
namespace DcRat.ChildForms
{
    partial class childFormTasks
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Install",
            "On",
            "New Machine",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Run Script",
            "Off",
            "OnConnection",
            "0"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(childFormTasks));
            this.listViewtasks = new System.Windows.Forms.ListView();
            this.columnHeadertaskname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderstatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadertrigger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderexecutiontimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripTasks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListblank = new System.Windows.Forms.ImageList(this.components);
            this.updateUI = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewtasks
            // 
            this.listViewtasks.BackColor = System.Drawing.SystemColors.Window;
            this.listViewtasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadertaskname,
            this.columnHeaderstatus,
            this.columnHeadertrigger,
            this.columnHeaderexecutiontimes});
            this.listViewtasks.ContextMenuStrip = this.contextMenuStripTasks;
            this.listViewtasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewtasks.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewtasks.FullRowSelect = true;
            this.listViewtasks.HideSelection = false;
            this.listViewtasks.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewtasks.Location = new System.Drawing.Point(0, 0);
            this.listViewtasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewtasks.MultiSelect = false;
            this.listViewtasks.Name = "listViewtasks";
            this.listViewtasks.OwnerDraw = true;
            this.listViewtasks.Size = new System.Drawing.Size(1180, 481);
            this.listViewtasks.SmallImageList = this.imageListblank;
            this.listViewtasks.TabIndex = 0;
            this.listViewtasks.UseCompatibleStateImageBehavior = false;
            this.listViewtasks.View = System.Windows.Forms.View.Details;
            this.listViewtasks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewtasks_ColumnClick);
            this.listViewtasks.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewtasks_DrawColumnHeader);
            this.listViewtasks.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listViewtasks_DrawItem);
            this.listViewtasks.SelectedIndexChanged += new System.EventHandler(this.listViewtasks_SelectedIndexChanged);
            this.listViewtasks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewtasks_MouseDown);
            this.listViewtasks.MouseLeave += new System.EventHandler(this.listViewtasks_MouseLeave);
            this.listViewtasks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listViewtasks_MouseMove);
            // 
            // columnHeadertaskname
            // 
            this.columnHeadertaskname.Text = "TaskName";
            this.columnHeadertaskname.Width = 353;
            // 
            // columnHeaderstatus
            // 
            this.columnHeaderstatus.Text = "Status";
            this.columnHeaderstatus.Width = 122;
            // 
            // columnHeadertrigger
            // 
            this.columnHeadertrigger.Text = "Trigger";
            this.columnHeadertrigger.Width = 359;
            // 
            // columnHeaderexecutiontimes
            // 
            this.columnHeaderexecutiontimes.Text = "Execution Times";
            this.columnHeaderexecutiontimes.Width = 176;
            // 
            // contextMenuStripTasks
            // 
            this.contextMenuStripTasks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripTasks.Name = "contextMenuStripTasks";
            this.contextMenuStripTasks.Size = new System.Drawing.Size(124, 118);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(123, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // imageListblank
            // 
            this.imageListblank.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListblank.ImageSize = new System.Drawing.Size(1, 32);
            this.imageListblank.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // updateUI
            // 
            this.updateUI.Enabled = true;
            this.updateUI.Interval = 1000;
            this.updateUI.Tick += new System.EventHandler(this.updateUI_Tick);
            // 
            // childFormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 481);
            this.Controls.Add(this.listViewtasks);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "childFormTasks";
            this.Text = "childFormTasks";
            this.Load += new System.EventHandler(this.childFormTasks_Load);
            this.contextMenuStripTasks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewtasks;
        private System.Windows.Forms.ColumnHeader columnHeadertaskname;
        private System.Windows.Forms.ColumnHeader columnHeaderstatus;
        private System.Windows.Forms.ColumnHeader columnHeadertrigger;
        private System.Windows.Forms.ColumnHeader columnHeaderexecutiontimes;
        private System.Windows.Forms.ImageList imageListblank;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTasks;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Timer updateUI;
    }
}