using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Exercise_6
{
    public partial class Form1 : Form
    {
        //Create my persistent variables.
        Die FirstDie = new Die();
        Die SecondDie = new Die();
        Random rand = new Random();
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        //This is the button to click to roll the dice.
        private void RollButton_Click(object sender, EventArgs e)
        {
            //Rolls the die and displays the result.
            Die1.Text = FirstDie.RollDie(rand).ToString();
            Die2.Text = SecondDie.RollDie(rand).ToString();
            counter++;
            CounterLabel.Text = counter.ToString();
            
            //This is executed when snake eyes is achieved.
            if(Die1.Text == "1" && Die2.Text == "1")
            {
                if(counter == 1)
                {
                    MessageBox.Show("SNAKE EYES! It took 1 roll!");
                    counter = 0;
                }
                else
                {
                    MessageBox.Show("SNAKE EYES! It took " + counter + " rolls!");
                    counter = 0;
                }
                
            }
            
            
        }

        //this button is for setting up the dice.
        private void SetButton_Click(object sender, EventArgs e)
        {
            //Create variable
            int numberofSides = 0;

            //Try to translate user input sides to variable above, catch format exception error.
            //Also ensure user enters a number between 4-20
            try
            {
                numberofSides = Int32.Parse(textBox1.Text);
                if(numberofSides < 4 || numberofSides > 20)
                {
                    MessageBox.Show("Die can only be 4-20 sided. Please enter a correct number of sides.");
                    textBox1.Clear();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please enter a number.");
            }

            //Die1 is visible = false by default so this runs only once at the beginning of the program.
            if (Die1.Visible != true)
            {
                //Ensure the number of sides meets criteria
                if (numberofSides >= 4 && numberofSides <= 20)
                {
                    //Begin showing all the appropriate controls and making useless ones disappear. 
                    panel1.Visible = true;
                    panel2.Visible = true;
                    Die1.Visible = true;
                    Die1.Text = numberofSides.ToString();
                    Die2.Visible = true;
                    Die2.Text = numberofSides.ToString();
                    Die1Label.Visible = true;
                    Die2Label.Visible = true;
                    FirstDie.setNumberOfSides(numberofSides);
                    Die1Label.Text = numberofSides + " sided die.";
                    Die2Label.Text = numberofSides + " sided die.";
                    RollButton.Visible = true;
                    RollCounterLabel.Visible = true;
                    CounterLabel.Visible = true;
                    textBox1.Clear();
                    textBox1.Visible = false;
                    QuestionLabel.Visible = false;
                    SetButton.Visible = false;
                }
            }
        }
    }
}
