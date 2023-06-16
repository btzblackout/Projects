using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming_Project_2.Properties;

namespace Programming_Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String selectedColor;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedColor = listBox1.SelectedItem.ToString();
            if (selectedColor == "Blue")
            {
                panel1.BackColor = Color.Blue;
                
            }
            else if (selectedColor == "Red")
            {
                panel1.BackColor = Color.Red;
            }
            else if (selectedColor == "Green")
            {
                panel1.BackColor = Color.Green;
            }
        }

        private void DarkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedColor == "Red")
            {
                panel1.BackColor = Color.DarkRed;
            }
            else if (selectedColor == "Blue")
            {
                panel1.BackColor = Color.DarkBlue;
            }
            else if (selectedColor == "Green")
            {
                panel1.BackColor = Color.DarkGreen;
            }
        }

        private void NormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedColor == "Red")
            {
                panel1.BackColor = Color.Red;
            }
            else if (selectedColor == "Blue")
            {
                panel1.BackColor = Color.Blue;
            }
            else if (selectedColor == "Green")
            {
                panel1.BackColor = Color.Green;
            }
        }

        private void BrightRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedColor == "Red")
            {
                panel1.BackColor = Color.HotPink;
            }
            else if (selectedColor == "Blue")
            {
                panel1.BackColor = Color.LightBlue;
            }
            else if (selectedColor == "Green")
            {
                panel1.BackColor = Color.LightGreen;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int R, G, B;
            RedValue.Text = Convert.ToString(RedSlider.Value);
            GreenValue.Text = Convert.ToString(GreenSlider.Value);
            BlueValue.Text = Convert.ToString(BlueSlider.Value);
            R = Convert.ToInt32(RedValue.Text);
            G = Convert.ToInt32(GreenValue.Text);
            B = Convert.ToInt32(BlueValue.Text);
            panel1.BackColor = Color.FromArgb(R, G, B);
        }

        private void RGBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
                tableLayoutPanel1.Enabled = true;
                tableLayoutPanel1.Visible = true;
            }
            else
            {
                timer1.Enabled = false;
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.Enabled = false;
                panel1.BackColor = Color.White;
            }
            
        }
    }
}
