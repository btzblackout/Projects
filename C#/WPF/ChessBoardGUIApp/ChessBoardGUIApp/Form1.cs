using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        public static Board myBoard = new Board(8);
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];
        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }
        public void populateGrid()
        {
            //This function will fill the panel1 control with buttons.
            int buttonSize = panel1.Width / myBoard.Size; //Calculate the width of each button on the Grid.
            panel1.Height = panel1.Width; //Set the grid to be square.

            //Nested loop. Create buttons and place them in the Panel.
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c] = new Button();

                    //Make each button square.
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;

                    btnGrid[r, c].Click += Grid_Button_Click; //Add the same click event to each button.
                    panel1.Controls.Add(btnGrid[r, c]); //Place the button on the Panel.
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c); //Position it in x,y

                    //The Tag attribute will hold the row and column number in a string.
                    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();

                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            //Get the row and column number of the button just clicked.
            string[] strArr = (sender as Button).Tag.ToString().Split('|');
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);

            //Run a helper function to label all legal moves for this piece.
            Cell currentCell = myBoard.theGrid[r, c];

            if(comboBox1.SelectedItem != null)
            {
                myBoard.MarkLegalNextMoves(currentCell, comboBox1.SelectedItem.ToString().ToUpper());
                updateButtonLabels();

                //Reset the background color of all buttons to default (original) color.
                for (int i = 0; i < myBoard.Size; i++)
                {
                    for (int j = 0; j < myBoard.Size; j++)
                    {
                        btnGrid[i, j].BackColor = default(Color);
                    }
                }

                //Set the background color of the clicked button to something different.
                (sender as Button).BackColor = Color.Cornsilk;
                
            }

        }

        public void updateButtonLabels()
        {
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c].Text = "";
                    if(myBoard.theGrid[r, c].CurrentlyOccupied)
                    {
                        btnGrid[r, c].Text = comboBox1.SelectedItem.ToString();
                        myBoard.theGrid[r, c].CurrentlyOccupied = false;
                    }
                    if(myBoard.theGrid[r, c].LegalNextMove)
                    {
                        btnGrid[r, c].Text = "Legal";
                    }
                }
            }
        }
    }
}
