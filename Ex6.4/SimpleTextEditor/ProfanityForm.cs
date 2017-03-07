using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class ProfanityForm : Form
    {
        public ProfanityForm()
        {
            InitializeComponent();
        }

        private void ProfaneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(profaneListBox.Items.Contains(profaneTextBox.Text) == false)
                {
                    profaneListBox.Items.Add(profaneTextBox.Text);
                }
                profaneTextBox.Text = "";
            }
        }

        private void ProfaneListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
      
        }

        private void ProfanityForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void ProfaneListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (profaneListBox.SelectedIndex >= 0)
                {
                    profaneListBox.Items.RemoveAt(profaneListBox.SelectedIndex);
                }
            }
        }
    }
}
