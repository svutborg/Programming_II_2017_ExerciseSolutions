namespace SimpleTextEditor
{
    partial class ProfanityForm
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
            this.profaneListBox = new System.Windows.Forms.ListBox();
            this.profaneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // profaneListBox
            // 
            this.profaneListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profaneListBox.FormattingEnabled = true;
            this.profaneListBox.Items.AddRange(new object[] {
            "some",
            "words",
            "are",
            "forbidden",
            "and",
            "some",
            "are",
            "not"});
            this.profaneListBox.Location = new System.Drawing.Point(11, 38);
            this.profaneListBox.Name = "profaneListBox";
            this.profaneListBox.Size = new System.Drawing.Size(336, 277);
            this.profaneListBox.TabIndex = 0;
            this.profaneListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProfaneListBox_KeyDown);
            this.profaneListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProfaneListBox_KeyPress);
            // 
            // profaneTextBox
            // 
            this.profaneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profaneTextBox.Location = new System.Drawing.Point(12, 12);
            this.profaneTextBox.Name = "profaneTextBox";
            this.profaneTextBox.Size = new System.Drawing.Size(335, 20);
            this.profaneTextBox.TabIndex = 1;
            this.profaneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProfaneTextBox_KeyPress);
            // 
            // ProfanityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 324);
            this.Controls.Add(this.profaneTextBox);
            this.Controls.Add(this.profaneListBox);
            this.Name = "ProfanityForm";
            this.Text = "Profane words";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfanityForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox profaneListBox;
        private System.Windows.Forms.TextBox profaneTextBox;
    }
}