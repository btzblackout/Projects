/*  
 * Login.xaml.cs
 * Author: Raymond Lawson
 */
using FinancialPlanner.Database;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace FinancialPlanner.View.Pages
{
    public partial class Login : Page
    {
        //Declare variables.
        string username, password;

        //Constructor.
        public Login()
        {
            InitializeComponent();
        }

        //Register button is clicked.
        private void RegisterButtonClicked(object sender, RoutedEventArgs e)
        {
            //Clear the text boxes on this page for when the user returns.
            UsernameLoginTextBox.Text = "";
            PasswordLoginTextBox.Text = "";
            //Create the Register page and set it to the Frame control.
            MainWindow mw = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mw.Main.Content = new Register();
        }

        //Login button is clicked.
        private void LoginButtonClicked(object sender, RoutedEventArgs e)
        {
            //Set variables.
            username = UsernameLoginTextBox.Text;
            password = PasswordLoginTextBox.Text;

            //Create an instance of the DBManager class
            UserDBManager dbmanager = new UserDBManager(username, password);

            //Check if the user exists, ("with") is for username + password check.
            if(dbmanager.CheckIfUserExists("with"))
            {
                //Create the Finances page and set it to the Frame control.
                MainWindow mw = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                mw.Main.Content = new Finances();
            }
            else
            {
                MessageBox.Show("Your login credentials are invalid.");
            }
        }
    }
}
