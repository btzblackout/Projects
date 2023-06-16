using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockMarketSim
{
    public partial class Form2 : Form
    {
        Company company;
        public Form2(Company company)
        {
            this.company = company;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label7.Text = company.Name;
            label8.Text = company.Symbol;
            label9.Text = company.Change.ToString();
            label10.Text = company.PercentChange.ToString();
            label12.Text = company.Volume.ToString();
        }
    }
}
