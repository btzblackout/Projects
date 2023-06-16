using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileDataAccessDemo;
using System.IO;

namespace PeopleFileIO
{
    public partial class Form1 : Form
    {
        //Create a list of Person objects.
        List<Person> people = new List<Person>();
        //Define the path.
        string filePath = @"C:\demos\test.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            //Check to ensure there are no empty fields.
            if(firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && urlTextBox.Text != "")
            {
                //Create a new person object.
                Person p = new Person();
                //Set the person variables to the correct text box entries.
                p.firstName = firstNameTextBox.Text;
                p.lastName = lastNameTextBox.Text;
                p.Url = urlTextBox.Text;

                //Add the person to the list.
                people.Add(p);

                //Add the person to the list box.
                peopleListBox.Items.Add(p.firstName + ", " + p.lastName + ", " + p.Url);

                //Clear the text boxes in between entries.
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                urlTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("At least one field is not correct!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Create the output list.
            List<String> output = new List<String>();
            //Populate the output string list and add commas.
            foreach(Person p in people)
            {
                output.Add(p.firstName + "," + p.lastName + "," + p.Url);
            }
            File.WriteAllLines(filePath, output);

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            
            //Check if the file exists.
            if(File.Exists(filePath))
            {
                //Clear the current people list.
                people.Clear();
                //Clear the peopleListbox.
                peopleListBox.Items.Clear();

                //Create a list of strings and read in all the files lines.
                List<String> lines = File.ReadAllLines(filePath).ToList();
                
                //For each line in the lines.
                foreach(string line in lines)
                {
                    //Store the line in a string array, using the comma as a delimeter.
                    string[] entries = line.Split(',');
                    Person p = new Person();
                    p.firstName = entries[0];
                    p.lastName = entries[1];
                    p.Url = entries[2];

                    people.Add(p);

                    //Add the person to the list box.
                    peopleListBox.Items.Add(p.firstName + ", " + p.lastName + ", " + p.Url);
                }
            }
        }
    }
}
