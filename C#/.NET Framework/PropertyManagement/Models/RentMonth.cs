using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.Models
{
    class RentMonth
    {
        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private decimal paymentAmount;

        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        private decimal principal;

        public decimal Principal
        {
            get { return principal; }
            set { principal = value; }
        }

        private decimal interest;

        public decimal Interset
        {
            get { return interest; }
            set { interest = value; }
        }



    }
}
