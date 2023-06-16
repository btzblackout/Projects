using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinancialPlanner.View.UserControls;
using FinancialPlanner.Models;

namespace FinancialPlanner.View.Pages
{
    /// <summary>
    /// Interaction logic for Finances.xaml
    /// </summary>
    public partial class Finances : Page
    {
        private MonthTab PreviouslyActiveTab;
        private TextBlock ActivePaySchedule;

        private List<Bill> bills = new List<Bill>();






        public Finances()
        {

            InitializeComponent();
            bills.Add(new Bill("Rent", 1, 410, true, "Mays Rent", "May"));
            ActivePaySchedule = BiWeekly;
            PreviouslyActiveTab = January;
            January.Active(true);
            MonthLabel.Text = January.Name;
            SetActivePaySchedule(BiWeekly);
            BillsDataGrid.ItemsSource = bills;
            

        }

        private void ChangeBackground(MonthTab monthTab)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString(monthTab.Fill);
            BackgroundOne.Fill = brush;
            BackgroundTwo.Fill = brush;
            PreviouslyActiveTab.Active(false);
            PreviouslyActiveTab = monthTab;
            monthTab.Active(true);
            MonthLabel.Text = monthTab.Name;


        }

        private void SetActivePaySchedule(TextBlock textBlock)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("Transparent");
            ActivePaySchedule.Background = brush;

            ActivePaySchedule = textBlock;
            ActivePaySchedule.Background = (Brush)converter.ConvertFromString("DarkGray");
            FineTuneDisplay(textBlock);
            CalculateIncome();

        }

        private void FineTuneDisplay(TextBlock textBlock)
        {
            PaycheckTwo.Visibility = Visibility.Hidden;
            PaycheckThree.Visibility = Visibility.Hidden;
            PaycheckFour.Visibility = Visibility.Hidden;
            switch (textBlock.Name)
            {
                case "Weekly":
                    {
                        PaycheckTwo.Visibility = Visibility.Visible;
                        PaycheckThree.Visibility = Visibility.Visible;
                        PaycheckFour.Visibility = Visibility.Visible;
                        break;
                    }
                case "BiWeekly":
                    {
                        PaycheckTwo.Visibility = Visibility.Visible;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void CalculateIncome()
        {
            int income = 0;
            if (!string.IsNullOrEmpty(PaycheckOneTextBox.Text))
            {
                income = Int32.Parse(PaycheckOneTextBox.Text);
            }
            if(PaycheckTwo.Visibility == Visibility.Visible && !string.IsNullOrEmpty(PaycheckTwoTextBox.Text))
            {
                income += Int32.Parse(PaycheckTwoTextBox.Text);
            }
            if (PaycheckThree.Visibility == Visibility.Visible && !string.IsNullOrEmpty(PaycheckThreeTextBox.Text))
            {
                income += Int32.Parse(PaycheckThreeTextBox.Text);
            }
            if (PaycheckFour.Visibility == Visibility.Visible && !string.IsNullOrEmpty(PaycheckFourTextBox.Text))
            {
                income += Int32.Parse(PaycheckFourTextBox.Text);
            }

            TotalIncome.Text = income.ToString();
        }

        private void JanTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);

        }

        private void FebTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        

        private void MarTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void AprTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void MayTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void JunTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void JulTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void AugTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void SepTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void OctTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void NovTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void DecTabClicked(object sender, MouseButtonEventArgs e)
        {
            ChangeBackground((MonthTab)sender);
        }

        private void WeeklyPayClicked(object sender, MouseButtonEventArgs e)
        {
            SetActivePaySchedule((TextBlock)sender);
        }

        private void BiWeeklyPayClicked(object sender, MouseButtonEventArgs e)
        {
            SetActivePaySchedule((TextBlock)sender);
        }

        private void MonthlyPayClicked(object sender, MouseButtonEventArgs e)
        {
            SetActivePaySchedule((TextBlock)sender);
        }

        private void IncomeTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox temp = (TextBox)sender;
            PaycheckOneTextBox.Text = temp.Text;
            PaycheckTwoTextBox.Text = temp.Text;
            PaycheckThreeTextBox.Text = temp.Text;
            PaycheckFourTextBox.Text = temp.Text;
        }

        private void PaycheckOneTextChanged(object sender, TextChangedEventArgs e)
        {
            CalculateIncome();
        }

        private void PaycheckTwoTextChanged(object sender, TextChangedEventArgs e)
        {
            CalculateIncome();
        }

        private void PaycheckThreeTextChanged(object sender, TextChangedEventArgs e)
        {
            CalculateIncome();
        }

        private void PaycheckFourTextChanged(object sender, TextChangedEventArgs e)
        {
            CalculateIncome();
        }

        private void NewBillAdded(object sender, DataGridRowEditEndingEventArgs e)
        {
            //Add the item to the database! 
        }
    }
}
