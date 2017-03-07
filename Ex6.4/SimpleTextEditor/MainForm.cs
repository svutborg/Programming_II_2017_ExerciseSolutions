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
    public partial class MainForm : Form
    {
        const string defaultFileName = "Untitled";
        string fileName;
        bool changes = false;
        int searchIndex = 0;
        StringComparison sc;
        ProfanityForm PF;

        public MainForm()
        {
            InitializeComponent();
            ChangeFilename(defaultFileName);
            splitContainer1.Panel2Collapsed = true;
            MatchCaseCheckBox_CheckedChanged(this, EventArgs.Empty);
            PF = new ProfanityForm();
            profanityTimer.Start();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox Ab = new AboutBox();
            Ab.Show();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmClear();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changes == true)
            {
                if (ConfirmClear() == true)
                {
                    openFileDialog1.ShowDialog();
                }
            }
            else
            {
                openFileDialog1.ShowDialog();
            }
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            changes = false;
            ChangeFilename(openFileDialog1.FileName);
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == defaultFileName)
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                changes = false;
                ChangeFilename(fileName);
            }

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (changes == false)
            {
                this.Text = "*" + this.Text;
            }
            changes = true;
        }

        private void ChangeFilename(string fn)
        {
            fileName = fn;
            this.Text = fileName + " - Simple Text Editor";
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            ChangeFilename(saveFileDialog1.FileName);
            changes = false;
        }

        private bool ConfirmClear()
        {
            bool cleared = false;
            DialogResult res;
            if (changes == true)
            {
                res = MessageBox.Show($"Do you want to save changes to {fileName}", "Save Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
                switch (res)
                {
                    case DialogResult.Yes:
                        if (fileName.Equals(defaultFileName) == true)
                        {
                            saveFileDialog1.ShowDialog();
                        }
                        if (changes == false)
                        {
                            ClearText();
                            cleared = true;
                        }
                        break;
                    case DialogResult.No:
                        ClearText();
                        cleared = true;
                        break;
                    case DialogResult.Cancel:
                    default:
                        break;
                }
            }
            else
            {
                ClearText();
                cleared = true;
            }
            return cleared;
        }

        private void ClearText()
        {
            richTextBox1.Clear();
            ChangeFilename(defaultFileName);
            changes = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.Text = richTextBox1.Text.Remove(index, richTextBox1.SelectedText.Length);
            richTextBox1.SelectionStart = index;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConfirmClear() != true)
            {
                e.Cancel = true;
            }
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            bool reset = false;

            if (richTextBox1.SelectionStart + searchIndex > richTextBox1.Text.Length)
            {
                searchIndex = 0;
                DialogResult res = MessageBox.Show($"No more occurences of {findTextBox.Text} in the document.\nSearch from the beginning?", "No more occurences", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(res == DialogResult.Yes)
                {
                    richTextBox1.SelectionStart = 0;
                }
                reset = true;
            }
            searchIndex = richTextBox1.Text.IndexOf(findTextBox.Text, richTextBox1.SelectionStart+searchIndex, sc);
            if(searchIndex < 0)
            {
                searchIndex = 0;
                DialogResult res = MessageBox.Show($"No more occurences of {findTextBox.Text} in the document.\nSearch from the beginning?", "No more occurences", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    richTextBox1.SelectionStart = 0;
                }
                reset = true;
            }
            richTextBox1.Select(searchIndex, findTextBox.Text.Length);
            if (!reset)
            {
                searchIndex++;
            }
            richTextBox1.Focus();
        }

        private void FindTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            int index = 0, count = 0;
            while ((index = richTextBox1.Text.IndexOf(findTextBox.Text, index, sc))>=0)
            {
                index++;
                count++;
            }
            MessageBox.Show(Convert.ToString(count));
        }

        private void MatchCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (matchCaseCheckBox.Checked)
            {
                sc = StringComparison.CurrentCulture;
            }
            else
            {
                sc = StringComparison.CurrentCultureIgnoreCase;
            }
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            FindButton_Click(sender, e);
            int index = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Remove(index, richTextBox1.SelectedText.Length);
            richTextBox1.Text = richTextBox1.Text.Insert(index, replaceTextBox.Text);
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            while ((index = richTextBox1.Text.IndexOf(findTextBox.Text, index, sc)) >= 0)
            {
                richTextBox1.Select(index, findTextBox.Text.Length);
                richTextBox1.Text = richTextBox1.Text.Remove(index, richTextBox1.SelectedText.Length);
                richTextBox1.Text = richTextBox1.Text.Insert(index, replaceTextBox.Text);
                index += replaceTextBox.Text.Length;
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Insert(index, Clipboard.GetText());
            richTextBox1.SelectionStart = index + Clipboard.GetText().Length;
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            searchIndex = 0;
        }

        private void ProfinityFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PF.Show();
        }

        private void ProfanityTimer_Tick(object sender, EventArgs e)
        {//TODO there seem to be a bug in this method (It deletes to much)
            foreach (string word in PF.profaneListBox.Items)
            {
                string replacement = new String('*', word.Length);
                int index = 0;
                while((index = richTextBox1.Text.IndexOf(word)) != -1)
                {
                    richTextBox1.Select(index, index + word.Length);
                    richTextBox1.SelectedText = replacement;
                }
            }
        }
    }
}
