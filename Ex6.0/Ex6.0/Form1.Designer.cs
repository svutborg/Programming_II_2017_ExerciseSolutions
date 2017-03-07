namespace Ex6._0
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
            this.calcButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plusRadioButton = new System.Windows.Forms.RadioButton();
            this.minusRadioButton = new System.Windows.Forms.RadioButton();
            this.multiplyRadioButton = new System.Windows.Forms.RadioButton();
            this.divideRadioButton = new System.Windows.Forms.RadioButton();
            this.moduloRadioButton = new System.Windows.Forms.RadioButton();
            this.resultLabel = new System.Windows.Forms.Label();
            this.expressionLabel = new System.Windows.Forms.Label();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(259, 35);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(32, 62);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "=";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 62);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(153, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 62);
            this.textBox2.TabIndex = 2;
            // 
            // plusRadioButton
            // 
            this.plusRadioButton.AutoSize = true;
            this.plusRadioButton.Checked = true;
            this.plusRadioButton.Location = new System.Drawing.Point(119, 12);
            this.plusRadioButton.Name = "plusRadioButton";
            this.plusRadioButton.Size = new System.Drawing.Size(31, 17);
            this.plusRadioButton.TabIndex = 3;
            this.plusRadioButton.TabStop = true;
            this.plusRadioButton.Text = "+";
            this.plusRadioButton.UseVisualStyleBackColor = true;
            this.plusRadioButton.CheckedChanged += new System.EventHandler(this.radiobuttonChange);
            // 
            // minusRadioButton
            // 
            this.minusRadioButton.AutoSize = true;
            this.minusRadioButton.Location = new System.Drawing.Point(119, 35);
            this.minusRadioButton.Name = "minusRadioButton";
            this.minusRadioButton.Size = new System.Drawing.Size(28, 17);
            this.minusRadioButton.TabIndex = 4;
            this.minusRadioButton.Text = "-";
            this.minusRadioButton.UseVisualStyleBackColor = true;
            this.minusRadioButton.CheckedChanged += new System.EventHandler(this.radiobuttonChange);
            // 
            // multiplyRadioButton
            // 
            this.multiplyRadioButton.AutoSize = true;
            this.multiplyRadioButton.Location = new System.Drawing.Point(119, 58);
            this.multiplyRadioButton.Name = "multiplyRadioButton";
            this.multiplyRadioButton.Size = new System.Drawing.Size(29, 17);
            this.multiplyRadioButton.TabIndex = 5;
            this.multiplyRadioButton.Text = "*";
            this.multiplyRadioButton.UseVisualStyleBackColor = true;
            this.multiplyRadioButton.CheckedChanged += new System.EventHandler(this.radiobuttonChange);
            // 
            // divideRadioButton
            // 
            this.divideRadioButton.AutoSize = true;
            this.divideRadioButton.Location = new System.Drawing.Point(119, 81);
            this.divideRadioButton.Name = "divideRadioButton";
            this.divideRadioButton.Size = new System.Drawing.Size(30, 17);
            this.divideRadioButton.TabIndex = 6;
            this.divideRadioButton.Text = "/";
            this.divideRadioButton.UseVisualStyleBackColor = true;
            this.divideRadioButton.CheckedChanged += new System.EventHandler(this.radiobuttonChange);
            // 
            // moduloRadioButton
            // 
            this.moduloRadioButton.AutoSize = true;
            this.moduloRadioButton.Location = new System.Drawing.Point(119, 104);
            this.moduloRadioButton.Name = "moduloRadioButton";
            this.moduloRadioButton.Size = new System.Drawing.Size(33, 17);
            this.moduloRadioButton.TabIndex = 7;
            this.moduloRadioButton.Text = "%";
            this.moduloRadioButton.UseVisualStyleBackColor = true;
            this.moduloRadioButton.CheckedChanged += new System.EventHandler(this.radiobuttonChange);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(297, 35);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(56, 55);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "--";
            // 
            // expressionLabel
            // 
            this.expressionLabel.AutoSize = true;
            this.expressionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionLabel.Location = new System.Drawing.Point(8, 130);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(19, 20);
            this.expressionLabel.TabIndex = 9;
            this.expressionLabel.Text = "--";
            // 
            // formatComboBox
            // 
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "Decimal",
            "Binary",
            "Hexedecimal"});
            this.formatComboBox.Location = new System.Drawing.Point(451, 132);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(121, 21);
            this.formatComboBox.TabIndex = 10;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Result format:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.expressionLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.moduloRadioButton);
            this.Controls.Add(this.divideRadioButton);
            this.Controls.Add(this.multiplyRadioButton);
            this.Controls.Add(this.minusRadioButton);
            this.Controls.Add(this.plusRadioButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calcButton);
            this.Name = "Form1";
            this.Text = "EasyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton plusRadioButton;
        private System.Windows.Forms.RadioButton minusRadioButton;
        private System.Windows.Forms.RadioButton multiplyRadioButton;
        private System.Windows.Forms.RadioButton divideRadioButton;
        private System.Windows.Forms.RadioButton moduloRadioButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.Label label1;
    }
}

