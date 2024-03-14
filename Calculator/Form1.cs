using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "";
            txtScreen.Focus();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtScreen.AppendText(button.Text);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Length > 0)
            {
                txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string input = txtScreen.Text.Trim();
            if (input.Length == 0)
            {
                return;
            }
            var dataTable = new DataTable();
            var result = dataTable.Compute(input, "");
            double ketqua = Convert.ToDouble(result);
            txtScreen.Clear();
            txtScreen.Text = ketqua.ToString();
        }

        private void btnNgoacTrai_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }
        private void btnNgoacPhai_Click(object sender, EventArgs e)
        {
            btnNumber_Click(sender, e);
        }
    }
}
