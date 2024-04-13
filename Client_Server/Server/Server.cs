using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Security;
using System.Xml.Linq;
using System.Collections;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            tableLayoutPanel.Visible = false;
            // Tạo một đối tượng của lớp emojiUtility
            emojiUtility emojiUtility = new emojiUtility();
            foreach (var emoji in emojiUtility.GetEmojis().Keys)
            {
                // Tạo một Button cho mỗi emoji
                Button button = new Button();
                button.Dock = DockStyle.Fill;
                button.Text = emoji;
                button.Click += (sender, e) =>
                {
                    // Khi một emoji được chọn, thêm emoji vào rtbMessage
                    rtbMessage.AppendText(button.Text);
                };

                // Thêm Button vào TableLayoutPanel
                tableLayoutPanel.Controls.Add(button);
            }

            showTableLayoutPanelButton.Click += (sender, e) =>
            {
                tableLayoutPanel.Visible = !tableLayoutPanel.Visible;
                if (tableLayoutPanel.Visible)
                {
                    tableLayoutPanel.BringToFront(); // Đặt TableLayoutPanel lên trên rtbMain
                }
                tableLayoutPanel.BringToFront(); // Đặt TableLayoutPanel lên trên rtbMain
            };
        }

        bool isConnected = false;
        IPEndPoint IP;
        Socket server;
        private IPAddress ipServer = IPAddress.Any;
        private Dictionary<string, Socket> clientList = new Dictionary<string, Socket>();

        void Connect(int portNumber)
        {
            clientList = new Dictionary<string, Socket>();
            IP = new IPEndPoint(ipServer, portNumber);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);
            isConnected = true;
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();

                        byte[] data = new byte[1024 * 5000];
                        int bytesReceived = client.Receive(data);
                        string username = Encoding.Unicode.GetString(data, 0, bytesReceived);

                        if (clientList.ContainsKey(username))
                        {
                            client.Close();
                        }
                        else
                        {
                            AddMessage($"{username} đã kết nối thành công đến server!");
                            clientList.Add(username, client);
                        }
                        
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                } catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8888);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Socket item in clientList.Values)
                {
                    Send(item);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
            string full = "Server: " + rtbMessage.Text.Trim();
            AddMessage(full);
            rtbMessage.Clear();
        }

        void AddMessage(string s)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(AddMessage), new object[] { s });
                return;
            }
            rtbMain.Text += s.Trim() + Environment.NewLine;
            rtbMessage.Clear();
            ScrollToBottom();
        }

        void Send(Socket client)
        {
            string text = rtbMessage.Text.Trim();
            //nếu text bắt đầu bằng "\U" thì chuyển đổi unicode sang emoji
            text = emojiUtility.ConvertUnicodeToEmoji(text);
            if (client != null && text != string.Empty)
            {
                byte[] message = Encoding.Unicode.GetBytes("Server: " + text);
                client.Send(message);
            }
        }

        string FindUsername(Dictionary<string, Socket> dictionary, Socket value)
        {
            foreach (var pair in dictionary)
            {
                if (pair.Value == value)
                {
                    return pair.Key;
                }
            }

            return null;
        }

        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            string username = FindUsername(clientList, client);

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesReceived = client.Receive(data);

                    if (bytesReceived == 0)
                    {
                        clientList.Remove(username);
                        client.Close();
                        return;
                    }

                    string message = Encoding.Unicode.GetString(data, 0, bytesReceived);
                    string send_message = $"{username}: {message}";
                    byte[] send_message__bytes = Encoding.Unicode.GetBytes(send_message);

                    foreach (Socket item in clientList.Values)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(send_message__bytes);
                        }
                    }
                    AddMessage(send_message);
                }
            }
            catch
            {
                clientList.Remove(username);
                client.Close();
            }
        }

        private void StopServer()
        {
            try
            {
                foreach (Socket client in clientList.Values)
                {
                    client.Close();
                }
                server.Close();

                AddMessage("Tắt server port thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tắt server: " + ex.Message);
            }
        }

        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isConnected)
            {
                server.Close();
            }
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            bool isPortValid = int.TryParse(txtPort.Text.Trim(), out int portNumber);
            if (!isPortValid)
            {
                MessageBox.Show("Lỗi Port");
                txtPort.Focus();
                return;
            }
            string s = btnOpenPort.Text;
            if (s == "Open")
            {
                Connect(portNumber);
                AddMessage($"Đã mở server port {portNumber} thành công!");
                txtPort.Enabled = false;
                btnOpenPort.Text = "Shut";
            } else if (s == "Shut")
            {
                StopServer();
                txtPort.Enabled = true;
                btnOpenPort.Text = "Open";
            }
        }

        private void rtbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }

        private void ScrollToBottom()
        {
            rtbMain.SelectionStart = rtbMain.Text.Length;
            rtbMain.ScrollToCaret();
        }

        private void btnSendImage_Click(object sender, EventArgs e)
        {

        }
    }
}
