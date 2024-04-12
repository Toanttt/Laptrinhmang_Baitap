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

namespace Server
{
    public partial class Client : Form
    {

        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        bool isConnected = false;
        IPEndPoint IP;
        Socket client;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Vui lòng kết nối đến server!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rtbMessage.Text == "") { return; }
            Send();
            string full = txtName.Text + ": " + rtbMessage.Text.Trim();
            AddMessage(full);
        }

        void AddMessage(string s)
        {
            rtbMain.Text += s + Environment.NewLine;
            rtbMessage.Clear();
        }

        void receiveMessage(string s)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(receiveMessage), new object[] { s });
                return;
            }
            rtbMain.Text += s + Environment.NewLine;
         }

        void Ketnoi(int portNumber)
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), portNumber);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
                isConnected = true;
                MessageBox.Show("Đã kết nối thành công với server port: " + portNumber, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Send()
        {
            if (rtbMessage.Text != string.Empty && txtName.Text != string.Empty)
            {
                string full = txtName.Text + ": " + rtbMessage.Text.Trim();
                client.Send(Serialize(full));
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    receiveMessage(message);
                }
            }
            catch
            {
                Close();
            }
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }


        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isConnected)
            {
                client.Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            bool isPortValid = int.TryParse(txtPort.Text.Trim(), out int portNumber);
            if (!isPortValid)
            {
                MessageBox.Show("Lỗi Port");
                txtPort.Focus();
                return;
            }
            if (txtName.Text != "")
            {
                Ketnoi(portNumber);
            } else
            {
                MessageBox.Show("Vui lòng nhập tên!");
                txtName.Focus();
                return;
            }
            txtName.ReadOnly = true;
        }

        private void btnShutServer_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                client.Close();
            }
        }
    }
}
