using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Ex1E._4
{
    public partial class MainForm : Form
    {
        private object[] BaudRates = {110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 56000, 57600, 115200};
        private SerialPort SP;
        private string appendix = null;
        private bool localEcho;
        public MainForm()
        {
            InitializeComponent();
            PortBaudRateToolStripComboBox.Items.AddRange(BaudRates);
            PortBaudRateToolStripComboBox.SelectedItem = 9600;
            PortParityToolStripComboBox.Items.AddRange(Enum.GetValues(typeof(Parity)).Cast<object>().ToArray());
            PortParityToolStripComboBox.SelectedItem = Parity.None;
            PortDatabitsToolStripComboBox.Items.AddRange(new object[] { 8, 9 });
            PortDatabitsToolStripComboBox.SelectedItem = 8;
            PortStopBitsToolStripComboBox.Items.AddRange(Enum.GetValues(typeof(StopBits)).Cast<object>().ToArray());
            PortStopBitsToolStripComboBox.SelectedItem = StopBits.One;

            PortSelectToolStripComboBox.Items.AddRange(SerialPort.GetPortNames());
            if(PortSelectToolStripComboBox.Items.Count>0)
            {
                PortSelectToolStripComboBox.SelectedIndex = 0;
            }
            localEcho = localEchoToolStripMenuItem.Checked;
        }

        private void PortSelectToolStripComboBox_DropDown(object sender, EventArgs e)
        {
            PortSelectToolStripComboBox.Items.Clear();
            PortSelectToolStripComboBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void OpenPort()
        {
            try
            {
                SP = new SerialPort(
                    (string)PortSelectToolStripComboBox.SelectedItem,
                    (int)PortBaudRateToolStripComboBox.SelectedItem,
                    (Parity)PortParityToolStripComboBox.SelectedIndex,
                    (int)PortDatabitsToolStripComboBox.SelectedItem,
                    (StopBits)PortStopBitsToolStripComboBox.SelectedIndex)
                {
                    WriteTimeout = 3000
                };
                SP.Open();
                if (SP.IsOpen)
                {
                    PortSelectToolStripComboBox.Enabled = false;
                    PortBaudRateToolStripComboBox.Enabled = false;
                    PortParityToolStripComboBox.Enabled = false;
                    PortDatabitsToolStripComboBox.Enabled = false;
                    PortStopBitsToolStripComboBox.Enabled = false;
                    PortOutgoingTextBox.Enabled = true;
                    PortTransmitButton.Enabled = true;

                    SP.DataReceived += SP_DataReceived;
                    PortOpenToolStripButton.Text = "Close";
                }
            }
            catch (UnauthorizedAccessException uae)
            {
                MessageBox.Show(uae.Message, "Could not open port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClosePort();
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message, "Could not open port", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClosePort();
            }
        }

        private void ClosePort()
        {
            SP.DataReceived -= SP_DataReceived;
            SP.Close();
            PortOpenToolStripButton.Text = "Open";

            PortSelectToolStripComboBox.Enabled = true;
            PortBaudRateToolStripComboBox.Enabled = true;
            PortParityToolStripComboBox.Enabled = true;
            PortDatabitsToolStripComboBox.Enabled = true;
            PortStopBitsToolStripComboBox.Enabled = true;
            PortOutgoingTextBox.Enabled = false;
            PortTransmitButton.Enabled = false;
        }

        private void PortOpenToolStripButton_Click(object sender, EventArgs e)
        {
            if (PortOpenToolStripButton.Text == "Open")
            {
                OpenPort();
            }
            else
            {
                ClosePort();
            }
        }

        private void AddIncomming(string text)
        {
            PortIncommingTextBox.Text += text;
            PortIncommingTextBox.SelectionStart = PortIncommingTextBox.TextLength;
        }

        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker) delegate (){ AddIncomming(SP.ReadExisting()); });
        }

        private void PortTransmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                SP.Write(PortOutgoingTextBox.Text + appendix);
                if (localEcho)
                {
                    PortIncommingTextBox.Text += PortOutgoingTextBox.Text + appendix;
                }
            }
            catch(TimeoutException)
            {
                MessageBox.Show("Connection timed out during attempt to transmit message.\nClosing connection", "Closing connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PortOpenToolStripButton_Click(sender, e);
            }
            finally
            {
                PortOutgoingTextBox.Text = "";
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogSaveFileDialog.ShowDialog();
        }

        private void AppendCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            foreach(ToolStripMenuItem item in ((sender as ToolStripMenuItem).OwnerItem as ToolStripMenuItem).DropDownItems)
            {
                item.Checked = (item == clickedItem);
            }
            switch(clickedItem.Text)
            {
                case "CR":
                    appendix = "\r";
                    break;
                case "LF":
                    appendix = "\n";
                    break;
                case "CR+LF":
                    appendix = "\r\n";
                    break;
                case "Nothing":
                    appendix = null;
                    break;
                default:
                    break;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OutgoingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                PortTransmitButton_Click(sender, null);
            }
        }

        private void LogSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            PortIncommingTextBox.SaveFile(LogSaveFileDialog.FileName);
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortIncommingTextBox.Clear();
        }

        private void LocalEchoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localEcho = localEchoToolStripMenuItem.Checked;
        }
    }
}
