using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_explorer_window_form_app_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if(fdb.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fdb.SelectedPath);
                    txtPath.Text = fdb.SelectedPath;
                }
            }
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            if(webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
       
            }       
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   
           if(webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }
       
        
    }
}
