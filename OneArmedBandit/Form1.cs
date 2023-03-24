using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random random = new Random();
        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            int reel1 = random.Next(0, 3);
            int reel2 = random.Next(0, 3);
            int reel3 = random.Next(0, 3);

            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch(reel1)
            {
                case 0:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel2)
            {
                case 0:
                    pictureBox2.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 1:
                    pictureBox2.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox2.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }
            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources
            switch (reel3)
            {
                case 0:
                    pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                    break;
                case 1:
                    pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                case 2:
                    pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            if (reel1 == reel2 && reel2 == reel3)
            {
                // If yes show "winner" statement and add 3 to score.
                outputLabel.Text = "Winner!";
                score += 3;
            }
            else
            {
                // If no show "play again" statement and subtract 1 from score.
                outputLabel.Text = "Try again.";
                score -= 1;
            }
            if (score == 0)
            {
                // if score has reached 0 display "lose" message and set button enabled property to false
                outputLabel.Text = "Come back later with more money, chump.";
                spinButton.Enabled = false;
            }

            // display updated score
            scoreDisplay.Text = Convert.ToString(score);
        }
    }
}
