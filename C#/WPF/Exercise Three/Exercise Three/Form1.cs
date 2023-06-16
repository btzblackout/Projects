using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Three
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int temp = 1;
            int number = 0;
            try 
            {
                number = int.Parse(Input.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            
            while (number > 0)
            {
                temp = temp * number;
                number--;
            }
            String output = String.Format("{0:0.000}", temp);
            Output.Text = output.ToString();
        }
    }
}
 