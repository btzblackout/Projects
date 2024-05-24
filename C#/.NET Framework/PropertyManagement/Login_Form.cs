using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using PropertyManagement.Models;

namespace PropertyManagement
{
    public partial class Login_Form : MetroForm
    {
        LoginandRegister loginAndRegister = new LoginandRegister();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {

            // Check to ensure both the username and password textboxes are not empty and they aren't just white spaces.
            if (!string.IsNullOrWhiteSpace(textBox_Username.Text) && !string.IsNullOrWhiteSpace(textBox_Password.Text))
            {
                User user = new User();

                // Ensure the user exists in the database.
                if(loginAndRegister.CheckIfUsernameExists(textBox_Username.Text))
                {
                    // Attempt to login
                    user = loginAndRegister.Login(textBox_Username.Text, textBox_Password.Text);

                    // Check if the object is empty (username and password match DB entry).
                    // If the username is not empty then the user was found in the DB.
                    if (!string.IsNullOrEmpty(user.Username))
                    {
                        Main_Form form = new Main_Form(user);
                        this.Hide();
                        form.Show();
                    }
                    // The password is wrong (since we already checked the username before attempting to login we know the username exists in the DB).
                    else
                    {
                        MessageBox.Show("The password you provided does not match what we have in our system.");
                    }
                }
                else
                {
                    MessageBox.Show("The provided username does not exist in our system!");
                }            
            }
            else
            {
                // Check if it is the username that is empty.
                if(string.IsNullOrWhiteSpace(textBox_Username.Text))
                {
                    MessageBox.Show("The username field cannot be empty!");
                }
                // If it is not the username it must be the password that is empty. 
                else
                {
                    MessageBox.Show("The password field cannot be empty!");
                }
            }
        }
    }
}
