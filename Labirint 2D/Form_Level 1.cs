﻿using System;
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
    public partial class Form_Level1 : Form
    {
        public Form_Level1()
        {
            InitializeComponent();
            Start_Game();
        }
        public  void Start_Game()
        {
            Point  point;
            point = label_start.Location;
            point.Offset(label_start.Width / 2, label_start.Height / 2);
            Cursor.Position =PointToScreen( point);
            Sound.play_start();
        }

        private void Form_Level1_Shown(object sender, EventArgs e)
        {
            Start_Game();
        }
        private void finish_game()
        {
            Sound.Play_Else();
          DialogResult Dr= MessageBox.Show("Game over! \n Once more?","",
            MessageBoxButtons.YesNo);
            if (Dr == DialogResult.Yes)
                Start_Game();
            else
                DialogResult = DialogResult.Abort;
        }

        private void label_Finish_MouseEnter(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Sound.play_Whine();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }
    }
}
