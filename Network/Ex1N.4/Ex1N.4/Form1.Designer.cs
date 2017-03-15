namespace Ex1N._4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.IpToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.PortToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ConnectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendTextBox
            // 
            this.SendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendTextBox.Enabled = false;
            this.SendTextBox.Location = new System.Drawing.Point(12, 116);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(304, 20);
            this.SendTextBox.TabIndex = 0;
            this.SendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SendTextBox_KeyPress);
            // 
            // LogListBox
            // 
            this.LogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogListBox.Enabled = false;
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.Location = new System.Drawing.Point(12, 28);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(304, 82);
            this.LogListBox.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IpToolStripTextBox,
            this.PortToolStripTextBox,
            this.ConnectToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(327, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // IpToolStripTextBox
            // 
            this.IpToolStripTextBox.Name = "IpToolStripTextBox";
            this.IpToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.IpToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripTextBox_KeyPress);
            // 
            // PortToolStripTextBox
            // 
            this.PortToolStripTextBox.Name = "PortToolStripTextBox";
            this.PortToolStripTextBox.Size = new System.Drawing.Size(30, 25);
            this.PortToolStripTextBox.Text = "7913";
            this.PortToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripTextBox_KeyPress);
            // 
            // ConnectToolStripButton
            // 
            this.ConnectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ConnectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ConnectToolStripButton.Image")));
            this.ConnectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConnectToolStripButton.Name = "ConnectToolStripButton";
            this.ConnectToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.ConnectToolStripButton.Text = "Connect";
            this.ConnectToolStripButton.Click += new System.EventHandler(this.ConnectToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 146);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LogListBox);
            this.Controls.Add(this.SendTextBox);
            this.Name = "Form1";
            this.Text = "Client";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox IpToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox PortToolStripTextBox;
        private System.Windows.Forms.ToolStripButton ConnectToolStripButton;
    }
}

