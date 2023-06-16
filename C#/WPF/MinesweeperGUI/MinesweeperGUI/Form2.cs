using Minesweeper_Console_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
namespace MinesweeperGUI
{
    public partial class Form2 : Form
    {
        // Declare the variables.
        Board newBoard;                     // newBoard will hold the game board.
        Cell[,] grid;                       // grid will be the matrix of cells on the board.
        bool gameOver = false;              // gameOver is the condition that is thrown when a player hits a bomb.
        bool hasWon = true;                 // hasWon will return true if every non bomb space has been visited.
        Image myImage;                      // myImage is used for the bomb and flag images.
        Stopwatch watch = new Stopwatch();  // watch is used to manage the play time.
        int size;                           // size is the size of the board.
        string difficulty;                  // difficulty is the players chosen difficulty.
        public Button[,] buttonGrid;        // buttonGrid is the grid of buttons displayed on the form.

        // Constructor takes 2 parameters.
        public Form2(int size, string difficulty)
        {
            InitializeComponent();
            
            // Set the passed parameters.
            this.difficulty = difficulty;
            this.size = size;
        }

        // When the form is loaded.
        private void Form2_Load(object sender, EventArgs e)
        {
            // Instantiate the button grid with size.
            buttonGrid = new Button[size, size];
            
            // Create a new board and call the beginning methods.
            newBoard = new Board(size);
            newBoard.SetupLiveNeighbors(difficulty);
            newBoard.CalculateLiveNeighbors();
            
            // Get the Cell matrix from the board.
            grid = newBoard.getGrid();
            
            // Call the PopulateGrid() method.
            PopulateGrid();
        }
        
        // Populates the button grid in the window.
        private void PopulateGrid()
        {
            // Get half of the provided size.
            int halfSize = size / 2;
            
            // We want the size of the buttons to be based on the width of the gameSpace groupbox and halfSize.
            int buttonSize = gameSpace.Width / halfSize;

            // Traverse the matrix.
            for (int r = 0; r < halfSize; r++)
            {
                for (int c = 0; c < halfSize; c++)
                {
                    // Create a new button.
                    buttonGrid[r, c] = new Button();
                    
                    // Set the button size.
                    buttonGrid[r, c].Width = buttonSize;
                    buttonGrid[r, c].Height = buttonSize;
                    
                    // Add the click components to the button.
                    buttonGrid[r, c].Click += Grid_Button_Click;
                    buttonGrid[r, c].MouseUp += Grid_Right_Click;
                    
                    // Add the button to the the gameSpace groupbox.
                    gameSpace.Controls.Add(buttonGrid[r, c]);
                    buttonGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c);

                    // Set the background color for the button.
                    buttonGrid[r, c].BackColor = Color.LightBlue;

                    // Set the tag for the button for future use.
                    buttonGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                }
            }
        }

        // This method handles the button clicks.
        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // Check if the timer is enabled. If not, enable it.
            if(!timer1.Enabled)
            {
                timer1.Enabled = true;
                watch.Start();
            }
            
            // Get the row and col number of the button clicked.
            string[] strArr = (sender as Button).Tag.ToString().Split('|');
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);

            // Check if the current cell is a bomb.
            if (grid[r, c].getLive())
            {
                gameOver = true;
            }
            
            // FloodFill from the current Cell.
            newBoard.FloodFill(r, c);
            
            // Call the UpdateBoard method.
            UpdateBoard();
        }
        // This method handles right-mouse clicks for placing flags.
        private void Grid_Right_Click(object sender, MouseEventArgs e)
        {
            // get the row and col number of the button clicked.
            string[] strArr = (sender as Button).Tag.ToString().Split('|');
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);

            //If the user right clicks.
            if (e.Button == MouseButtons.Right)
            {
                //Make sure the user can only flag unvisited cells.
                if(!grid[r,c].getVisited())
                {
                    //Set myImage to the flag.
                    myImage = Properties.Resources.flag;
                    //If the user has placed a flag, remove it.
                    if (buttonGrid[r,c].BackgroundImage != null)
                    {
                        buttonGrid[r, c].BackgroundImage = null;
                    }
                    //If the user has not placed a flag already, place one.
                    else
                    {
                        buttonGrid[r, c].BackgroundImage = myImage;
                        buttonGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
                //Call the UpdateBoard method.
                UpdateBoard();
            }
        }
        //Method to update the board.
        private void UpdateBoard()
        {
            // If statement to check if the user has hit a bomb.
            if(!gameOver)
            {
                // Reset the hasWon variable. The logic of this checking is that it is to remain true until proven false.
                // If it remains true through all of the checks below the user has won the game.
                hasWon = true;
                
                // Traverse the grid.
                for (int r = 0; r < newBoard.getSize(); r++)
                {
                    for (int c = 0; c < newBoard.getSize(); c++)
                    {
                        // If the cell has been visited and the live neighbors is not 0.
                        if (grid[r, c].getVisited() && grid[r, c].getLiveNeighbors() != 0)
                        {
                            // Display the live neighbors and set the background color to default.
                            buttonGrid[r, c].Text = grid[r, c].getLiveNeighbors().ToString();
                            buttonGrid[r, c].BackColor = DefaultBackColor;
                        }
                        // If the cell has been visited and the live neighbors is 0.
                        if (grid[r, c].getVisited() && grid[r, c].getLiveNeighbors() == 0)
                        {
                            // Set the background color to default.
                            buttonGrid[r, c].BackColor = DefaultBackColor;
                        }
                        //If the cell is not a bomb, and it has not been visited.
                        //This is a check to see if every cell has been visited that is not a bomb so the
                        //player can win.
                        if (grid[r, c].getLive() == false && grid[r, c].getVisited() == false)
                        {
                            // If the the condition above has been met the player has not won the game yet.
                            hasWon = false;
                        }
                    }
                }
                // If the grid traversed and hasWon is still true (meaning the player visited every cell that is not a bomb).
                if(hasWon)
                {
                    // Stop the watch.
                    watch.Stop();
                    
                    // Set myImage to the flag image.
                    myImage = Properties.Resources.flag;
                    
                    // Traverse the grid and set the background of all bombs to flags.
                    for (int r = 0; r < newBoard.getSize(); r++)
                    {
                        for (int c = 0; c < newBoard.getSize(); c++)
                        {
                            if(grid[r,c].getLive())
                            {
                                buttonGrid[r, c].BackgroundImage = myImage;
                                buttonGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                            }
                        }
                    }

                    // Create a copy of the HighScore form to display and pass the difficulty and the watch.
                    HighScore highScore = new HighScore(difficulty, watch, true);

                    // Show the highScore form.
                    highScore.Show();
                    
                    // Display the win box and the time elapsed.
                    MessageBox.Show("You win! Time elapsed: " + watch.Elapsed.ToString("mm\\:ss"));

                    // When the user clicks Ok on the MessageBox close the game form.
                    this.Close();
                }

                
            }
            // Else statement will trigger if the user hit a bomb.
            else
            {
                // Stop the watch.
                watch.Stop();
                
                // Set myImage to the bomb image.
                myImage = Properties.Resources.Bomb;
                
                // Traverse the grid and set the background of all bombs to the bomb picture.
                for (int r = 0; r < newBoard.getSize(); r++)
                {
                    for (int c = 0; c < newBoard.getSize(); c++)
                    {
                        if(grid[r,c].getLive())
                        {
                            
                            buttonGrid[r, c].BackgroundImage = myImage;
                            buttonGrid[r, c].BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }

                // Create a copy of the HighScore form to display and pass the difficulty and the watch.
                HighScore highScore = new HighScore(difficulty, watch, false);

                // Show the highScore form.
                highScore.Show();

                // Display the win box and the time elapsed.
                MessageBox.Show("You hit a bomb! Time elapsed: " + watch.Elapsed.ToString("mm\\:ss"));

                // When the user clicks Ok on the MessageBox close this form.
                this.Close();
            }          
        }
        //This method updates every time the timer ticks (every second)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Update the timerLabel text with the current time.
            timerLabel.Text = watch.Elapsed.ToString("mm\\:ss");
        }
    }
} 
