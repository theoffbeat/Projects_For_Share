using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        //This will add sound when the player hits a wall
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        //This will add sound when the player finishes/wins the game
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            if (MessageBox.Show("You won! Play Again?", "Congratulations!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Starting Over!");
                MoveToStart();
            }
            else
            {
                MessageBox.Show("Goodbye and Thanks for Playing!");
                Close();
            }
            //MessageBox.Show("Congratulations!");
            //Close();
        }

        /// <summary>
        /// Move the pointer to a point 10 pixels down and to the right
        /// of the starting point in the upper-left corner of the maze.
        /// </summary>


        private void MoveToStart()
        {
            //startSoundPlayer.Play();
            Point startingPoint = startLabel.Location;
            startingPoint.Offset(30, 30);
            Cursor.Position = PointToScreen(startingPoint);
            //MessageBox.Show("You hit a wall!  Start Over!");
        }

        private void HitWall()
        {
            startSoundPlayer.Play();
            ExitMenu();
            Point startingPoint = startLabel.Location;
            startingPoint.Offset(30, 30);
            Cursor.Position = PointToScreen(startingPoint);
            
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            HitWall();
        }

        private void ExitMenu()
        {
            if (MessageBox.Show("Retry or Quit?", "You Hit a Wall!", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
            {
                MessageBox.Show("Starting Over!");
            }
            else
            {
                MessageBox.Show("Goodbye and Thanks for Playing!");
                Application.Exit();
            }
        }
#region


        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void finishLabel_Click(object sender, EventArgs e)
        {

        }
#endregion
    }
}
