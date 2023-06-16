using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinesweeperGUI
{
    public partial class Form1 : Form
    {
        //Declare variables.
        int size; //The size of board.
        string difficulty; //The difficulty of the game.

        //Constructor.
        public Form1()
        {
            InitializeComponent();
        }
        //On load, set the radio button to be selected by default to avoid no selection errors.
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        //Check which radio button is selected and set the difficulty of the game and board size.
        private void CheckDifficulty()
        {
            if (radioButton1.Checked)
            {
                difficulty = "easy";
                checkBox1.Checked = true;
            }
            else if (radioButton2.Checked)
            {
                difficulty = "medium";
                checkBox3.Checked = true;

            }
            else
            {
                difficulty = "hard";
                checkBox2.Checked = true;
            }
        }
        //When the user selects a difficulty the corresponding checkbox will automatically be selected.
        //The methods below ensure that only one size will be selected based on the difficulty.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            size = 20;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            size = 30;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            size = 40;
        }
       

        //When the user clicks the "Play Game" button.
        private void button1_Click(object sender, EventArgs e)
        {
            //Check which difficulty radio button is selected.
            CheckDifficulty();

            //Create an instance of Form2.
            Form2 form2 = new Form2(size, difficulty);

            //Hide the current form.
            this.Hide();

            //Show Form2.
            form2.Show();
        } 
    }
}
