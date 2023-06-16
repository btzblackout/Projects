using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        //The board is always square, usually 8x8.
        public int Size { get; set; }

        //The 2D array of cell objects.
        public Cell[,] theGrid { get; set; }

        //Constructor
        public Board(int s)
        {
            Size = s;

            //We must initialize the array to avoid Null Exception errors.
            theGrid = new Cell[Size, Size];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkLegalNextMoves(Cell currentCell, string chessPiece)
        {
            //This is used for for knowing when to stop trying because we're out of bounds.
            bool stepOut = false;
            
            //Step 1 - clear all legal moves from the previous turn.
            for (int r = 0; r < Size; r++)
            {
                for (int c = 0; c < Size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                }
            }

            //Step 2 - find all legal moves and mark the square.
            switch(chessPiece)
            {
                case "KNIGHT":
                    {
                        IsOutOfBounds(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1);
                        IsOutOfBounds(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1);
                        IsOutOfBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2);
                        IsOutOfBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2);
                        IsOutOfBounds(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1);
                        IsOutOfBounds(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1);
                        IsOutOfBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2);
                        IsOutOfBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2);
                        break;
                    }
                case "KING":
                    {
                        IsOutOfBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber);
                        IsOutOfBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber);
                        IsOutOfBounds(currentCell.RowNumber, currentCell.ColumnNumber - 1);
                        IsOutOfBounds(currentCell.RowNumber, currentCell.ColumnNumber + 1);
                        IsOutOfBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1);
                        IsOutOfBounds(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1);
                        IsOutOfBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1);
                        IsOutOfBounds(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1);
                        break;
                    }
                case "ROOK":
                    {
                        //I use do while instead of while because it will run the body before checking the condition
                        //meaning that while the condition should be true when exiting the last do while loop 
                        //the next will reset back to false (provided it isnt also out of bounds) before checking the condition.
                        //This prevents me from having to reset the condition after each loop.
                        do
                        {
                            //The for loop checks as many times as the size -1 incase the piece is on one of the edges.
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber + 1 + i, currentCell.ColumnNumber);
                            }
                        }
                        while (!stepOut);

                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber - 1 - i, currentCell.ColumnNumber);
                            }
                        }
                        while (!stepOut);

                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber, currentCell.ColumnNumber - 1 - i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber, currentCell.ColumnNumber + 1 + i);
                            }
                        }
                        while (!stepOut);
                        break;
                    }
                case "BISHOP":
                    {
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber + 1 + i, currentCell.ColumnNumber + 1 + i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber - 1 - i, currentCell.ColumnNumber - 1 - i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber + 1 + i, currentCell.ColumnNumber - 1 - i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber - 1 - i, currentCell.ColumnNumber + 1 + i);
                            }
                        }
                        while (!stepOut);
                        break;
                    }
                case "QUEEN":
                    {
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber + 1 + i, currentCell.ColumnNumber);
                            }
                        }
                        while (!stepOut);

                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber - 1 - i, currentCell.ColumnNumber);
                            }
                        }
                        while (!stepOut);

                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber, currentCell.ColumnNumber - 1 - i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber, currentCell.ColumnNumber + 1 + i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber + 1 + i, currentCell.ColumnNumber + 1 + i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber - 1 - i, currentCell.ColumnNumber - 1 - i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber + 1 + i, currentCell.ColumnNumber - 1 - i);
                            }
                        }
                        while (!stepOut);
                        do
                        {
                            for (int i = 0; i < Size; i++)
                            {
                                stepOut = IsOutOfBounds(currentCell.RowNumber - 1 - i, currentCell.ColumnNumber + 1 + i);
                            }
                        }
                        while (!stepOut);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        //Check if each cell is out of bounds, if not set it to a legal next move. If it is, skip that cell.
        private bool IsOutOfBounds(int row, int col)
        {
            //Set it to out of bounds by default
            bool isOut = true;
            
            //Try to change it to a legal next move and if so change the boolean to reflect that it is not out of bounds.
            try
            {
                theGrid[row, col].LegalNextMove = true;
                isOut = false;
            }
            catch 
            {
                
            }
            return isOut;
        }
    }
}
