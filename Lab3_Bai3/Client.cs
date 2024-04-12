using System;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Text;

namespace TCP_server
{
    public partial class test_client : Form
    {

        public test_client()
        {
            InitializeComponent();
        }

        private ClientConnection client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    client  = new ClientConnection();
                    client.Connect();
                    MessageBox.Show("Kết nối đến server thành công");
                } catch
                {
                    MessageBox.Show("Không thành công");
                    return;
                }

                BeginInvoke((Action)(() =>
                {
                    btnSend.Enabled = true;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                }));
            }
            catch (SocketException ex)
            {
                HandleSocketException(ex);
            }
        }

        private void HandleSocketException(SocketException ex)
        {
            MessageBox.Show($"Không thể kết nối server: {ex.Message}", "Notice");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSend.Text == "")
            {
                return;
            }
            string message = txtSend.Text.Trim();
            client.Send(message);
            txtSend.Clear();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                client.Disconnect();
                btnSend.Enabled = false;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }));
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
                txtSend.Focus();
            }
        }
    }

    class ClientConnection
    {
        IPAddress ipAdd= IPAddress.Parse("127.0.0.1");
        IPEndPoint ipEP;
        TcpClient client;
        NetworkStream stream;

        public void Connect()
        {
            try
            {
                client = new TcpClient();
                ipEP = new IPEndPoint(ipAdd, 8888);
                client.Connect(ipEP);
                stream = client.GetStream();
            } catch
            {
                MessageBox.Show("Error connecting to server");
            }
        }

        public void Send(string message)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (client != null)
                {
                    client.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error closing client socket: " + ex.Message);
            }
        }
    }
}
