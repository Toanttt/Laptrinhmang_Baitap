using System;
using System.Windows.Forms;

namespace TCP_server
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        
        private void btnServer_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();
            btnClient.Enabled = true;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            test_client client = new test_client();
            client.Show();
        }
    }
}
