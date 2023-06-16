using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class MainMenu : Form
    {
        public Boolean logout = false;
        public MainMenu()
        {
            InitializeComponent();
        }
        public  String SetLabelText
        {
            get { return this.label1.Text; }

            set { this.label1.Text = value; }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        
    }
}
