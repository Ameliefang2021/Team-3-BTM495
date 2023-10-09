using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_1
{
    public class Invoice
    {
        private int invoiceID;
        private double total;
        private double balance;
        private DateTime dateIssued;
        private DateTime dateDue;

        public int InvoiceID
        {
            get { return invoiceID; }
            set { invoiceID = value; }
        }

        public double Total
        {
            get { return Total; }
            set { Total = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public DateTime DateIssued
        {
            get { return dateIssued; }
            set { dateIssued = value; }
        }

        public DateTime DateDue
        {
            get { return dateDue; }
            set { dateDue = value; }
        }

        public Invoice() { }

        public Invoice(int iID, double t, double bal, DateTime dI, DateTime dD)
        {
            InvoiceID = iID;
            Total = t;
            Balance = bal;
            DateIssued = dI;
            DateDue = dD;
        }
    }
}
