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
    public partial class Login : Form
    {
        public bool loggedIn = false;
 
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameInputBox.Text == "admin" && PasswordInputBox.Text == "admin")
            {
                loggedIn = true;
                UsernameDisplayLabel.Text = UsernameInputBox.Text;
                MainMenuPanel.Enabled = true;
                MainMenuPanel.Visible = true;
                UsernameInputBox.Text = String.Empty;
                PasswordInputBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("The username or password is incorrect!");
            }
            
        }

        private void UsernameInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            MainMenuPanel.Enabled = false;
        }

        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            InventoryPanel.Location = new Point(3, 9);
            InventoryPanel.Enabled = true;
            InventoryPanel.Visible = true;
        }

        private void InvBackButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;
            InventoryPanel.Visible = false;
            InventoryPanel.Enabled = false;
            
        }

        private void ViewOrdersButton_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = false;
            OrdersPanel.Enabled = true;
            OrdersPanel.Visible = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            MainMenuPanel.Visible = true;
            if (OrderItemsPanel.Enabled == true || OrderItemsPanel.Visible == true)
            {
                OrderItemsPanel.Enabled = false;
                OrderItemsPanel.Visible = false;
            }
            OrdersPanel.Visible = false;
            OrdersPanel.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            OrderItemsPanel.Enabled = true;
            OrderItemsPanel.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            OrderItemsPanel.Visible = false;
            OrderItemsPanel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoPanel.Enabled = true;
            InfoPanel.Location = new Point(268, 54);
            InfoPanel.Visible = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            InfoPanel.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditPanel.Enabled = true;
            EditPanel.Location = new Point(268, 54);
            EditPanel.Visible = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
            EditPanel.Enabled = false;
        }
    }
}
