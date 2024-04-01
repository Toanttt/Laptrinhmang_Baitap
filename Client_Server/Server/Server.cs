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

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        bool isConnected = false;

        void Connect(int portNumber)
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, portNumber);
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
                        clientList.Add(client);

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
                foreach (Socket item in clientList)
                {
                    Send(item);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
            string full = "Server: " + rtbMessage.Text;
            AddMessage(full);
            rtbMessage.Clear();
        }

        void AddMessage(string s)
        {
            rtbMain.Text += s + Environment.NewLine;
        }

        void Send(Socket client)
        {
            if (client != null && rtbMessage.Text != string.Empty)
                client.Send(Serialize("Server: " + rtbMessage.Text.Trim()));
        }

        private void Receive(object obj)
        {
            Socket client = obj as Socket;

            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    int bytesReceived = client.Receive(data);

                    if (bytesReceived == 0)
                    {
                        clientList.Remove(client);
                        client.Close();
                        return;
                    }

                    string message = (string)Deserialize(data);

                    foreach (Socket item in clientList)
                    {
                        if (item != null && item != client)
                        {
                            item.Send(Serialize(message));
                        }
                    }

                    AddMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
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

        private void StopServer()
        {
            try
            {
                foreach (Socket client in clientList)
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
            MessageBox.Show("Mở port thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
