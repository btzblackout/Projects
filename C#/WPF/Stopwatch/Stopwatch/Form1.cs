using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        // Declare variables.
        int score = 0;
        int lives = 3;
        int highScore = 0;
        int level = 1;
        int tempScore = 0;
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        Image myImage;
        
        // Constructor for Form1.
        public Form1()
        {
            
            InitializeComponent();
            // Display the initial score and lives.
            label3.Text = score.ToString();
            label5.Text = lives.ToString();
            label10.Text = level.ToString();
            myImage = Properties.Resources.Nature;
            this.BackgroundImage = myImage;

        }
        //The Start button.
        private void startButton_Click(object sender, EventArgs e)
        {
            // Enable the timer control.
            timer1.Enabled = true;
            // Make the button dissapear.
            startButton.Visible = false;
            // Start the watch.
            watch.Start();
        }
        // The Stop button. I removed its availability as step 3 doesn't require it.
        private void button2_Click(object sender, EventArgs e)
        {
            // Disable the timer control.
            timer1.Enabled = false;
            // Make the mole picture dissapear.
            pictureBox1.Visible = false;
            // Stop the watch.
            watch.Stop();
        }
        // Play again button.
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            // Reset lives
            lives = 3;
            label5.Text = lives.ToString();
            // Reset high score
            highScore = 0;
            label8.Text = highScore.ToString();
            // Reset the level
            level = 1;
            label10.Text = level.ToString();
            // Reset the background to level 1.
            ChangeLevel(1);
            // Make the play again button dissapear.
            playAgainButton.Visible = false;
            // Enable the timer control
            timer1.Enabled = true;
            // Set the default speed of the timer.
            timer1.Interval = 1000;
            // Restart the watch.
            watch.Reset();
            // Start the watch.
            watch.Start();
            
        }
        // When the timer ticks.
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Set both pictures to invisible.
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            // Format the label that displays the watch.
            label1.Text = watch.Elapsed.ToString("mm\\:ss");
            // Check if the score is less than 5.
            // Chance for bombs is lowest, and slowest speed.
            if(score < 5)
            {
                // Store a random number between 0 and 10 in a variable.
                int chance = random.Next(0, 10);
                // Check if the number is less than or equal to 5
                if (chance <= 5)
                {
                    // Set the bomb picture box to a random location within the form.
                    pictureBox2.Left = random.Next(0, this.Width);
                    pictureBox2.Top = random.Next(0, this.Height);
                    // Make the bomb picture visible.
                    pictureBox2.Visible = true;
                }
                // Check if the number is greater than 5.
                else if (chance > 5)
                {
                    // Set the mole picture box to a random location within the form.
                    pictureBox1.Left = random.Next(0, this.Width);
                    pictureBox1.Top = random.Next(0, this.Height);
                    // Make the mole picture visible.
                    pictureBox1.Visible = true;
                }
            }
            // Check if the score is less than 10
            // Chance for bombs is increased, as well as speed.
            else if(score < 10)
            {
                // Increase the speed slightly
                timer1.Interval = 800;
                // Store a random number between 0 and 10 in a variable.
                int chance = random.Next(0, 10);
                // Check if the number is less than or equal to 6.
                if (chance <= 6)
                {
                    // Set the bomb picture box to a random location within the form.
                    pictureBox2.Left = random.Next(0, this.Width);
                    pictureBox2.Top = random.Next(0, this.Height);
                    // Make the bomb picture visible.
                    pictureBox2.Visible = true;
                }
                // Check if the number is greater than 6.
                else if (chance > 6)
                {
                    // Set the mole picture box to a random location within the form.
                    pictureBox1.Left = random.Next(0, this.Width);
                    pictureBox1.Top = random.Next(0, this.Height);
                    // Make the mole picture visible.
                    pictureBox1.Visible = true;
                }
            }
            // Check if the score is less than 15
            // Chance for bombs is increased, as well as speed.
            else if (score < 15)
            {
                // Increase the speed slightly
                timer1.Interval = 700;
                // Store a random number between 0 and 10 in a variable.
                int chance = random.Next(0, 10);
                // Check if the number is less than or equal to 7
                if (chance <= 7)
                {
                    // Set the bomb picture box to a random location within the form.
                    pictureBox2.Left = random.Next(0, this.Width);
                    pictureBox2.Top = random.Next(0, this.Height);
                    // Make the bomb picture visible.
                    pictureBox2.Visible = true;
                }
                // Check if the number is greater than 7.
                else if (chance > 7)
                {
                    // Set the mole picture box to a random location within the form.
                    pictureBox1.Left = random.Next(0, this.Width);
                    pictureBox1.Top = random.Next(0, this.Height);
                    // Make the mole picture visible.
                    pictureBox1.Visible = true;
                }
            }
            // Check if the score is less than 20
            // Speed increased.
            else if (score < 20)
            {
                // Increase the speed slightly
                timer1.Interval = 600;
                // Store a random number between 0 and 10 in a variable.
                int chance = random.Next(0, 10);
                // Check if the number is less than or equal to 7
                if (chance <= 7)
                {
                    // Set the bomb picture box to a random location within the form.
                    pictureBox2.Left = random.Next(0, this.Width);
                    pictureBox2.Top = random.Next(0, this.Height);
                    // Make the bomb picture visible.
                    pictureBox2.Visible = true;
                }
                // Check if the number is greater than 7.
                else if (chance > 7)
                {
                    // Set the mole picture box to a random location within the form.
                    pictureBox1.Left = random.Next(0, this.Width);
                    pictureBox1.Top = random.Next(0, this.Height);
                    // Make the mole picture visible.
                    pictureBox1.Visible = true;
                }
            }
        }

        //If the user clicks the form (misses a mole).
        private void Form1_Click(object sender, EventArgs e)
        {
            // Check if the lives are greater than 1.
            if (lives > 1)
            {
                // So long as the timer is enabled (game is currently running).
                if(timer1.Enabled == true)
                {
                    // Decrease lives by 1 and update the label.
                    lives = lives - 1;
                    label5.Text = lives.ToString();
                }

            }
            // Check if the player is on their last life.
            else if (lives == 1)
            {
                // Check if the timer is enabled (game is running).
                if (timer1.Enabled == true)
                {
                    //Call the GameOver method.
                    GameOver(false);   
                }
            }
        }
        // When the user clicks on the Mole picture box.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Check if the timer is enabled (game is running).
            if (timer1.Enabled == true)
            {
                // Set the mole to invisible.
                pictureBox1.Visible = false;
                // Increase the users score and update the label.
                score = score + 1;
                label3.Text = score.ToString();
                // Check if the user has reached a score of 100
                if (score == 2)
                {
                    // If the user has reached 20 they win, call GameOver.
                    GameOver(true);
                }
            }
            

        }
        //Gameover method to handle the end of game.
        private void GameOver(bool win)
        {
            // Disable the timer control (stop the game).
            timer1.Enabled = false;
            // Stop the watch.
            watch.Stop();
            // Make sure the bomb and mole are not visible anymore.
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            label8.Text = highScore.ToString();
            // Reset the display for the score, lives, and timer.
            label1.Text = "00:00";
            label5.Text = lives.ToString();
            label3.Text = score.ToString();
            // Check if the user has won.
            if(win)
            {
                if(level < 3)
                {
                    // Set high score.
                    highScore = score;
                    // Reset the score.
                    score = 0;
                    label3.Text = score.ToString();
                    // Increase the level.
                    level++;
                    label10.Text = level.ToString();
                    // Update the high score.
                    highScore = highScore + tempScore;
                    tempScore = highScore;
                    label8.Text = highScore.ToString();
                    // Change the background for the appropriate level.
                    ChangeLevel(level);
                    // Show the start button.
                    startButton.Visible = true;
                    // Display a message box that the user has won.
                    MessageBox.Show("YOU WON THIS ROUND!");
                }
                else
                {
                    // Reset the score.
                    score = 0;
                    label3.Text = score.ToString();
                    // Update the high score.
                    highScore = highScore + tempScore;
                    label8.Text = highScore.ToString();
                    // Make the Play Again button visible.
                    playAgainButton.Visible = true;
                    // Display the winning message box.
                    MessageBox.Show("YOU BEAT THE GAME!");

                }
                
            }
            if(!win)
            {
                // Update the high score.
                highScore = highScore + score;
                label8.Text = highScore.ToString();
                // Reset the score.
                score = 0;
                label3.Text = score.ToString();
                // Make the Play Again button visible.
                playAgainButton.Visible = true;
                MessageBox.Show("YOU LOSE");
            }
            
        }
        // The user clicks on the bomb picture box.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Decrease the lives by 1 and update the label.
            lives = lives - 1;
            label5.Text = lives.ToString();
            // Check if the user is out of lives
            if (lives == 0)
            {
                //Call the GameOver method.
                GameOver(false);
            }
            
        }
        // Update level method.
        private void ChangeLevel(int level)
        {
            switch(level)
            {
                case 1:
                    {
                        //Change the background image on the form to the level1 image.
                        myImage = Properties.Resources.Nature;
                        this.BackgroundImage = null;
                        this.BackgroundImage = myImage;
                        break;
                    }
                case 2:
                    {
                        //Change the background image on the form to the level2 image.
                        myImage = Properties.Resources.Level2;
                        this.BackgroundImage = null;
                        this.BackgroundImage = myImage;
                        break;
                    }
                case 3:
                    {
                        //Change the background image on the form to the level3 image.
                        myImage = Properties.Resources.Level3;
                        this.BackgroundImage = null;
                        this.BackgroundImage = myImage;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
