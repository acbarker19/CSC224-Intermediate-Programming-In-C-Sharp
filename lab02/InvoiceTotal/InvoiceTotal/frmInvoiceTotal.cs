using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
	public partial class frmInvoiceTotal : Form
	{
        int numInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceAvg = 0m;
        decimal largest = Decimal.MinValue;
        decimal smallest = Decimal.MaxValue;

        public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Decimal.Parse(txtEnterSubtotal.Text);
			decimal discountPercent = .25m;
			decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
			decimal invoiceTotal = Math.Round(subtotal - discountAmount, 2);

            txtSubtotal.Text = subtotal.ToString("c");
			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString();
			txtTotal.Text = invoiceTotal.ToString();

            numInvoices++;
            totalOfInvoices += invoiceTotal;
            invoiceAvg = totalOfInvoices / numInvoices;
            largest = Math.Max(largest, invoiceTotal);
            smallest = Math.Min(smallest, invoiceTotal);

            txtNumInvoices.Text = numInvoices.ToString();
            txtTotalInvoices.Text = totalOfInvoices.ToString("c");
            txtInvoiceAvg.Text = invoiceAvg.ToString("c");
            txtLargest.Text = largest.ToString("c");
            txtSmallest.Text = smallest.ToString("c");

            txtEnterSubtotal.Text = "";
			txtEnterSubtotal.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void btnClear_Click(object sender, EventArgs e)
        {
            numInvoices = 0;
            totalOfInvoices = 0m;
            invoiceAvg = 0m;
            largest = Decimal.MinValue;
            smallest = Decimal.MaxValue;

            txtNumInvoices.Text = "";
            txtTotalInvoices.Text = "";
            txtInvoiceAvg.Text = "";
            txtLargest.Text = "";
            txtSmallest.Text = "";

            txtEnterSubtotal.Focus();
        }
    }
}