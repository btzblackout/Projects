using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaygroundApp
{

    public partial class Form1 : Form
    {
        List<String> list = new List<String>();
        Random rand = new Random();
        string listString = "";
        int number;
        int counter = 1;

        public Form1()
        {
            InitializeComponent();
            list.Clear();
            list.Add("Complete exercise 5");
            list.Add("Rebag the trash.");
            list.Add("Clean the kitchen.");
            list.Add("Complete DQ1.");
            list.Add("Complete DQ2.");
            list.Add("Complete participation for today.");
            list.Add("Apply for jobs.");
            list.Add("Pay the bills.");
            
            textBox1.Clear();
            for (int i = 0; i <= list.Count - 1; i++)
            {
                listString = listString + counter + ": " + list[i] + Environment.NewLine;
                counter++;
            }
            textBox1.Text = listString;

            number = rand.Next(list.Count);
            MinutesTextBox.Text = list[number];
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                list.RemoveAt(number);
                checkBox1.Checked = false;
                textBox1.Clear();
                UpdateButton_Click(sender, e);
            }
            number = rand.Next(list.Count);
            try { MinutesTextBox.Text = list[number]; }
            catch ( System.ArgumentOutOfRangeException)
            {
                MinutesTextBox.Clear();
                checkBox1.Checked = false;
                MessageBox.Show("Your task list is empty!");
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            listString = "";
            counter = 1;
            textBox1.Clear();
            for(int i = 0; i <= list.Count - 1; i++)
            {
                listString = listString + counter + ": " + list[i] + Environment.NewLine;
                counter++;
            }
            textBox1.Text = listString;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(AddTextBox.Text != "")
            {
                list.Add(AddTextBox.Text);
                UpdateButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("There is no task to add!");
            }
            AddTextBox.Clear();
            
        }
    }
}
