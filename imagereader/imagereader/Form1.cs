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

namespace imagereader
{
    public partial class Form1 : Form
    {
        private List<string> imageFiles;
        private int currentImageIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);

                string directory = Path.GetDirectoryName(openFileDialog1.FileName);
                imageFiles = Directory.GetFiles(directory, "*.*", SearchOption.TopDirectoryOnly)
                    .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp")).ToList();
                currentImageIndex = imageFiles.IndexOf(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && currentImageIndex > 0)
            {
                currentImageIndex--;
                pictureBox1.Load(imageFiles[currentImageIndex]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && currentImageIndex < imageFiles.Count - 1)
            {
                currentImageIndex++;
                pictureBox1.Load(imageFiles[currentImageIndex]);
            }
        }
    }
}
