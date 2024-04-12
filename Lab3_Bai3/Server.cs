using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TCP_server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        TcpListener server;
        IPEndPoint ipEP;

        private void btnListen_Click(object sender, EventArgs e)
        {
            int port = 8888;
            ipEP = new IPEndPoint(IPAddress.Any, port);
            server = new TcpListener(ipEP);
            server.Start();

            Thread listenThread = new Thread(Listen);
            listenThread.Start();

            txtChat.Text += "Server started!\r\n";
            btnListen.Enabled = false;
        }

        private void Listen()
        {
            while (true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();
                    txtChat.BeginInvoke((Action)(() => txtChat.Text += "Connected from " + client.Client.RemoteEndPoint + "\r\n"));
                    Thread receiveThread = new Thread(() => Receive(client));
                    receiveThread.Start();
                }
                catch (SocketException ex)
                {
                    Console.WriteLine("Socket exception: " + ex.Message);
                }
            }
        }

        void Receive(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (true)
            {
                try
                {
                    bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    txtChat.BeginInvoke((Action)(() => txtChat.Text += "From client: " + message + "\r\n"));
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error receiving data: " + ex.Message);
                    break;
                }
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                server.Stop();
            } catch
            {
                return;
            }
        }

        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
