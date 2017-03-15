namespace Host
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.HostAddressToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.HostToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LogListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RecieveListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SocketCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.HostAddressToolStripComboBox,
            this.HostToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel1.Text = "Host interface:";
            // 
            // HostAddressToolStripComboBox
            // 
            this.HostAddressToolStripComboBox.DropDownWidth = 300;
            this.HostAddressToolStripComboBox.Font = new System.Drawing.Font("Consolas", 9F);
            this.HostAddressToolStripComboBox.Name = "HostAddressToolStripComboBox";
            this.HostAddressToolStripComboBox.Size = new System.Drawing.Size(500, 25);
            // 
            // HostToolStripButton
            // 
            this.HostToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HostToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("HostToolStripButton.Image")));
            this.HostToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HostToolStripButton.Name = "HostToolStripButton";
            this.HostToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.HostToolStripButton.Text = "Host";
            this.HostToolStripButton.Click += new System.EventHandler(this.HostToolStripButton_Click);
            // 
            // LogListView
            // 
            this.LogListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LogListView.FullRowSelect = true;
            this.LogListView.GridLines = true;
            this.LogListView.Location = new System.Drawing.Point(0, 259);
            this.LogListView.Name = "LogListView";
            this.LogListView.Size = new System.Drawing.Size(1016, 185);
            this.LogListView.TabIndex = 2;
            this.LogListView.UseCompatibleStateImageBehavior = false;
            this.LogListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time stamp:";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Log entries";
            this.columnHeader2.Width = 862;
            // 
            // RecieveListBox
            // 
            this.RecieveListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecieveListBox.FormattingEnabled = true;
            this.RecieveListBox.Location = new System.Drawing.Point(0, 28);
            this.RecieveListBox.Name = "RecieveListBox";
            this.RecieveListBox.Size = new System.Drawing.Size(1016, 225);
            this.RecieveListBox.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.SocketCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Location = new System.Drawing.Point(0, 425);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip2.TabIndex = 5;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "Active Sockets:";
            // 
            // SocketCountLabel
            // 
            this.SocketCountLabel.Name = "SocketCountLabel";
            this.SocketCountLabel.Size = new System.Drawing.Size(13, 17);
            this.SocketCountLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1016, 469);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RecieveListBox);
            this.Controls.Add(this.LogListView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Host";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox HostAddressToolStripComboBox;
        private System.Windows.Forms.ToolStripButton HostToolStripButton;
        private System.Windows.Forms.ListView LogListView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListBox RecieveListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SocketCountLabel;
    }
}

