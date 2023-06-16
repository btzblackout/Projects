/*  
 * Register.xaml.cs
 * Author: Raymond Lawson
 */
using FinancialPlanner.Database;
using System.Windows;
using System.Windows.Controls;


namespace FinancialPlanner.View.Pages
{
    public partial class Register : Page
    {
        //Declare variables.
        private string username, password, verifyPassword;

        //Constructor.
        public Register()
        {
            InitializeComponent();
        }

        //Sign-up Button Clicked
        private void SignUpButtonClicked(object sender, RoutedEventArgs e)
        {
            //Set variable values from control values.
            username = UsernameRegisterTextBox.Text;
            password = PasswordRegisterTextBox.Text;
            verifyPassword = VerifyPasswordRegisterTextBox.Text;
            
            //Ensure the text boxes are not empty.
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(verifyPassword))
            {
                //The password and verify password must match.
                if(password == verifyPassword)
                {
                    //Call the DBManager class to add the user and pass in the values. 
                    UserDBManager dbManager = new UserDBManager(username, password);
                    if(dbManager.AddUser())
                    {
                        //Successfully added user, go back to login.
                        this.NavigationService.GoBack();
                    }
                    else
                    {
                        MessageBox.Show("User already exists.");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords must match.");
                }
            }
            else
            {
                MessageBox.Show("No field can be empty.");
            }
        }

        //Back button clicked
        private void RegisterBackButtonClicked(object sender, RoutedEventArgs e)
        {
            //Go back to the login page. 
            if(this.NavigationService.CanGoBack)
            {
                this.NavigationService.GoBack();
            }
        }
    }
}
