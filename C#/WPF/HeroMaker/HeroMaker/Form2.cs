using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class Form2 : Form
    {
        //Declare variables.
        List<SuperHero> theList;

        //Set the list passed in to the local list.
        public Form2(List<SuperHero> myList)
        {
            theList = myList;
            InitializeComponent();
            
        }
        
        //On form load parse through the list and populate the listbox1 with each heroes name.
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (SuperHero hero in theList)
            {
                listBox1.Items.Add(hero.getName());
            }
        }

        //When the user clicks on one of the names in listbox1, parse through the list of heroes
        //and find the hero object that matches. Display the information for that hero in the textbox 1,
        //populate the image box with the heroes image, and set the cape box to the appropriate color.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < theList.Count; i++)
            {
                if (listBox1.SelectedItem.ToString() == theList[i].getName())
                {
                    textBox1.Text = theList[i].toString();
                    portraitBox.Image = theList[i].getHeroPortrait();
                    portraitBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    capeBox.BackColor = theList[i].getCapeColor();
                }
            }
        }
    }
}
