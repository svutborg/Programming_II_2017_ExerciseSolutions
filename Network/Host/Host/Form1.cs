using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;


namespace Host
{
    enum CommandSet { SetUsername, Disconnect}
    public partial class MainForm : Form
    {
        Thread T;
        NetworkInterface[] interfaces;
        bool hosting = false;
        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            interfaces = NetworkInterface.GetAllNetworkInterfaces();

            Log("Finding available host interfaces");
            foreach (NetworkInterface ni in interfaces)
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            HostAddressToolStripComboBox.Items.Add(ip.Address.ToString().PadRight(15, ' ') + " - " + ni.Name);
                        }
                    }
                }
            }  
            if(HostAddressToolStripComboBox.Items.Count > 0)
            {
                HostAddressToolStripComboBox.SelectedIndex = 0;
            }
        }

        private void HostToolStripButton_Click(object sender, EventArgs e)
        {
            HostAddressToolStripComboBox.Enabled = false;

            if (IPAddress.TryParse(HostAddressToolStripComboBox.SelectedItem.ToString().Split(' ')[0], out IPAddress ip)) ;
            {
                TcpListener listener = new TcpListener(ip, 7913);
                listener.Start();
                hosting = true;
                T = new Thread(ListenerThreadStart)
                {
                    Name = "Listener Thread",
                    Priority = ThreadPriority.AboveNormal
                };
                T.Start(listener);
            }

        }

        private void Log(string entry)
        {
            LogListView.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString(), entry }));
        }

        private void ListenerThreadStart(object tcpListener)
        {
            TcpListener listener = tcpListener as TcpListener;
            List<Thread> clients = new List<Thread>();
            while(hosting)
            {
                if(listener.Pending())
                {
                    Socket S = listener.AcceptSocket();
                    clients.Add(
                        new Thread(SocketReader)
                        {
                            Name = S.RemoteEndPoint.ToString(),
                            Priority = ThreadPriority.BelowNormal
                        }
                    );
                    clients.Last().Start(S);
                }
                for (int i = 0; i < clients.Count; i++)
                {
                    if(clients[i].ThreadState != ThreadState.Running)
                    {
                        clients.RemoveAt(i--);
                    }
                }
            }
            listener.Stop();
        }

        private void SocketReader(object socket)
        {
            Socket S = socket as Socket;
            Peer P = new Peer("", S.RemoteEndPoint);
            this.Invoke((MethodInvoker)delegate () { Log(P.ToString() + " connected"); });
            this.Invoke((MethodInvoker)delegate () { SocketCountLabel.Text = (int.Parse(SocketCountLabel.Text) + 1).ToString(); });

            
            while (IsConnected(S))
            {
                try
                {

                    byte[] buf = new byte[S.ReceiveBufferSize];
                    S.Receive(buf);
                    string message = Encoding.UTF8.GetString(buf);
                    message = message.Split('\0')[0];
                    if (message != "")
                    {
                        bool command = false;

                        for (int i = 0; i < Enum.GetNames(typeof(CommandSet)).Length; i++)
                        {
                            if (message.Contains(((CommandSet)i).ToString()))
                            {
                                command = true;
                                switch ((CommandSet)i)
                                {
                                    case CommandSet.SetUsername:
                                        string[] strings = message.Split('=');
                                        for (int j = 0; j < strings.Length; j++)
                                        {
                                            if (strings[j] == CommandSet.SetUsername.ToString())
                                            {
                                                if (strings.Length > j)
                                                    P.Name = strings[j + 1];
                                            }
                                        }
                                        break;
                                    case CommandSet.Disconnect:
                                        this.Invoke((MethodInvoker)delegate () { Log($"{P.ToString()} disconnected"); });
                                        S.Disconnect(false);
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }

                        if (!command)
                        {
                            this.Invoke((MethodInvoker)delegate () { RecieveListBox.Items.Add($"{P.ToString()}: {message}"); });
                        }
                    }
                }
                catch (SocketException se)
                {
                    this.Invoke((MethodInvoker)delegate () { Log("Socket from " + P.ToString() + " was forceabely closed: " + se.Message); });
                    S.Disconnect(false);
                    break;
                }
                if(!IsConnected(S))
                {
                    this.Invoke((MethodInvoker)delegate () { Log(P.ToString() + " disconnected"); });
                    break;
                }
            }
            S.Close();
            this.Invoke((MethodInvoker)delegate () { SocketCountLabel.Text = (int.Parse(SocketCountLabel.Text) - 1).ToString(); });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            hosting = false;
            if(T != null)
                T.Join();
        }
        private bool IsConnected(Socket socket)
        {
            try
            {
                return !(socket.Poll(1, SelectMode.SelectRead) && socket.Available == 0);
            }
            catch (SocketException)
            {
                return false;
            }
        }
    }
}
