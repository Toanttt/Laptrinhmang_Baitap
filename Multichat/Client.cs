using System;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Lab3_Bai6
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        const int maxWidth = 200;
        const int maxHeight = 150;

        private bool isConnected = false;
        private TcpClient tcpClient;
        private Thread clientThread;
        private bool connecting = true;
        private delegate void SafeCallDelegate(string username, string data);

        // Hàm thêm tin nhắn vào chatBox
        private void AddMessage(string username, string data)
        {
            if (rtbChatBox.InvokeRequired)
            {
                var method = new SafeCallDelegate(AddMessage);
                rtbChatBox.Invoke(method, new object[] { username, data });
            }
            else
            {
                if (username == null)
                {
                    rtbChatBox.AppendText(data + Environment.NewLine);
                }
                else
                {
                    rtbChatBox.AppendText($"{username}: {data}" + Environment.NewLine);
                }   
                ScrollToBottom();
            }
        }
        // Kiểm tra xem dữ liệu nhận có phải là ảnh không
        private bool IsImageData(byte[] data)
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
        // Kiểm tra có phải file text không
        private bool IsTextData(byte[] data)
        {
            // Kiểm tra xem dữ liệu có chứa ký tự không in được (non-printable characters) hay không
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 32 || data[i] > 126)
                {
                    return false; // Dữ liệu không phải là text
                }
            }

            return true; // Dữ liệu là text
        }

        // Hàm nhận dữ liệu từ luồng 
        private void Receive()
        {
            NetworkStream net_stream = tcpClient.GetStream();
            byte[] data = new byte[1024*10000];
            try
            {
                while (connecting && tcpClient.Connected)
                {
                    int byte_count = net_stream.Read(data, 0, data.Length);


                    if (byte_count == 0)
                    {
                        connecting = false;
                        tcpClient.Close();
                        AddMessage(null, "Server disconnected.");
                        break;
                    }

                    if (byte_count > 0)
                    {
                        if (IsImageData(data))
                        {
                            byte[] imageData = new byte[byte_count];
                            Array.Copy(data, 0, imageData, 0, byte_count);

                            using (var ms = new MemoryStream(data, 0, byte_count))
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    Image image = Image.FromStream(ms);
                                    AddImageToChat("Admin", image);
                                });
                            }
                        }
                        else if (IsTextData(data))
                        {
                            ReceiveFile(net_stream);
                        }
                        else
                        {
                            string message = Encoding.UTF8.GetString(data, 0, byte_count);

                            if (message == "This username is reserved!" || message == "This username has already existed!")
                            {
                                AddMessage(null, message);
                                tcpClient.Close();
                                this.Invoke((MethodInvoker)delegate
                                {
                                    txtServerIP.ReadOnly = txtServerPort.ReadOnly = txtUsername.ReadOnly = !txtServerIP.Enabled;
                                    btnConnect.Enabled = true;
                                    txtUsername.Focus();
                                });
                                isConnected = false;
                            }
                            else
                            {
                                AddMessage(null, message);
                            }
                        }
                    }
                    Array.Clear(data, 0, 1024*10000);
                }
            }
            catch (Exception ex)
            {
                isConnected = false;
                //MessageBox.Show(ex.Message);
                //AddMessage(null, $"Connection error: {ex.Message}");
            }
        }
        // button kết nối client và server
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Tiến hành kết nối đến server
                IPEndPoint tcpServer = new IPEndPoint(IPAddress.Parse(txtServerIP.Text), int.Parse(txtServerPort.Text));
                tcpClient = new TcpClient();
                tcpClient.Connect(tcpServer);

                // Gửi username đến server 
                NetworkStream net_stream = tcpClient.GetStream();
                byte[] message = Encoding.UTF8.GetBytes(txtUsername.Text);
                net_stream.Write(message, 0, message.Length);
                net_stream.Flush();

                // Khởi động tiến trình client
                clientThread = new Thread(Receive);
                clientThread.IsBackground = true;
                clientThread.Start();

                txtServerIP.ReadOnly = txtServerPort.ReadOnly = txtUsername.ReadOnly = true;
                btnConnect.Enabled = false;
                btnExit.Enabled = true;
                isConnected = true;
                this.Text += ": " + txtUsername.Text;
                rtbChatBox.Clear();
            }
            catch
            {
                MessageBox.Show("Connetion failed!");
            }
        }
        // Button gửi tin nhắn
        private void btnSend_Click(object sender, EventArgs e)
        {
            if ( isConnected == false)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtMessage.Text.Trim()))
            {
                txtMessage.Clear();
                return;
            }
            NetworkStream net_stream = tcpClient.GetStream();
            byte[] message = Encoding.UTF8.GetBytes(txtMessage.Text.Trim());
            net_stream.Write(message, 0, message.Length);
            AddMessage("Me", txtMessage.Text);
            net_stream.Flush();
            txtMessage.Clear();
        }
        // Button thoát khỏi luồng
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isConnected == false)
            {
                return;
            }
            if (isConnected)
            {
                try
                {
                    NetworkStream net_stream = tcpClient.GetStream();
                    byte[] message = Encoding.UTF8.GetBytes("//disconnect");
                    net_stream.Write(message, 0, message.Length);
                    net_stream.Flush();
                }
                catch (Exception)
                {
                    // Ignore
                }
                finally
                {
                    tcpClient.Client.Shutdown(SocketShutdown.Both);
                    connecting = false;

                    if (tcpClient != null)
                    {
                        //tcpClient.GetStream().Close();
                        tcpClient.Close();
                        tcpClient = null;
                    }

                    isConnected = false;
                    clientThread = null;

                    btnConnect.Enabled = true;
                    btnExit.Enabled = false;
                    txtServerIP.ReadOnly = txtServerPort.ReadOnly = txtUsername.ReadOnly = !txtServerIP.Enabled;
                    AddMessage(null, "Disconnected...");
                    this.Text = "TCP Client";
                }
            }
        }
        // Cơ bản cho enter chatBox
        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
        // button gửi file và ảnh
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                Image image = Image.FromFile(imagePath);
                AddImageToChat("Me", image);
                SendImageToServer(image);
            }
        }

        // Resize lại ảnh theo kích thước của chatBox
        private Image ResizeImage(System.Drawing.Image image, int maxWidth, int maxHeight)
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
        // Thêm ảnh vào chatbox
        private void AddImageToChat(string username, Image image)
        {
            rtbChatBox.AppendText(Environment.NewLine);
            rtbChatBox.Select(rtbChatBox.Text.Length, 0);
            rtbChatBox.SelectionColor = rtbChatBox.ForeColor;
            rtbChatBox.AppendText($"{username}: ");
            rtbChatBox.Select(rtbChatBox.Text.Length, 0);

            rtbChatBox.ReadOnly = false;
            image = ResizeImage(image, maxWidth, maxHeight);

            if (rtbChatBox.InvokeRequired)
            {
                rtbChatBox.BeginInvoke((MethodInvoker)delegate {
                    Clipboard.SetImage(image);
                    rtbChatBox.Paste();
                });
            }
            else
            {
                Clipboard.SetImage(image);
                rtbChatBox.Paste();
            }
            rtbChatBox.ScrollToCaret();
            rtbChatBox.ReadOnly = true;
            rtbChatBox.AppendText(Environment.NewLine);
        }
        // Hàm tự động kéo xuống cùng
        private void ScrollToBottom()
        {
            rtbChatBox.SelectionStart = rtbChatBox.Text.Length;
            rtbChatBox.ScrollToCaret();
        }
        // Gửi ảnh cho server
        private void SendImageToServer(Image image)
        {
            Image resizedImage = ResizeImage(image, maxWidth, maxHeight);

            using (MemoryStream ms = new MemoryStream())
            {
                resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageData = ms.ToArray();

                NetworkStream net_stream = tcpClient.GetStream();
                net_stream.Write(imageData, 0, imageData.Length);
                net_stream.Flush();
            }
        }

        // Trong phần xử lý nhận file ở bên client
        private void ReceiveFile(NetworkStream netStream)
        {
            byte[] fileNameLengthBytes = new byte[4]; // Đọc độ dài tên file
            netStream.Read(fileNameLengthBytes, 0, 4);
            int fileNameLength = BitConverter.ToInt32(fileNameLengthBytes, 0);

            byte[] fileNameBytes = new byte[fileNameLength]; // Đọc tên file
            netStream.Read(fileNameBytes, 0, fileNameLength);
            string fileName = Encoding.UTF8.GetString(fileNameBytes);



            // Tạo button trong FlowLayoutPanel
            Button fileButton = new Button();
            fileButton.Text = fileName;
            fileButton.Click += (sender, e) =>
            {
                byte[] fileBytes = File.ReadAllBytes(savePath);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = fileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;

                    using (FileStream fileStream = new FileStream(savePath, FileMode.Create))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;

                        while ((bytesRead = netStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            };

            flowLayoutPanel1.Controls.Add(fileButton);
        }
    }
}