using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_2D
{
    public partial class Form_Level2 : Form
    {
        public Form_Level2()
        {
            InitializeComponent();
        }
        public void Start_Game()
        {
            Point point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position = PointToScreen(point);
            Sound.play_start();
        }
        private void finish_game()
        {
            Sound.Play_Else();
            DialogResult Dr = MessageBox.Show("Game over! \n Once more?", "",
              MessageBoxButtons.YesNo);
            if (Dr == DialogResult.Yes)
                Start_Game();
            else
                DialogResult = DialogResult.Abort;
        }
        public void You_Wine()
        {
            MessageBox.Show("You Wine the GAME!");
            Close();
        }
        private void Form_Level2_Shown(object sender, EventArgs e)
        {
            Start_Game();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label_Key_MouseEnter(object sender, EventArgs e)
        {
            Sound.play_Whine();
            label_Key.Visible = false;
        }

        private void label_Home_MouseEnter(object sender, EventArgs e)
        {
            if (label_Key.Visible)
            {
                MessageBox.Show("You Must take a Key!");
                finish_game();
            }
            else
                Sound.play_Whine();
                label_Key.Visible = false;
        }

        private void label_Finish_MouseEnter(object sender, EventArgs e)
        {
            You_Wine();
            Sound.play_Whine();
            
        }
    }
}
