using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using J3QQ4;
using System.Reflection;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            LoadEmojiButtons();
            CheckForIllegalCrossThreadCalls = false;
        }

        bool isConnected = false;
        IPEndPoint IP;
        Socket server;
        //List<Socket> clientList;
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
                        string username = Encoding.UTF8.GetString(data, 0, bytesReceived);

                        if (clientList.ContainsKey(username))
                        {
                            client.Close();
                        }
                        else
                        {
                            AddMessage($"{username} đã kết nối thành công đến server!" + Emoji.Apple);
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
            isConnected = true;
            Listen.IsBackground = true;
            Listen.Start();
        }

        void Send(Socket client)
        {
            string text = rtbMessage.Text.Trim();
            if (client != null && text != string.Empty)
            {
                byte[] message = Encoding.UTF8.GetBytes("Server: " + Emoji.Book +text);
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

        bool IsImageData(byte[] data)
        {
            try
            {
                using (var ms = new MemoryStream(data))
                {
                    Image.FromStream(ms);
                    return true;
                }
            }
            catch
            {
                return false;
            }
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

                    if (IsImageData(data))
                    {
                        using (MemoryStream ms = new MemoryStream(data, 0, bytesReceived))
                        {
                            Image image = Image.FromStream(ms);
                            Invoke((MethodInvoker)delegate
                            {
                                AddImageToChatBox(username, image);
                            });
                            SendImageBroadCast(image, client);
                        }
                    }
                    else
                    {
                        string message = Encoding.UTF8.GetString(data, 0, bytesReceived);
                        string send_message = $"{username}: {message}";
                        byte[] send_message__bytes = Encoding.UTF8.GetBytes(send_message);

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

                MessageBox.Show("Tắt server port thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Connect(portNumber);
            AddMessage($"Đã mở server port {portNumber} thành công!");
            btnOpenPort.Enabled = false;
            txtPort.Enabled = false;
        }

        private void btnShutPort_Click(object sender, EventArgs e)
        {
            StopServer();
            btnOpenPort.Enabled = true;
            txtPort.Enabled = true;
            btnShut.Enabled = false;
        }

        private void sendFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (IsImageFile(filePath))
                {
                    Image image = Image.FromFile(filePath);
                    AddImageToChatBox("Server", image);
                    SendImageBroadCast(image);
                }
            }
        }

        private Image ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int newWidth, newHeight;
            double aspectRatio = (double)image.Width / image.Height;

            if (image.Width > maxWidth)
            {
                newWidth = maxWidth;
                newHeight = (int)(newWidth / aspectRatio);
            }
            else if (image.Height > maxHeight)
            {
                newHeight = maxHeight;
                newWidth = (int)(newHeight * aspectRatio);
            }
            else
            {
                newWidth = image.Width;
                newHeight = image.Height;
            }

            return new Bitmap(image, newWidth, newHeight);
        }

        private void AddImageToChatBox(string username, Image image)
        {
            rtbMain.AppendText(Environment.NewLine);
            rtbMain.Select(rtbMain.Text.Length, 0);
            rtbMain.SelectionColor = rtbMain.ForeColor;
            rtbMain.AppendText($"{username}: ");
            rtbMain.Select(rtbMain.Text.Length, 0);

            rtbMain.ReadOnly = false;

            image = ResizeImage(image, 200, 200);
            Clipboard.SetImage(image);
            rtbMain.Paste();

            rtbMain.ReadOnly = true;
            rtbMain.AppendText(Environment.NewLine);
            ScrollToBottom();
        }

        private void SendImageBroadCast(Image image, Socket client = null)
        {
            if (!isConnected)
                return;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                byte[] image_data = ms.ToArray();

                if (clientList != null)
                {
                    foreach (Socket item in clientList.Values)
                    {
                        if(item != client)
                        {
                            item.Send(image_data);
                        }
                    }
                }
            }
        }

        private bool IsImageFile(string filePath)
        {
            try
            {
                using (var image = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void ScrollToBottom()
        {
            rtbMain.SelectionStart = rtbMain.Text.Length;
            rtbMain.ScrollToCaret();
        }

        // Chức năng Emoji
        #region Emoji

        private List<string> emojiList = new List<string>();

        private void LoadEmojiButtons()
        {
            Type emojiType = typeof(Emoji);
            FieldInfo[] emojiFields = emojiType.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (FieldInfo field in emojiFields)
            {
                string emoji = (string)field.GetValue(null);
                emojiList.Add(emoji);

                Button emojiButton = new Button();
                emojiButton.Text = emoji;
                emojiButton.Width = 60;
                emojiButton.Height = 60;
                emojiButton.Margin = new Padding(5);
                emojiButton.Font = new Font("Segoe UI Emoji", 15);

                emojiButton.Click += (sender, e) =>
                {
                    rtbMessage.AppendText(emojiButton.Text);
                    flpEmoji.Visible = !flpEmoji.Visible;
                };

                flpEmoji.Controls.Add(emojiButton);
            }
        }

        private void btnFindEmoji_Click(object sender, EventArgs e)
        {
            string keyword = txtEmoji.Text.Trim().ToLower();

            List<string> searchResults = SearchEmoji(keyword);
            UpdateEmojiButtons(searchResults);
        }

        private void UpdateEmojiButtons(List<string> emojis)
        {
            for (int i = flpEmoji.Controls.Count - 1; i > 0; i--)
            {
                if (flpEmoji.Controls[i] is Button && flpEmoji.Controls[i] != btnFindEmoji)
                {
                    flpEmoji.Controls.RemoveAt(i);
                }
            }

            foreach (string emoji in emojis)
            {
                Button emojiButton = new Button();
                emojiButton.Text = emoji;
                emojiButton.Width = 60;
                emojiButton.Height = 60;
                emojiButton.Margin = new Padding(5);
                emojiButton.Font = new Font("Segoe UI Emoji", 15);

                emojiButton.Click += (sender, e) =>
                {
                    rtbMessage.AppendText(emojiButton.Text);
                    flpEmoji.Visible = !flpEmoji.Visible;
                };

                flpEmoji.Controls.Add(emojiButton);
            }
        }

        private List<string> SearchEmoji(string keyword)
        {
            List<string> results = new List<string>();

            Type emojiType = typeof(Emoji);
            FieldInfo[] emojiFields = emojiType.GetFields(BindingFlags.Public | BindingFlags.Static);

            foreach (FieldInfo field in emojiFields)
            {
                string emoji = (string)field.GetValue(null);
                if (field.Name.ToLower().Contains(keyword.ToLower()))
                {
                    results.Add(emoji);
                }
            }
            return results;
        }

        private void btnEmoji_Click(object sender, EventArgs e)
        {
            flpEmoji.Visible = !flpEmoji.Visible;
        }
        #endregion

        // Chức năng gửi tin nhắn
        #region Message
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Socket item in clientList.Values)
                {
                    Send(item);
                }
            }
            catch (Exception ex)
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
            rtbMain.AppendText(s.Trim() + Environment.NewLine);
            rtbMessage.Clear();
            ScrollToBottom();
        }
        private void rtbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
        #endregion

    }
}
