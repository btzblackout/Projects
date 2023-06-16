using System;
using ChessBoardModel;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {
            string response;
            bool isValidEntry = false;
            //Show the empty chess board
            printGrid(myBoard);

            //Get the location of the chess piece
            Cell myLocation = setCurrentCell();
            
            //Check to ensure the user entered a valid chess piece.
            while(!isValidEntry)
            {
                Console.WriteLine("Which chess piece would you like to use? Knight, King, Rook, Bishop, or Queen.");
                response = Console.ReadLine().ToUpper();
                if (response == "KNIGHT" || response == "KING" || response == "ROOK" || response == "BISHOP" || response == "QUEEN")
                {
                    //Calculate and mark the cells where legal moves are possible.
                    myBoard.MarkLegalNextMoves(myLocation, response);
                    isValidEntry = true;
                }
                else
                {
                    Console.WriteLine("The chess piece you entered is not valid, please try again.");
                }
                
            }
            
            //Show the chess board, Use . for an empty square, X for the piece location, and + for possible legal move.
            printGrid(myBoard);

            //Wait for another return key and end the program
            Console.ReadLine();
        }

        public static void printGrid(Board myBoard)
        {
            //Insert the very top row of lines above the board.
            Console.Write("+");
            for (int r = 0; r < myBoard.Size; r++)
            {
                Console.Write("---+");
            }
            Console.WriteLine();

            //Print the board on the console. Use "X" for location, "+" for legal move and "." for an empty square.
            for (int i = 0; i < myBoard.Size; i++)
            {
                Console.Write("|");
                for (int j = 0; j < myBoard.Size; j++)
                {
                    if(myBoard.theGrid[i,j].CurrentlyOccupied)
                    {
                        Console.Write(" X |");
                    }
                    else if(myBoard.theGrid[i,j].LegalNextMove)
                    {
                        Console.Write(" + |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine();

                //Insert a buffer inbetween each row of cells.
                Console.Write("+");
                for (int r = 0; r < myBoard.Size; r++)
                {
                    Console.Write("---+");
                }
                Console.WriteLine();
            }
        }

        public static Cell setCurrentCell()
        {
            int currentRow = 0;
            int currentCol = 0;
            bool con = false;
            bool finished = false;
            
            //This will make it repeat if the user enters anything other than a number.
            while(!finished)
            {
                try
                {
                    //The two while loops that set the bool to on or off server 2 purposes.
                    //1. It is a way to ensure the user enters a number that is within range of the board
                    //2. If the user enters a non-number for the col and it exits the try, it will pick up from where you left off.
                    while (!con)
                    {
                        Console.Out.Write("Enter your current row number: ");
                        currentRow = int.Parse(Console.ReadLine());
                        if (currentRow < myBoard.Size)
                        {
                            con = true;
                        }
                        else
                        {
                            Console.WriteLine("The number entered is outside the board, please try again.");
                        }
                    }
                    while (con)
                    {
                        Console.Out.Write("Enter your current column number: ");
                        currentCol = int.Parse(Console.ReadLine());
                        if (currentCol < myBoard.Size)
                        {
                            con = false;
                        }
                        else
                        {
                            Console.WriteLine("The number entered is outside the board, please try again.");
                        }

                    }
                    myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;
                    finished = true;
                }
                catch (Exception)
                {

                }
                finally
                {
                }
            }
            return myBoard.theGrid[currentRow, currentCol];
        }
    }
}
