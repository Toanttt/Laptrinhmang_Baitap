using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class MultiPlayer : Form
    {
        MainWindow p1Game;
        MainWindow p2Game;

        public MultiPlayer()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Normal;

            p1Game = new MainWindow();
            p2Game = new MainWindow();

            p1Game.TopLevel = false;
            p2Game.TopLevel = false;

            p1Game.FormBorderStyle = FormBorderStyle.None;
            p2Game.FormBorderStyle = FormBorderStyle.None;
            
            pn_p1.Size = new Size(p1Game.Width, p1Game.Height);
            pn_p2.Size = new Size(p2Game.Width, p2Game.Height);

            pn_p1.Controls.Add(p1Game);
            pn_p2.Controls.Add(p2Game);

            gb_p1.Size = new Size(pn_p1.Width, pn_p2.Height);
            gb_p2.Size = new Size(pn_p2.Width, pn_p2.Height);

            pn_p1.Dock = DockStyle.Fill;
            pn_p2.Dock = DockStyle.Fill;

            gb_p1.Dock = DockStyle.Left;
            gb_p2.Dock = DockStyle.Right;

            p1Game.Show();
            p2Game.Show();

            pn_p2.Enabled = false;
            gb_p2.Enabled = false;

            this.Size = new Size(gb_p1.Width * 2 + 10, 760);
        }

        // Chỉ cho panel 1 có thể nhấn phím
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.Up || keyData == Keys.Down || keyData == Keys.Space)
            {
                KeyEventArgs e = new KeyEventArgs(keyData);
                p1Game.MainWindow_KeyDown(this, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
