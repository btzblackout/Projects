using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_4
{
    public partial class Form1 : Form
    {    
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void SimulateGameButton_Click(object sender, EventArgs e)
        {
            //resets the winner label
            label8.Text = "";

            //2D int array for generating random numbers.
            int[][] gameBoard = new int[][]
            { 
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }, 
                new int[] { 0, 0, 0 }
            };

            //2D char array for displaying X or O.
            char[][] displayBoard = new char[][]
            {
                new char[] { ' ', ' ', ' '},
                new char[] { ' ', ' ', ' '},
                new char[] { ' ', ' ', ' '}
            };

            //Char array that holds the users 
            char[] users = { 'X', 'O' };

            //Char for holding the winner
            char winner = ' ';
            
            //Randomly generates 0 or 1 in the gameBoard, and sets X or 0 that correspond in the displayBoard.
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for(int j = 0; j < gameBoard.GetLength(0); j++)
                {
                    gameBoard[i][j] = rand.Next(0, 2);
                    if(gameBoard[i][j] == 0)
                    {
                        displayBoard[i][j] = 'X';
                    }
                    else
                    {
                        displayBoard[i][j] = 'O';
                    }
                }
            }
            
            //Sets the displayBoard to the labels on the screen.
            TopLeft.Text = displayBoard[0][0].ToString();
            TopMid.Text = displayBoard[0][1].ToString();
            TopRight.Text = displayBoard[0][2].ToString();
            MidLeft.Text = displayBoard[1][0].ToString();
            Middle.Text = displayBoard[1][1].ToString();
            MidRight.Text = displayBoard[1][2].ToString();
            BotLeft.Text = displayBoard[2][0].ToString();
            BotMid.Text = displayBoard[2][1].ToString();
            BotRight.Text = displayBoard[2][2].ToString();
            
            //Iterates through the users
            foreach(char c in users)
            {
                //Horizontal check to win.
                if(displayBoard[0][0] == c && displayBoard[0][1] == c && displayBoard[0][2] == c ||
                   displayBoard[1][0] == c && displayBoard[1][1] == c && displayBoard[1][2] == c ||
                   displayBoard[2][0] == c && displayBoard[2][1] == c && displayBoard[2][2] == c)
                {
                    winner = c;
                }
                //Vertical check to win.
                else if(displayBoard[0][0] == c && displayBoard[1][0] == c && displayBoard[2][0] == c ||
                        displayBoard[0][1] == c && displayBoard[1][1] == c && displayBoard[2][1] == c ||
                        displayBoard[0][2] == c && displayBoard[1][2] == c && displayBoard[2][2] == c)
                {
                    winner = c;
                }
                //Diagonal check to win. 
                else if(displayBoard[0][0] == c && displayBoard[1][1] == c && displayBoard[2][2] == c||
                        displayBoard[2][0] == c && displayBoard[1][1] == c && displayBoard[0][2] == c)
                {
                    winner = c;
                }  
            }
            //If the char is still blank, none of the checks were true. Draw.
            if (winner == ' ')
            {
                label8.Text = "Draw";
            }
            //Sets the winner.
            else
            {
                label8.Text = winner.ToString();
            }
        }
    }
}
