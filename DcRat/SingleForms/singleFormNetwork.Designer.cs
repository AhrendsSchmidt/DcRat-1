
namespace DcRat.ChildForms
{
    partial class singleFormNetwork
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
            this.listViewnetwork = new System.Windows.Forms.ListView();
            this.columnHeaderpid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeadername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderlocaladdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderremoteaddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderstate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paneltop.SuspendLayout();
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
            this.paneltop.Size = new System.Drawing.Size(1048, 45);
            this.paneltop.TabIndex = 2;
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
            this.labelDcRat.Size = new System.Drawing.Size(910, 45);
            this.labelDcRat.TabIndex = 1;
            this.labelDcRat.Text = "DcRat - Network - ";
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
            this.buttonmin.Location = new System.Drawing.Point(916, 3);
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
            this.buttonmax.Location = new System.Drawing.Point(961, 3);
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
            this.buttonclose.Location = new System.Drawing.Point(1006, 3);
            this.buttonclose.Name = "buttonclose";
            this.buttonclose.Size = new System.Drawing.Size(39, 39);
            this.buttonclose.TabIndex = 0;
            this.buttonclose.UseVisualStyleBackColor = false;
            this.buttonclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // listViewnetwork
            // 
            this.listViewnetwork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderpid,
            this.columnHeadername,
            this.columnHeaderlocaladdress,
            this.columnHeaderremoteaddress,
            this.columnHeaderstate});
            this.listViewnetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewnetwork.HideSelection = false;
            this.listViewnetwork.Location = new System.Drawing.Point(0, 45);
            this.listViewnetwork.Name = "listViewnetwork";
            this.listViewnetwork.OwnerDraw = true;
            this.listViewnetwork.Size = new System.Drawing.Size(1048, 581);
            this.listViewnetwork.TabIndex = 3;
            this.listViewnetwork.UseCompatibleStateImageBehavior = false;
            this.listViewnetwork.View = System.Windows.Forms.View.Details;
            this.listViewnetwork.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewnetwork_DrawColumnHeader);
            this.listViewnetwork.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listViewnetwork_DrawItem);
            // 
            // columnHeaderpid
            // 
            this.columnHeaderpid.Text = "Process ID";
            this.columnHeaderpid.Width = 123;
            // 
            // columnHeadername
            // 
            this.columnHeadername.Text = "Process Name";
            this.columnHeadername.Width = 188;
            // 
            // columnHeaderlocaladdress
            // 
            this.columnHeaderlocaladdress.Text = "Local Address";
            this.columnHeaderlocaladdress.Width = 176;
            // 
            // columnHeaderremoteaddress
            // 
            this.columnHeaderremoteaddress.Text = "Remote Address";
            this.columnHeaderremoteaddress.Width = 213;
            // 
            // columnHeaderstate
            // 
            this.columnHeaderstate.Text = "State";
            this.columnHeaderstate.Width = 192;
            // 
            // singleFormNetwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 626);
            this.Controls.Add(this.listViewnetwork);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "singleFormNetwork";
            this.Text = "childFormNetwork";
            this.paneltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label labelDcRat;
        private System.Windows.Forms.Button buttonmin;
        private System.Windows.Forms.Button buttonmax;
        private System.Windows.Forms.Button buttonclose;
        private System.Windows.Forms.ListView listViewnetwork;
        private System.Windows.Forms.ColumnHeader columnHeaderpid;
        private System.Windows.Forms.ColumnHeader columnHeadername;
        private System.Windows.Forms.ColumnHeader columnHeaderlocaladdress;
        private System.Windows.Forms.ColumnHeader columnHeaderremoteaddress;
        private System.Windows.Forms.ColumnHeader columnHeaderstate;
    }
}