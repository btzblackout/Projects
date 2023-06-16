using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        bool firstCheck = false;
        bool secondCheck = false;
        bool thirdCheck = false;
        bool fourthCheck = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                lastChangeNumeric.Enabled = false;
                changePercentNumeric.Enabled = false;
            }
            else
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                lastChangeNumeric.Enabled = true;
                changePercentNumeric.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checks first round of information
            if(string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(symbolTextBox.Text) || priceNumeric.Value <= 0 || volumeNumeric.Value <= 0 || marketCapNumeric.Value <= 0)
            {
                MessageBox.Show("Make sure the company has a name, symbol (abrev. name), and all numeric values are above 0.");
                firstCheck = false;
            }
            else
            {
                firstCheck = true;
            }

            //Checks if should generate random change.
            if (checkBox1.Checked == false)
            {
                //Ensure that one radio button is checked.
                if(radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    MessageBox.Show("Make sure to check either the positive or negative button for market change.");
                    secondCheck = false;
                }
                else
                {
                    secondCheck = true;
                }

                if(lastChangeNumeric.Value <= 0 || changePercentNumeric.Value <= 0)
                {
                    MessageBox.Show("Make sure last change and change percent are above 0");
                    thirdCheck = false;
                }
                else
                {
                    thirdCheck = true;
                }
            }
            else
            {
                secondCheck = true;
                thirdCheck = true;
            }
            //Check that the user selected the correct extension for vol and market cap
            if (volumeThousandCheckBox.Checked == false && volumeMillionCheckBox.Checked == false && volumeBillionCheckBox.Checked == false && volumeTrillionCheckBox.Checked == false)
            {
                MessageBox.Show("Check one of the extensions for Volume");
                fourthCheck = false;
            }
            else if (marketThousandCheckBox.Checked == false && marketMillionCheckBox.Checked == false && marketBillionCheckBox.Checked == false && marketTrillionCheckBox.Checked == false)
            {
                MessageBox.Show("Check one of the extensions for Market Cap");
                fourthCheck = false;
            }
            else
            {
                fourthCheck = true;
            }

            if(firstCheck && secondCheck && thirdCheck && fourthCheck)
            {
                MessageBox.Show("All checks passed!");
            }
        }
    }
}
