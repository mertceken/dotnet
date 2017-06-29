using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myGame
{
    public partial class Form1 : Form
    {
        bool right;
        bool left;
        bool jump;
        int G = 30;
        int force;


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.Right > block.Left && player.Left < block.Right - player.Width/ 2 && player.Bottom > block.Top)
            {
                right = false;
            }

            if(player.Left < block.Right && player.Right > block.Left + player.Width/ 2 && player.Bottom > block.Top)
                {
                left = false;
                }


            if (right == true) { player.Left += 5; }
            if (left == true) { player.Left -= 5; }

            if (jump != true)
            {
                player.Top -= force;
                force -= -1;
            }
            if ( player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;
                jump = false;
            }
            else
            {
                player.Top += 5;

            }

          if(player.Left + player.Width - 1 > block.Left && player.Left + player.Width + 5 < block.Left + block.Width + player.Width && player.Top + player.Height >= player.Top)
            {
                player.Top = screen.Height - block.Height - player.Height;
                force = 0;
                jump = false;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left)  { left = true; }
            if (e.KeyCode == Keys.Escape { this.Close(); }

            if (jump != true)
            {
                if(e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = 6;

                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
