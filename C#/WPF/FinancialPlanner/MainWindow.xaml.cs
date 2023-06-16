/*  
 * MainWindow.xaml.cs
 * Author: Raymond Lawson
 */
using FinancialPlanner.View.Pages;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace FinancialPlanner
{
    public partial class MainWindow : Window
    {
        //Constructor.
        public MainWindow()
        {
            InitializeComponent();
            //Set the Login page to be displayed. 
            Main.Content = new Login();

            NavigationCommands.BrowseBack.InputGestures.Clear();
            NavigationCommands.BrowseForward.InputGestures.Clear();
        }


    }
}
