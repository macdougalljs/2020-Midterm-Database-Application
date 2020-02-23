using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MTJeremiahMacDougall
{
    public partial class FormMidTermExam : Form
    {
        private List<Invoice> invoices;
        public FormMidTermExam()
        {
            InitializeComponent();
            invoices = new List<Invoice> {
            new Invoice(83,"Electric Sander",7, 57.98),
            new Invoice(24,"Power saw",18, 99.99),
            new Invoice(7,"Sledge hammer",11, 21.50),
            new Invoice(77,"Hammer",76, 11.99),
            new Invoice(39,"Lawn mower",3, 79.50),
            new Invoice(68,"Screw driver",106, 6.99),
            new Invoice(56,"Jig saw",21, 11.00),
            new Invoice(3,"Wrench",34, 7.50)
            };
        }

        private void FormMidTermExam_Load(object sender, EventArgs e)
        {
            lblRowsFetched.Text = "";
        }

        private void btnShowAllTools_Click(object sender, EventArgs e)
        {
            var allInv = from inv in invoices
                         select inv;

            // show all of the invoices

            DisplayInvoices(allInv);
        }

        private void DisplayInvoices(IEnumerable<Invoice> invoice)
        {
            // clear the labels otherwise it'll get re added every time

            lblPartNumber.Text = lblDescription.Text = lblQuantity.Text = lblPrice.Text = lblInvoiceTotal.Text = "";


            if (invoice.Any())
            {
                foreach (var invs in invoice)
                {

                    lblPartNumber.Text += invs.PartNumber + "\n";
                    lblDescription.Text += invs.PartDescription + "\n";
                    lblQuantity.Text += invs.Quantity.ToString() + "\n";
                    lblPrice.Text += invs.Price.ToString("C") + "\n";
                    lblInvoiceTotal.Text += (invs.Quantity * invs.Price).ToString("C") + "\n";

                }  // close for loop
                if (invoice.Count() == 1)
                    lblRowsFetched.Text = "1 row fetched.";
                else
                    lblRowsFetched.Text = invoice.Count() + " rows fetched.";
            } // close if any
            else
                lblRowsFetched.Text = "0 rows fetched.";

        }

        private void FormMidTermExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            // display the message box
            DialogResult result = MessageBox.Show("Do you really want to exit?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if NO is clicked, cancel the "Closing" event
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSortByPartDesc_Click(object sender, EventArgs e)
        {
            var allInv = from inv in invoices
                         orderby inv.PartDescription
                         select inv;

            // sort by description

            DisplayInvoices(allInv);
        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            var allInv = from inv in invoices
                         orderby inv.Price
                         select inv;

            // sort by price

            DisplayInvoices(allInv);
        }

        private void btnQtyRange10And40_Click(object sender, EventArgs e)
        {
            var allInv = from inv in invoices
                         where inv.Quantity >= 10 && inv.Quantity
                          <= 40
                         orderby inv.Quantity
                         select inv;

            // sort by price

            DisplayInvoices(allInv);
        }

        private void btnWherePartNo_Click(object sender, EventArgs e)
        {
            var allInv = from inv in invoices
                         where inv.PartNumber == numUserSelection.Value
                         select inv;

            // select the part number that user selected


            DisplayInvoices(allInv.Distinct());
        }
    }
}

