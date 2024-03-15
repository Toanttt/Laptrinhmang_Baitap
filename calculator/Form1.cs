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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Button = System.Windows.Forms.Button;

namespace calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void btn(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Clear();
            Button btn = (Button)sender;
            textBox.Text += btn.Text;
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            string equation = textBox.Text;
            if (IsValidExpression(equation))
            {
                try
                {
                    var result = new DataTable().Compute(equation, null);
                    textBox.Text = result.ToString();
                }
                catch (SyntaxErrorException)
                {
                    textBox.Text = ("Invalid expression!");
                }
            }
            else
            {
                textBox.Text = ("Invalid expression!");
            }
        }
        // function check if the input expression is valid
        private bool IsValidExpression(string expression) 
        {
            string pattern = @"[+\-*/%]{3,}";
            if (System.Text.RegularExpressions.Regex.IsMatch(expression, pattern))
            {
                return false;
            }

            return true;
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void dot_btn_Click(object sender, EventArgs e)
        {
            if (!textBox.Text.Contains("."))
            {
                textBox.Text += ".";
            }
        }
    }
}
