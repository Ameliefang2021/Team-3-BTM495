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

        private double unitCost;
        private Accountant accountant;
        private Client client;

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

        public double UnitCost { get => unitCost; set => unitCost = value; }
        public Accountant Accountant { get => accountant; set => accountant = value; }
        public Client Client { get => client; set => client = value; }

        public Invoice() { }

        public Invoice(int iID, double t, double bal, DateTime dI, DateTime dD)
        {
            InvoiceID = iID;
            Total = t;
            Balance = bal;
            DateIssued = dI;
            DateDue = dD;
        }

        public Invoice GetInvoiceByID(int invoiceid)
        {
            return new Invoice(invoiceID);
        }

        public double CalPrice(double unitCost,int quantity) {
            return unitCost * quantity;
        }


    }
}
