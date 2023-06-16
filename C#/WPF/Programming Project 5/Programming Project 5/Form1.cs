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
    public partial class LuckyNumbers : Form
    {
        List<int> birthYearList = new List<int>();
        List<string> birthMonthList = new List<string>();
        List<int> daysOfTheMonthList = new List<int>();
        List<string> colorList = new List<string>();
        int maxDays;
        public LuckyNumbers()
        {
            InitializeComponent();
            for (int i = 0; i <= 60; i++)
            {
                birthYearList.Add(2020 - i);
            }
            birthMonthList.Add("January");
            birthMonthList.Add("February");
            birthMonthList.Add("March");
            birthMonthList.Add("April");
            birthMonthList.Add("May");
            birthMonthList.Add("June");
            birthMonthList.Add("July");
            birthMonthList.Add("August");
            birthMonthList.Add("September");
            birthMonthList.Add("October");
            birthMonthList.Add("November");
            birthMonthList.Add("December");
            colorList.Add("Blue");
            colorList.Add("Red");
            colorList.Add("Yellow");
            colorList.Add("Black");
            colorList.Add("Grey");
            colorList.Add("Green");
            colorList.Add("Purple");
            colorList.Add("Pink");
            colorList.Add("White");
            colorList.Add("Brown");

            BirthYearComboBox.DataSource = birthYearList;
            BirthMonthComboBox.DataSource = birthMonthList;
            FavoriteColorComboBox.DataSource = colorList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            Results res = new Results();
            res.Show();
        }

        private void BirthMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BirthMonthComboBox.SelectedValue != null && BirthYearComboBox.SelectedValue != null)
            {
                SetDayComboBox(BirthMonthComboBox.Text, Int32.Parse(BirthYearComboBox.Text));
            }
            
        }

        private void BirthYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BirthMonthComboBox.SelectedValue != null && BirthYearComboBox.SelectedValue != null)
            {
                SetDayComboBox(BirthMonthComboBox.Text, Int32.Parse(BirthYearComboBox.Text));
            }
        }

        private void SetDayComboBox(string selectedMonth, int selectedYear)
        {
            BirthDayComboBox.DataSource = null;
            daysOfTheMonthList.Clear();
            switch (selectedMonth)
            {
                case "January":
                    {
                        maxDays = 31;
                        break;
                    }
                case "February":
                    {
                        //Checks if the year is a leap year.
                        if(selectedYear % 4 == 0)
                        {
                            maxDays = 29;
                        }
                        else
                        {
                            maxDays = 28;
                        }
                        break;
                    }
                case "March":
                    {
                        maxDays = 31;
                        break;
                    }
                case "April":
                    {
                        maxDays = 30;
                        break;
                    }
                case "May":
                    {
                        maxDays = 31;
                        break;
                    }
                case "June":
                    {
                        maxDays = 30;
                        break;
                    }
                case "July":
                    {
                        maxDays = 31;
                        break;
                    }
                case "August":
                    {
                        maxDays = 31;
                        break;
                    }
                case "September":
                    {
                        maxDays = 30;
                        break;
                    }
                case "October":
                    {
                        maxDays = 31;
                        break;
                    }
                case "November":
                    {
                        maxDays = 30;
                        break;
                    }
                case "December":
                    {
                        maxDays = 31;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("There was an error!");
                        break;
                    }
                   
            }
            for(int i = 1; i <= maxDays; i++)
            {
                daysOfTheMonthList.Add(i);
            }
            BirthDayComboBox.DataSource = daysOfTheMonthList;
            

        }

        private void FavoriteColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
