using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace Ex1N._4
{
    public partial class Form1 : Form
    {
        Socket S = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectToolStripButton_Click(object sender, EventArgs e)
        {
            if(IPAddress.TryParse(IpToolStripTextBox.Text, out IPAddress IP))
            {
                Connect(IP);
            }
        }

        private void Connect(IPAddress ip)
        {
            S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            S.Connect(ip, int.Parse(PortToolStripTextBox.Text));
            IpToolStripTextBox.Enabled = false;
            PortToolStripTextBox.Enabled = false;
            SendTextBox.Enabled = true;
            LogListBox.Enabled = true;
        }

        private void Disconnect()
        {
            if (S != null)
            {
                S.Disconnect(false);
                S.Close();
            }
            IpToolStripTextBox.Enabled = true;
            PortToolStripTextBox.Enabled = true;
            SendTextBox.Enabled = false;
            LogListBox.Enabled = false;
        }
        private void SendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(S != null)
                {
                    if(S.Connected)
                    {
                        try
                        {
                            S.Send(Encoding.UTF8.GetBytes(SendTextBox.Text));
                            SendTextBox.Text = "";
                        }
                        catch(SocketException)
                        {
                            Disconnect();
                        }
                    }
                    else
                    {
                        Disconnect();
                    }
                }
            }
        }

        private void ToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ConnectToolStripButton_Click(sender, e);
            }
        }
    }
}
