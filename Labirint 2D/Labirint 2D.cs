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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Sound.play_start();
            start_level1();
        }

        private void butten_exit_Click(object sender, EventArgs e)
        {
            Sound.play_exit();
            Close();
        }
        public void You_Wine()
        {
            MessageBox.Show("You Wine the GAME!");
        }

        private void box_sound_CheckedChanged(object sender, EventArgs e)
        {
            if (box_sound.Checked)
            {
                Sound.Sound_on();
                box_sound.Text = "Sound on";
                Sound.Play_Else();
            }
            else
            {
                Sound.sound_off();
                box_sound.Text = "Sound off";
            }
        }
        public void start_level1()
        {
            Form_Level1 Level1 = new Form_Level1();
            Level1.ShowDialog();
            DialogResult Dr = Level1.ShowDialog();
            if (Dr == DialogResult.OK)
                start_level2();
        }
        public void start_level2()
        {
            
           Form_Level2 Level2 = new Form_Level2();
           Level2.ShowDialog();
           DialogResult Dr = Level2.ShowDialog();
           if (Dr == DialogResult.OK)
           {
                You_Wine();
                Sound.play_Whine();
                Close();
            }
        }
    }
}
