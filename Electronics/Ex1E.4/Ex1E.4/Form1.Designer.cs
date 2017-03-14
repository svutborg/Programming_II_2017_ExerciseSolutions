namespace Ex1E._4
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
            this.PortIncommingTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PortSelectToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PortBaudRateToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PortParityToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PortDatabitsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PortStopBitsToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PortOpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PortOutgoingTextBox = new System.Windows.Forms.TextBox();
            this.PortTransmitButton = new System.Windows.Forms.Button();
            this.LogSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.appendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cRLFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nothingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.localEchoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortIncommingTextBox
            // 
            this.PortIncommingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortIncommingTextBox.Location = new System.Drawing.Point(12, 28);
            this.PortIncommingTextBox.Name = "PortIncommingTextBox";
            this.PortIncommingTextBox.ReadOnly = true;
            this.PortIncommingTextBox.Size = new System.Drawing.Size(723, 306);
            this.PortIncommingTextBox.TabIndex = 0;
            this.PortIncommingTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.PortSelectToolStripComboBox,
            this.PortBaudRateToolStripComboBox,
            this.PortParityToolStripComboBox,
            this.PortDatabitsToolStripComboBox,
            this.PortStopBitsToolStripComboBox,
            this.PortOpenToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(747, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // PortSelectToolStripComboBox
            // 
            this.PortSelectToolStripComboBox.Name = "PortSelectToolStripComboBox";
            this.PortSelectToolStripComboBox.Size = new System.Drawing.Size(75, 25);
            this.PortSelectToolStripComboBox.DropDown += new System.EventHandler(this.PortSelectToolStripComboBox_DropDown);
            // 
            // PortBaudRateToolStripComboBox
            // 
            this.PortBaudRateToolStripComboBox.Name = "PortBaudRateToolStripComboBox";
            this.PortBaudRateToolStripComboBox.Size = new System.Drawing.Size(75, 25);
            // 
            // PortParityToolStripComboBox
            // 
            this.PortParityToolStripComboBox.Name = "PortParityToolStripComboBox";
            this.PortParityToolStripComboBox.Size = new System.Drawing.Size(75, 25);
            // 
            // PortDatabitsToolStripComboBox
            // 
            this.PortDatabitsToolStripComboBox.Name = "PortDatabitsToolStripComboBox";
            this.PortDatabitsToolStripComboBox.Size = new System.Drawing.Size(75, 25);
            // 
            // PortStopBitsToolStripComboBox
            // 
            this.PortStopBitsToolStripComboBox.Name = "PortStopBitsToolStripComboBox";
            this.PortStopBitsToolStripComboBox.Size = new System.Drawing.Size(75, 25);
            // 
            // PortOpenToolStripButton
            // 
            this.PortOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PortOpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PortOpenToolStripButton.Image")));
            this.PortOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PortOpenToolStripButton.Name = "PortOpenToolStripButton";
            this.PortOpenToolStripButton.Size = new System.Drawing.Size(40, 22);
            this.PortOpenToolStripButton.Text = "Open";
            this.PortOpenToolStripButton.Click += new System.EventHandler(this.PortOpenToolStripButton_Click);
            // 
            // PortOutgoingTextBox
            // 
            this.PortOutgoingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortOutgoingTextBox.Enabled = false;
            this.PortOutgoingTextBox.Location = new System.Drawing.Point(12, 341);
            this.PortOutgoingTextBox.Name = "PortOutgoingTextBox";
            this.PortOutgoingTextBox.Size = new System.Drawing.Size(642, 20);
            this.PortOutgoingTextBox.TabIndex = 2;
            this.PortOutgoingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OutgoingTextBox_KeyPress);
            // 
            // PortTransmitButton
            // 
            this.PortTransmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTransmitButton.Enabled = false;
            this.PortTransmitButton.Location = new System.Drawing.Point(660, 341);
            this.PortTransmitButton.Name = "PortTransmitButton";
            this.PortTransmitButton.Size = new System.Drawing.Size(75, 20);
            this.PortTransmitButton.TabIndex = 3;
            this.PortTransmitButton.Text = "Transmit";
            this.PortTransmitButton.UseVisualStyleBackColor = true;
            this.PortTransmitButton.Click += new System.EventHandler(this.PortTransmitButton_Click);
            // 
            // LogSaveFileDialog
            // 
            this.LogSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LogSaveFileDialog_FileOk);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(43, 22);
            this.toolStripDropDownButton1.Text = "Files";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appendToolStripMenuItem1,
            this.localEchoToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton2.Text = "Settings";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // appendToolStripMenuItem1
            // 
            this.appendToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRToolStripMenuItem1,
            this.lFToolStripMenuItem1,
            this.cRLFToolStripMenuItem1,
            this.nothingToolStripMenuItem1});
            this.appendToolStripMenuItem1.Name = "appendToolStripMenuItem1";
            this.appendToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.appendToolStripMenuItem1.Text = "Append";
            // 
            // cRToolStripMenuItem1
            // 
            this.cRToolStripMenuItem1.Name = "cRToolStripMenuItem1";
            this.cRToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cRToolStripMenuItem1.Text = "CR";
            this.cRToolStripMenuItem1.Click += new System.EventHandler(this.AppendCharacterToolStripMenuItem_Click);
            // 
            // lFToolStripMenuItem1
            // 
            this.lFToolStripMenuItem1.Name = "lFToolStripMenuItem1";
            this.lFToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.lFToolStripMenuItem1.Text = "LF";
            this.lFToolStripMenuItem1.Click += new System.EventHandler(this.AppendCharacterToolStripMenuItem_Click);
            // 
            // cRLFToolStripMenuItem1
            // 
            this.cRLFToolStripMenuItem1.Name = "cRLFToolStripMenuItem1";
            this.cRLFToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cRLFToolStripMenuItem1.Text = "CR+LF";
            this.cRLFToolStripMenuItem1.Click += new System.EventHandler(this.AppendCharacterToolStripMenuItem_Click);
            // 
            // nothingToolStripMenuItem1
            // 
            this.nothingToolStripMenuItem1.Name = "nothingToolStripMenuItem1";
            this.nothingToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.nothingToolStripMenuItem1.Text = "Nothing";
            this.nothingToolStripMenuItem1.Click += new System.EventHandler(this.AppendCharacterToolStripMenuItem_Click);
            // 
            // localEchoToolStripMenuItem
            // 
            this.localEchoToolStripMenuItem.Checked = true;
            this.localEchoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.localEchoToolStripMenuItem.Name = "localEchoToolStripMenuItem";
            this.localEchoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.localEchoToolStripMenuItem.Text = "Local Echo";
            this.localEchoToolStripMenuItem.Click += new System.EventHandler(this.LocalEchoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 372);
            this.Controls.Add(this.PortTransmitButton);
            this.Controls.Add(this.PortOutgoingTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.PortIncommingTextBox);
            this.Name = "MainForm";
            this.Text = "COM Port Writer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PortIncommingTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox PortSelectToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox PortBaudRateToolStripComboBox;
        private System.Windows.Forms.ToolStripButton PortOpenToolStripButton;
        private System.Windows.Forms.TextBox PortOutgoingTextBox;
        private System.Windows.Forms.Button PortTransmitButton;
        private System.Windows.Forms.ToolStripComboBox PortStopBitsToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox PortParityToolStripComboBox;
        private System.Windows.Forms.ToolStripComboBox PortDatabitsToolStripComboBox;
        private System.Windows.Forms.SaveFileDialog LogSaveFileDialog;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem appendToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cRLFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nothingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem localEchoToolStripMenuItem;
    }
}

