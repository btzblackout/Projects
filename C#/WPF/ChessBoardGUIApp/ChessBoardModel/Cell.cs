using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Cell
    {
        //The row and col are the cells location on the grid.
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        
        //T/F is the chess piece on this cell?
        public bool CurrentlyOccupied { get; set; }

        //Is the square a legal move for the chess piece on the board?
        public bool LegalNextMove { get; set; }

        //Constructor
        public Cell(int r, int c)
        {
            RowNumber = r;
            ColumnNumber = c;
        }
    }
}
