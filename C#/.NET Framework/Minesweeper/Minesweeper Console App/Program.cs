using System;
using System.Collections.Generic;
using System.Text;



namespace Minesweeper_Console_App
{
    class Program
    {
        
        public static void Main(String[]args)
        {
            Console.WriteLine("Choose the size of the board. The number provided is the height and width of the board, " +
                "for example 20 would be a 10x10, 30 would be a 15x15 etc. Please use even numbers.");
            Board newBoard = new Board(int.Parse(Console.ReadLine()));
            Console.WriteLine("Choose the difficulty, 1 - easy 2 - medium 3 - hard ");
            //newBoard.SetupLiveNeighbors(int.Parse(Console.ReadLine()));
            newBoard.CalculateLiveNeighbors();
            PrintBoard(newBoard.getGrid(), newBoard);
            UpdateBoard(newBoard.getGrid(), newBoard);
            

        }


        //Method to print the board.
        //Takes the grid for traversing and the board to access the size of the board as parameters.
        public static void PrintBoard(Cell[,] grid, Board newBoard)
        {
            //Counter for display purposes
            int counter = 0;
            
            //Insert the first part of the top text format
            Console.Write("+ ");

            //Display the top row, which is the numbers for the columns.
            for (int i = 0; i < newBoard.getSize(); i++)
            {
                //I noticed that when the number reached 10 and above the formatting shifted and it didnt line up with
                //the columns anymore so this fixes that by removing the space to compensate for the extra digit.
                if(i >= 10)
                {
                    Console.Write(i + "+ ");
                }
                else
                {
                    Console.Write(i + " + ");
                }
                
            }
            
            //Insert the line under the very top row.
            Console.Write("\n+---+");
            for (int k = 1; k < newBoard.getSize(); k++)
            {
                Console.Write("---+");
            }

            //Insert a line break
            Console.WriteLine("");

            
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                //This part will put the very far left line on each row.
                Console.Write("| ");

                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    //Display the grid in a square format with the number of live neighbors listed and a star for bombs.
                    if(grid[i,j].getVisited() == false)
                    {
                            Console.Write("? | ");
                    }
                    counter++;
                    //Keeps the display nice and clean
                    if (counter == newBoard.getSize())
                    {
                        //Create the right column of numbers
                        Console.Write(i);
                        Console.Write("\n+---+");
                        for (int k = 1; k < newBoard.getSize(); k++)
                        {
                            Console.Write("---+");
                        }
                        Console.Out.WriteLine("");
                        counter = 0;
                    }
                }
            }
        }
        
        //Method for updating the board as the game is played.
        public static void UpdateBoard(Cell[,] grid, Board newBoard)
        {
            //Declare variables
            bool gameComplete = false;
            bool allCellsVisited;
            bool sufficient;
            bool win = true;
            int row = 0; 
            int col = 0;
            int counter = 0;

            //While the game is not complete this will continue to loop
            while(!gameComplete)
            {
                //Reset allCellsVisited until the loop below can prove otherwise.
                allCellsVisited = true;

                //Reset sufficient for ensuring proper user entry
                sufficient = false;

                //Ask for user input for row and col
                Console.WriteLine("Enter a row number: ");
                
                //Loop for ensuring proper user entry.
                while(!sufficient)
                {
                    //Exception handling incase the user enters non-numbers
                    try
                    {
                        row = int.Parse(Console.ReadLine());
                        if(row >= newBoard.getSize())
                        {
                            Console.WriteLine("The number is too large for the current board! Please try again.");
                        }
                        else
                        {
                            sufficient = true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You did not enter a number! Please try again.");
                    }
                }
                //Same as above but for col.
                Console.WriteLine("Enter a column number: ");
                sufficient = false;
                while (!sufficient)
                {
                    try
                    {
                        col = int.Parse(Console.ReadLine());
                        if (col >= newBoard.getSize())
                        {
                            Console.WriteLine("The number is too large for the current board! Please try again.");
                        }
                        else
                        {
                            sufficient = true;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You did not enter a number! Please try again.");
                    }
                }
                //grid[row, col].setVisited(true);
                newBoard.FloodFill(row, col);
                //Check if the current cell is a bomb.
                if (grid[row, col].getLive() == true)
                {
                    //Set the win condition for the if statement.
                    win = false;

                    //Break out of the loop
                    gameComplete = true;
                }

                //Parse through the grid and check if all cells have been visited that aren't live.
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        if (grid[i, j].getVisited() == false && grid[i, j].getLive() == false)
                        {
                            allCellsVisited = false;
                        }
                    }
                }
                if(allCellsVisited)
                {
                    //Break out of the loop.
                    gameComplete = true;
                }
                

                //Format display.
                Console.Write("+ ");
                for (int i = 0; i < newBoard.getSize(); i++)
                {
                    if (i >= 10)
                    {
                        Console.Write(i + "+ ");
                    }
                    else
                    {
                        Console.Write(i + " + ");
                    }
                }
                Console.Write("\n+---+");
                for (int k = 1; k < newBoard.getSize(); k++)
                {
                    Console.Write("---+");
                }
                Console.WriteLine("");

                //Parse through the grid.
                for (int i = 0; i < grid.GetLength(0); i++)
                {
                    Console.Write("| ");

                    for (int j = 0; j < grid.GetLength(1); j++)
                    {
                        //If the cell has not been visited, print a ?
                        if (grid[i, j].getVisited() == false)
                        {
                                Console.Write("? | ");
                        }
                        //If the cell has been visited.
                        else if (grid[i, j].getVisited() == true)
                        {
                            if (grid[i, j].getLive() == true)
                            {
                                Console.Write("* | ");
                            }
                            //If no live neighbors print blank space.
                            else if(grid[i,j].getLiveNeighbors() == 0)
                            {
                                Console.Write("  | ");
                                
                            }
                            //Not 0 live neighbors or a bomb, print the number of live neighbors.
                            else
                            {
                                Console.Write(grid[i, j].getLiveNeighbors() + " | ");
                            }

                        }
                        //Format display.
                        counter++;
                        if (counter == newBoard.getSize())
                        {
                            Console.Write(i);
                            Console.Write("\n+---+");
                            for (int k = 1; k < newBoard.getSize(); k++)
                            {
                                Console.Write("---+");
                            }
                            Console.Out.WriteLine("");
                            counter = 0;
                        }
                    }
                }
            }
            //After coming out of the while loop use win bool to determine appropriate print.
            if(win)
            {
                Console.WriteLine("Congratulations you win!");
            }
            else
            {
                Console.WriteLine("You hit a bomb, game over!");
            }
            
        }
    }
}
