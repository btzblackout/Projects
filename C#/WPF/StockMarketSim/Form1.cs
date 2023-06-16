using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarketSim
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Company company;
        List<Company> companyList = new List<Company>();
        
        public Form1()
        {
            InitializeComponent();
            companyList.Add(new Company("Tesla", "TSLA", 199.23m, 8.24m, 3.97f, 63.647, 'M', 628.55, 'B', 34125123));
            companyList.Add(new Company("Company2", "C2", 12.13m, 1.85m, 6, 180, 'M', 250, 'M', 3425181));
            companyList.Add(new Company("Company3", "C3", 20.10m, 2.45m, 0.5f, 150, 'M', 170, 'M', 521489));
            companyList.Add(new Company("Company4", "C4", 39.20m, 1.48m, 1.2f, 190, 'M', 200, 'M', 6148125));
            companyList.Add(new Company("Company5", "C5", 16.37m, 1.98m, 1.15f, 200, 'M', 260, 'M', 7815185));
            companyList.Add(new Company("Company6", "C6", 65.15m, 2.04m, 2.15f, 146, 'M', 150, 'M', 6845351));
            companyList.Add(new Company("Company7", "C7", 78.02m, 3.28m, 1.84f, 167, 'M', 170, 'M', 1298158));

            listBox1.MultiColumn = true;
            listBox1.DataSource = companyList;
            listBox1.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2((Company)listBox1.SelectedItem);
            form2.Show();
        }
    }
}
