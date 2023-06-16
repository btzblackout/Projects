using System;
using System.Collections.Generic;
using System.Text;


namespace Minesweeper_Console_App
{
    public class Board
    {
        //Declare variables
        private int size;
        private Cell[,] grid;
        private string difficulty;

        //Constructor
        public Board(int size)
        {
            //Half the size to get an even number of rows and cols
            this.size = size / 2;    
           
            //Create the grid and populate it with cells.
            grid = new Cell[this.size,this.size];  
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    grid[i,j] = new Cell(i, j, 0, false, false);                  
                }
            }
        }

        public Cell[,] getGrid()
        {
            return this.grid;
        }
        public int getSize()
        {
            return this.size;
        }

        //Method for setting the live bombs based on the difficulty chosen.
        public void SetupLiveNeighbors(string difficulty)
        {
            //Create new instance of random object.
            var rand = new Random();
            //Set the difficulty
            this.difficulty = difficulty;
            
            //Get the total number of cells by multiplying the two sides (its a square so the sides are the same).
            int numOfCells = size * size;
            
            //Set bombs to 0 by default.
            double bombs = 0;

            //Sets the number of bombs as a percent of the total number of cells based on user choice.
            //10% for easy, 35% for medium, 50% for hard.
            switch(difficulty)
            {
                case "easy":
                    {
                        bombs = numOfCells * 0.1;
                        break;
                    }
                case "medium":
                    {
                        bombs = numOfCells * 0.35;
                        break;
                    }
                case "hard":
                    {
                        bombs = numOfCells * 0.50;
                        break;
                    }
                default:
                    break;
            }
            //Set the bombs. the && here is because I noticed when I used larger sized grids like 15x15 and 25x25
            //the bomb count would go into the negatives because it would miss exactly 0 and run indefinitely. 
            while(bombs != 0 && bombs >= 0)
            {
                /* Randomly generate numbers to use for row and col.
                 * This takes a random number between 0 and the max number of cells and 
                 * one divides by the length of one side of the grid.
                 * I do this two seperate times to ensure the row and col are not the same
                 */

                int row = (rand.Next(numOfCells + 1) / this.size);
                int col = (rand.Next(numOfCells + 1) / this.size);

                //Try catch to handle out of bounds exceptions, should they occur.
                try
                {
                    //Check to see if the number will even fall within the matrix.
                    if (row <= this.size && col <= this.size)
                    {
                        //Check to see if the cell is already live.
                        if (grid[row, col].getLive() == false)
                        {
                            grid[row, col].setLive(true);
                            bombs--;
                        }
                    }
                }
                catch(Exception)
                {

                }
            }

            


        }

        //Method for calculating the live neighbors
        public void CalculateLiveNeighbors()
        {
            //For loop to traverse the matrix.
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    /* I use try/catch for out of bounds exceptions.
                     * Each check has its own try/catch because I feel if I used one try/catch and put all the
                     * if statements in, it would terminate the whole thing once it reached an exception.
                     * This way even if one of them throws an exception, it can still check the other sides of that cell.
                     */
                    try
                    {
                        if (grid[i, j + 1].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (grid[i, j - 1].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (grid[i + 1, j].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (grid[i - 1, j].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (grid[i + 1, j + 1].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (grid[i + 1, j - 1].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (grid[i - 1, j - 1].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    try
                    {
                        if (grid[i - 1, j + 1].getLive() == true)
                        {
                            grid[i, j].setLiveNeighbors(1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                    //Per the instructions "If the cell is live and the neighbor count is 8, set the neighbor count to 9.
                    if (grid[i, j].getLiveNeighbors() == 8)
                    {
                        grid[i, j].setLiveNeighbors(1);
                    }
                }
            }
        }

        //Method for showing blocks of empty cells
        public void FloodFill(int row, int col)
        {
            // Ensure the cell is within the bounds of the matrix.
            if(row < size && row >= 0 && col < size && col >= 0)
            {
                // Ensure the current cell is not a bomb.
                if (grid[row, col].getLive() == false)
                {
                    //Check if the cell has 0 live neighbors and has not been visited.
                    if (grid[row, col].getLiveNeighbors() == 0 && grid[row, col].getVisited() == false)
                    {
                        //set visited to true
                        grid[row, col].setVisited(true);
                        //Recurse down.
                        FloodFill(row + 1, col);
                        //Recurse up.
                        FloodFill(row - 1, col);
                        //Recurse right.
                        FloodFill(row, col + 1);
                        //Recurse left.
                        FloodFill(row, col - 1);
                        //Recurse up left
                        FloodFill(row - 1, col - 1);
                        //Recurse up right
                        FloodFill(row - 1, col + 1);
                        //Recurse down left
                        FloodFill(row + 1, col - 1);
                        //Recurse down right
                        FloodFill(row + 1, col + 1);
                    }
                    //If the cell failed the check above but is not a bomb set it as visited (this is so the cells next to the bombs are displayed).
                    grid[row, col].setVisited(true);
                }
            }
            
        }
    }
}
