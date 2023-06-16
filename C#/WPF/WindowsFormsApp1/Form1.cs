using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form2 form2 = null;
        List<Company> companyList = new List<Company>();
        Company company = new Company();
        public Form1()
        {
            InitializeComponent();
            companyList.Add(new Company("Microsoft", "MSFT", 227.87m, 6.48m, '+', 2.93f, 33.497, 'M', 1.699, 'T', 38715113, 'M'));
            companyList.Add(new Company("Netflix", "NFLX", 258.60m, 2.19m, '-', 0.84f, 7.927, 'M', 115.082, 'B', 29760205, 'M'));
            companyList.Add(new Company("Meta Platforms, Inc.", "META", 96.72m, 5.93m, '+', 6.53f, 80.179209, 'M', 256.458, 'B', 24804618, 'M'));
            marketTable.DataSource = companyList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);

                form2.Show(this);
            }
            else
                form2.BringToFront();
        }
        void Form2_FormClosed(object sender, EventArgs e)
        {
            form2 = null;
        }
    }
}
