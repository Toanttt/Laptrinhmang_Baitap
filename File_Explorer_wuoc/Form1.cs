using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace File_Explorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wBrs.DocumentCompleted += wBrs_DocumentCompleted;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    wBrs.Url = new Uri(fdb.SelectedPath);
                    txtPath.Text = fdb.SelectedPath;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wBrs.CanGoBack)
            {
                wBrs.GoBack();
            }
        }

        private void btnFore_Click(object sender, EventArgs e)
        {
            if (wBrs.CanGoForward)
            {
                wBrs.GoForward();
            }
        }

        private void wBrs_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (wBrs.Url != null)
            {
                txtPath.Text = wBrs.Url.ToString();
            }
        }
    }
}
