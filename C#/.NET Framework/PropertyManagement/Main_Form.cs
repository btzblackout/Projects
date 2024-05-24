using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyManagement.Models;
using Syncfusion.Windows.Forms;

namespace PropertyManagement
{
    public partial class Main_Form : MetroForm
    {
        User user = new User();
        PayRentUserControl payRentUserControl = new PayRentUserControl();
        public Main_Form(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
        }

        private void button_Pay_Rent_CheckedChanged(Object sender, EventArgs e)
        {
            if(button_Pay_Rent.Checked)
            {
                panel_Content.Controls.Clear();
                panel_Content.Controls.Add(payRentUserControl);
                payRentUserControl.Dock = DockStyle.Fill;

                

            }
        }
    }
}
