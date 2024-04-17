using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class MultiPlayer : Form
    {
        MainWindow p1Game;
        MainWindow p2Game;
        Panel panel_p1;
        Panel panel_p2;

        public MultiPlayer()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1100, 700); // Adjust for window borders and title bar

            p1Game = new MainWindow();
            p2Game = new MainWindow();

            // Set TopLevel to false to allow adding to a Panel
            player1Window.TopLevel = false;
            player2Window.TopLevel = false;

            // Remove the title bar
            player1Window.FormBorderStyle = FormBorderStyle.None;
            player2Window.FormBorderStyle = FormBorderStyle.None;

            // Add the windows to the panels
            panel1.Controls.Add(player1Window);
            panel2.Controls.Add(player2Window);

            // Show the MainWindow
            player1Window.Show();
            player2Window.Show();
        }
    }
}
