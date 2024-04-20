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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnSolo_Click(object sender, EventArgs e)
        {
            GameTetris game = new GameTetris();
            game.Show();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            MultiPlayer multiPlayer = new MultiPlayer();
            multiPlayer.Show();

            try
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên", "Thông báo");
                    return;
                }
                if (txtRoom.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập số phòng", "Thông báo");
                    return;
                }
                GameTetris gameCaro = new GameTetris();
                gameCaro.GameMode = 1;
                gameCaro.Room = int.Parse(txtRoom.Text);
                gameCaro.GetName = txtName.Text;
                gameCaro.Show();
            }
            catch
            {
                MessageBox.Show("Bạn nhập sai số phòng", "Thông báo");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
