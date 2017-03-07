using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6._0
{
    public partial class Form1 : Form
    {
        enum Radiobuttons { add, subtract, multiply, divide, modulo};
        Radiobuttons selection;
        int baseNumber;
        string prefix;
        public Form1()
        {
            InitializeComponent();
            formatComboBox.SelectedIndex = 0;
        }

        private void radiobuttonChange(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "plusRadioButton":
                    selection = Radiobuttons.add;
                    break;
                case "minusRadioButton":
                    selection = Radiobuttons.subtract;
                    break;
                case "multiplyRadioButton":
                    selection = Radiobuttons.multiply;
                    break;
                case "divideRadioButton":
                    selection = Radiobuttons.divide;
                    break;
                case "moduloRadioButton":
                    selection = Radiobuttons.modulo;
                    break;
            }
            calculate();
        }

        private void calculate()
        {
            double num1, num2;
            double result = 0;            
            
            if (double.TryParse(textBox1.Text, out num1) && double.TryParse(textBox2.Text, out num2))
            {
                expressionLabel.Text = textBox1.Text;
                switch (selection)
                {
                    case Radiobuttons.add:
                        result = (num1 + num2);
                        expressionLabel.Text += " + ";
                        break;
                    case Radiobuttons.subtract:
                        result = (num1 - num2);
                        expressionLabel.Text += " - ";
                        break;
                    case Radiobuttons.multiply:
                        result = (num1 * num2);
                        expressionLabel.Text += " * ";
                        break;
                    case Radiobuttons.divide:
                        result = (num1 / num2);
                        expressionLabel.Text += " / ";
                        break;
                    case Radiobuttons.modulo:
                        result = (num1 % num2);
                        expressionLabel.Text += " % ";
                        break;
                    default:
                        result = 0;
                        break;
                }

                if (result % 1 == 0)
                {
                    resultLabel.Text = prefix + Convert.ToString((int)result, baseNumber);
                }
                else
                {
                    formatComboBox.SelectedIndex = 0;
                    resultLabel.Text = Convert.ToString(result);
                }
                expressionLabel.Text += textBox2.Text + " = " + resultLabel.Text;
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(formatComboBox.SelectedIndex)
            {
                case 0:
                    baseNumber = 10;
                    prefix = "";
                    break;
                case 1:
                    baseNumber = 2;
                    prefix = "0b";
                    break;
                case 2:
                    baseNumber = 16;
                    prefix = "0x";
                    break;
                default:
                    baseNumber = 10;
                    prefix = "";
                    break;
            }
            calculate();
        }
    }
}
