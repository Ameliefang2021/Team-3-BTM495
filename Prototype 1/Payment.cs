using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Payment
    {
        private double amount;
        private DateTime date;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Payment() { }

        public Payment(double a, DateTime d)
        {
            Amount = a;
            Date = d;
        }
    }
}
