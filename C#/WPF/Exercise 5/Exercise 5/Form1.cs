using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            int term = Int32.Parse(TermInput.Text);
            double placeholder = 0;

            for (int i = 0; i < term; i++)
            {
                if(i % 2 == 0)
                {
                    placeholder = (placeholder + (1.0 / (2.0 * i + 1.0)));
                    
                }
                else
                {
                    placeholder = (placeholder - (1.0 / (2.0 * i + 1.0)));
                }
            }

            placeholder = placeholder * 4;

            label3.Text = "The approximate value of pi after " + term + " terms is: ";
            TermLabel.Text = placeholder.ToString();
        }
    }

}
