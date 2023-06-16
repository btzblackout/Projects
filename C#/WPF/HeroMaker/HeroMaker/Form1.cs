using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class HeroMakerForm : Form
    {
        //Define variables
        string sex;
        string movement;
        string headquarters;
        int maxSlider = 100;  //For use with the sliders.
        DateTime date;
        Bitmap heroImage;
        List<string> attributes = new List<string>();
        HeroList heroList = new HeroList();
        
        public HeroMakerForm()
        {
            InitializeComponent();
            pointsLabel.Text = maxSlider.ToString();    //Set the initial value of 0 to the pointsLabel label
            movementComboBox.SelectedIndex = 0;         //Set a default selected index.
            headquartersListBox.SelectedIndex = 0;      //Set a default selected index.
            darksideDataLabel.Text = darkSideTrackBar.Value.ToString(); //Set the initial value of 0 to the darkside label
            maleRadioButton.Checked = true;             //Set the male radio button checked by default.
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            //Check if each of the checkboxes are checked. If they are add them to the attributes list.
            if(regenerationCheckBox.Checked)
            {
                attributes.Add(regenerationCheckBox.Text);
            }
            if (invisibilityCheckBox.Checked)
            {
                attributes.Add(invisibilityCheckBox.Text);
            }
            if (xrayCheckBox.Checked)
            {
                attributes.Add(xrayCheckBox.Text);
            }
            if (timeManipulationCheckBox.Checked)
            {
                attributes.Add(timeManipulationCheckBox.Text);
            }
            if (teleportationCheckBox.Checked)
            {
                attributes.Add(teleportationCheckBox.Text);
            }
            if (telepathyCheckBox.Checked)
            {
                attributes.Add(telepathyCheckBox.Text);
            }
            if (mindControlCheckBox.Checked)
            {
                attributes.Add(mindControlCheckBox.Text);
            }
            if (superStrengthCheckBox.Checked)
            {
                attributes.Add(superStrengthCheckBox.Text);
            }
            //Check which radio button is checked and set it to the sex variable.
            if(maleRadioButton.Checked)
            {
                sex = maleRadioButton.Text;
            }
            if(femaleRadioButton.Checked)
            {
                sex = femaleRadioButton.Text;
            }
            //Check if heroimage, colorbox, name, and attribute list are empty
            if(heroImage == null)
            {
                attributes.Clear();
                MessageBox.Show("Please select an image for the hero.");
            }
            if(pictureBox2.BackColor == DefaultBackColor)
            {
                attributes.Clear();
                MessageBox.Show("Please choose a cape color for your hero!");
            }
            if(heroNameTextBox.Text == "")
            {
                attributes.Clear();
                MessageBox.Show("Enter a name for your hero");
            }
            if(attributes.Count == 0)
            {
                MessageBox.Show("Select some attributes for your hero");
            }
            //Only add a new hero if none of the fields are blank.
            if(heroNameTextBox.Text != "" && attributes.Count != 0 &&headquartersListBox.SelectedItem != null && movementComboBox != null && heroImage != null && pictureBox2.BackColor != DefaultBackColor)
            {
                //Set the selected movement type.
                movement = movementComboBox.SelectedItem.ToString();
                //Set the selected headquarters.
                headquarters = headquartersListBox.SelectedItem.ToString();
                //Create a new list to copy the attributes list to
                //(If we do not do this when we clear the attributes list between creating heros it will clear the attributes for the heroes as well)
                List<string> temp = new List<string>(attributes);
                //Set the date.
                date = dateTimePicker1.Value;
                //Create the hero
                SuperHero hero = new SuperHero(heroNameTextBox.Text, temp, sex, movement, headquarters, heroImage, pictureBox2.BackColor, speedScrollBar.Value, staminaScrollBar.Value, strengthScrollBar.Value, darkSideTrackBar.Value, date, Decimal.ToInt32(numericUpDown1.Value));
                //Add the hero to the hero list.
                heroList.addSuperHero(hero);
                //Clear the attributes list and reset fields between heroes.
                this.attributes.Clear();
                heroNameTextBox.Text = "";
                darkSideTrackBar.Value = 0;
                darksideDataLabel.Text = darkSideTrackBar.Value.ToString();
                regenerationCheckBox.Checked = false;
                invisibilityCheckBox.Checked = false;
                xrayCheckBox.Checked = false;
                timeManipulationCheckBox.Checked = false;
                teleportationCheckBox.Checked = false;
                telepathyCheckBox.Checked = false;
                mindControlCheckBox.Checked = false;
                superStrengthCheckBox.Checked = false;
                maleRadioButton.Checked = true;
                movementComboBox.SelectedIndex = 0;
                headquartersListBox.SelectedIndex = 0;
                numericUpDown1.Value = 0;
                speedScrollBar.Value = 0;
                speedCountLabel.Text = speedScrollBar.Value.ToString();
                staminaScrollBar.Value = 0;
                staminaCountLabel.Text = staminaScrollBar.Value.ToString();
                strengthScrollBar.Value = 0;
                strengthCountLabel.Text = strengthScrollBar.Value.ToString();
                maxSlider = 100;
                pointsLabel.Text = maxSlider.ToString();
                pictureBox1.Image = null;
                pictureBox2.BackColor = DefaultBackColor;

            }
        }

        //Open the second form and pass the herolist to it.
        private void viewHeroesButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(heroList.getSuperHeroList());
            form2.Show();
        }

        //When the button is clicked, open the colordialog and set the color to the appropriate box's background.
        private void capeColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox2.BackColor = colorDialog1.Color;
        }

        //Open the filedialog box and set the image to the appropriate box, resizing it to fit.
        private void heroImageButton_Click(object sender, EventArgs e)
        {

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                heroImage = new Bitmap(openFileDialog1.FileName);
                //display image in picture box
                pictureBox1.Image = heroImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //The following 3 methods handle the scrollbars for speed, stamina, and strength.
        //They each have a max of 100 but each value added together can only equal 100.
        //When one goes over the 100 mark the other 2 are decremented to make up for it.
        private void speedScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (MaxScrollable())
            {
                speedCountLabel.Text = speedScrollBar.Value.ToString();
            }
            else
            {
                if(staminaScrollBar.Value != 0)
                {
                    staminaScrollBar.Value = staminaScrollBar.Value - 1;
                    staminaCountLabel.Text = staminaScrollBar.Value.ToString();
                }
                if(strengthScrollBar.Value != 0)
                {
                    strengthScrollBar.Value = strengthScrollBar.Value - 1;
                    strengthCountLabel.Text = strengthScrollBar.Value.ToString();
                }

                speedCountLabel.Text = speedScrollBar.Value.ToString();
            }
            if (maxSlider == -1 || maxSlider == 0)
            {
                pointsLabel.Text = "0";
            }
            else
            {
                pointsLabel.Text = maxSlider.ToString();
            }
        }

        private void staminaScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (MaxScrollable())
            {
                staminaCountLabel.Text = staminaScrollBar.Value.ToString();
            }
            else
            {
                if(speedScrollBar.Value != 0)
                {
                    speedScrollBar.Value = speedScrollBar.Value - 1;
                    speedCountLabel.Text = speedScrollBar.Value.ToString();
                }
                if (strengthScrollBar.Value != 0)
                {
                    strengthScrollBar.Value = strengthScrollBar.Value - 1;
                    strengthCountLabel.Text = strengthScrollBar.Value.ToString();
                }
                staminaCountLabel.Text = staminaScrollBar.Value.ToString();
            }
            if (maxSlider == -1 || maxSlider == 0)
            {
                pointsLabel.Text = "0";
            }
            else
            {
                pointsLabel.Text = maxSlider.ToString();
            }

        }

        private void strengthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if(MaxScrollable())
            {
                strengthCountLabel.Text = strengthScrollBar.Value.ToString();
            }
            else
            {
                if(staminaScrollBar.Value != 0)
                {
                    staminaScrollBar.Value = staminaScrollBar.Value - 1;
                    staminaCountLabel.Text = staminaScrollBar.Value.ToString();
                }
                if(speedScrollBar.Value != 0)
                {
                    speedScrollBar.Value = speedScrollBar.Value - 1;
                    speedCountLabel.Text = speedScrollBar.Value.ToString();
                }

                strengthCountLabel.Text = strengthScrollBar.Value.ToString();
            }
            if (maxSlider == -1 || maxSlider == 0)
            {
                pointsLabel.Text = "0";
            }
            else
            {
                pointsLabel.Text = maxSlider.ToString();
            }

        }
        //This method handles the max scroll bar value for the three scroll bars.
        private bool MaxScrollable()
        {
            maxSlider = 100 - strengthScrollBar.Value - staminaScrollBar.Value - speedScrollBar.Value;
            if (maxSlider < 0)
            {
                return false;
            }
            else return true;
        }
        
        private void HeroMakerForm_Load(object sender, EventArgs e)
        {

        }
        //Set the dark side trackbar value to the label. 
        private void darkSideTrackBar_Scroll(object sender, EventArgs e)
        {
            darksideDataLabel.Text = darkSideTrackBar.Value.ToString();
        }
    }
}
