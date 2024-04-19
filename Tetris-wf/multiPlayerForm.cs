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
    public partial class multiPlayerForm : Form
    {
        // Declare the MainWindow variables
        private MainWindow player1Window;
        private MainWindow player2Window;

        public multiPlayerForm()
        { 

        InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1100, 700); // Adjust for window borders and title bar

            player1Window = new MainWindow(1);
            player2Window = new MainWindow(2);

            player1Window.GameOver += PlayerWindow_GameOver;
            player2Window.GameOver += PlayerWindow_GameOver;
            // Set TopLevel to false to allow adding to a Panel
            player1Window.TopLevel = false;
            player2Window.TopLevel = false;

            // Remove the title bar
            player1Window.FormBorderStyle = FormBorderStyle.None;
            player2Window.FormBorderStyle = FormBorderStyle.None;

            // Set the location of player2Window
            player2Window.Location = new Point(560, 0);

            // Add the windows to the panels
            this.Controls.Add(player1Window);
            this.Controls.Add(player2Window);

            // Show the MainWindow
            player1Window.Show();
            player2Window.Show();

            player2Window.Focus();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Nếu phím mũi tên nào đó được nhấn, chuyển sự kiện đến player1Window
            if (keyData == Keys.Left || keyData == Keys.Right || keyData == Keys.Up || keyData == Keys.Down)
            {
                // Tạo một sự kiện KeyEventArgs mới với phím đã được nhấn
                KeyEventArgs e = new KeyEventArgs(keyData);

                // Gọi phương thức MainWindow_KeyDown của player1Window với sự kiện mới
                player2Window.MainWindow_KeyDown(this, e);

                // Trả về true để ngăn chặn việc xử lý mặc định
                return true;
            }

            // Cho phép xử lý mặc định cho tất cả các phím khác
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PlayerWindow_GameOver(object sender, EventArgs e)
        {
            // Kiểm tra xem cửa sổ nào đã kích hoạt sự kiện
            MainWindow senderWindow = sender as MainWindow;

            if (senderWindow == player1Window)
            {
                // Nếu player1Window đã kích hoạt sự kiện, thông báo rằng Player 2 thắng
                MessageBox.Show("Player 2 wins!");
                player2Window.StopGame();
            }
            else 
            {
                // Nếu player2Window đã kích hoạt sự kiện, thông báo rằng Player 1 thắng
                MessageBox.Show("Player 1 wins!");
                player1Window.StopGame(); 

            }
        }


    }
}
