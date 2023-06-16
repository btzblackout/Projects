using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MinesweeperGUI
{
    public partial class HighScore : Form
    {
        // Declare variables.
        Stopwatch time = new Stopwatch();                   // time will hold the passed in players time for score keeping.
        string difficulty;                                  // difficulty will hold the difficulty passed in for displaying similar difficulty scores.
        int score;                                          // score will hold the players score
        List<PlayerStats> players = new List<PlayerStats>();// players is a list of PlayerStats objects which will be the list of scores read from a file.
        List<string> outputList = new List<string>();       // outputList will hold values to write to a file for saving scores.
        string filePath = @"C:\demos\scores.txt";           // filePath is the file path that the scores text file is located at.
        bool userHasWon;                                    // userHasWon is a boolean used to check if this form has been created from a win or loss.
        
        // Constructor that takes 3 arguments.
        public HighScore(string difficulty, Stopwatch time, bool userHasWon)
        {
            InitializeComponent();
            this.difficulty = difficulty;
            this.time = time;
            this.userHasWon = userHasWon;
        }

        // This method activates when the form loads for the first time.
        private void HighScore_Load(object sender, EventArgs e)
        {
            // Check if the form was created from a win or loss.
            if(userHasWon)
            {
                // Call the GenerateScore() method.
                GenerateScore();
                
                // Set the scoreLabel to the players score.
                scoreLabel.Text = score.ToString();
            }
            // The user had lost the game
            else
            {
                // Disable the nameTextBox and addButton so the user cannot save their score.
                nameTextBox.Visible = false;
                addButton.Visible = false;

                // Set the scoreLabel to 0 for the loss.
                scoreLabel.Text = "0";
            }
            
            // Set the difficultyLabel to the players difficulty.
            difficultyLabel.Text = difficulty;

            //Call the LoadScores() method.
            LoadScores();
        }

        // This method loads the scores from the text file.
        private void LoadScores()
        {
            // This variable is used for populating a blank score text file with dummy values.
            int changeDifficulty = 0;
            
            // Check if the file exists already.
            if(File.Exists(filePath))
            {
                // Empty the players list incase there were old values.
                players.Clear();
                
                // List to hold the values read from the file.
                List<string> lines = File.ReadAllLines(filePath).ToList();
                
                // Loop to traverse each line stored in lines.
                foreach (string line in lines)
                {
                    // Store the each line in a string array, use the comma as the delimeter.
                    string[] entries = line.Split(',');

                    // Create a new player with the data read in.
                    PlayerStats player = new PlayerStats();
                    player.name = entries[0];
                    player.difficulty = entries[1];
                    player.score = int.Parse(entries[2]);

                    // Add the player to the players list.
                    players.Add(player);
                }
                
                // Run the DisplayTopScores() method to update the listBox with the top 5 scores.
                DisplayTopScores();
            }
            
            // If the file does not exist, create one.
            else if(!File.Exists(filePath))
            {
                // Clear the output list.
                outputList.Clear();
                
                // Loop for creating generic scores.
                for (int i = 0; i < 15; i++)
                {
                    // The for loop and these if statements ensure 5 players scores are added to each difficulty.
                    if (changeDifficulty < 5)
                    {
                        players.Add(new PlayerStats("NULL", "easy", 000));
                    }
                    else if (changeDifficulty < 10)
                    {
                        players.Add(new PlayerStats("NULL", "medium", 000));
                    }
                    else if (changeDifficulty < 15)
                    {
                        players.Add(new PlayerStats("NULL", "hard", 000));
                    }
                    // Increment the changeDifficulty variable each iteration.
                    changeDifficulty++;
                }
                
                // The foreach loop traverses the players list, combines a coma with the PlayerStats, and stores them in the output list.
                foreach (PlayerStats player in players)
                {
                    outputList.Add(player.name + "," + player.difficulty + "," + player.score);
                }
                
                // Save the output list to the file path.
                File.WriteAllLines(filePath, outputList);
                
                // Recurse on this method. This will not run the exact same the next time because the file is now created.
                LoadScores();
            }
        }

        // This method will populate the List Box control with the top 5 scores for the selected difficulty.
        private void DisplayTopScores()
        {
            // Reset the listbox.
            playerListBox.Items.Clear();
            
            // The counter variable is used to handle displaying only 5 (it starts at 1 because it is also used to display the "place" in each score).
            int counter = 1;
            
            // Traverse the players list and grab all scores that have the same difficulty as the current player, sorted.
            var highScoresFromDifficulty =
                from player in players
                where player.difficulty == difficulty
                orderby player
                select player;
            
            // Traverse the list created.
            foreach (var player in highScoresFromDifficulty)
            {
                // If statement to break out of the foreach after the first 5 have been added to the playerListbox.
                if (counter == 6)
                {
                    break;
                }
                // Populate the playerListBox with the score.
                playerListBox.Items.Add(counter + ": " + player.name + ", " + player.score);
                
                // Increment the counter.
                counter++;
            }
        }

        // This method handles adding the users score to the list.
        private void addButton_Click(object sender, EventArgs e)
        {
            // Check if the nameTextBox is empty.
            if(nameTextBox.Text != "")
            {
                // Create a new PlayerStats object using the users information and add it to the players list.
                players.Add(new PlayerStats(nameTextBox.Text, difficulty, score));
            }

            // Clear the output list.
            outputList.Clear();
            
            // Traverse the players list and add each score to the output list.
            foreach (PlayerStats player in players)
            {
                outputList.Add(player.name + "," + player.difficulty + "," + player.score);
            }
            
            // Save the output list to the file path.
            File.WriteAllLines(filePath, outputList);

            // Make the nameTextBox and Button invisible so the user cannot continue to add scores.
            nameTextBox.Visible = false;
            addButton.Visible = false;

            // Call the LoadScores method to reload the file and update the List Box.
            LoadScores();
        }
        
        // Method to generate the players score based on their time of completion.
        private void GenerateScore() 
        {
            // The logic behind this uses a switch statement with nested if statements.
            switch (difficulty)
            {
                // The user was playing an easy game.
                case "easy":
                    {
                        // The scores a player gets is based on the time of completion.
                        if (time.Elapsed.TotalSeconds <= 60)
                        {
                            score = 100;
                        }
                        else if (time.Elapsed.TotalSeconds <= 90)
                        {
                            score = 80;
                        }
                        else if (time.Elapsed.TotalSeconds <= 120)
                        {
                            score = 60;
                        }
                        else if (time.Elapsed.TotalSeconds <= 180)
                        {
                            score = 40;
                        }
                        else
                        {
                            score = 20;
                        }
                        break;
                    }
                // The user was playing a medium game.
                case "medium":
                    {
                        // As you can see the scores are higher than easy.
                        if (time.Elapsed.TotalSeconds <= 60)
                        {
                            score = 200;
                        }
                        else if (time.Elapsed.TotalSeconds <= 90)
                        {
                            score = 150;
                        }
                        else if (time.Elapsed.TotalSeconds <= 120)
                        {
                            score = 130;
                        }
                        else if (time.Elapsed.TotalSeconds <= 180)
                        {
                            score = 100;
                        }
                        else
                        {
                            score = 80;
                        }
                        break;
                    }
                // The user was playing a hard game.
                case "hard":
                    {
                        // The user has access to the highest scores in the game on hard.
                        if (time.Elapsed.TotalSeconds <= 120)
                        {
                            score = 300;
                        }
                        else if (time.Elapsed.TotalSeconds <= 180)
                        {
                            score = 260;
                        }
                        else if (time.Elapsed.TotalSeconds <= 210)
                        {
                            score = 240;
                        }
                        else if (time.Elapsed.TotalSeconds <= 240)
                        {
                            score = 220;
                        }
                        else
                        {
                            score = 200;
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        // This method fires when the player clicks the "Play Again" button.
        private void playAgainButton_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form1.
            Form1 form1 = new Form1();

            // Show form 1 and close this form.
            form1.Show();
            this.Close();
        }
    }
}
