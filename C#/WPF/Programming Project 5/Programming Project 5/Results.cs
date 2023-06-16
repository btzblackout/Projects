using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_5
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            Random rand = new Random();
            NumberLabel.Text = rand.Next(1, 101).ToString();
        }
    }
}
