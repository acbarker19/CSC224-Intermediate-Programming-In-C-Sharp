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
		public frmInvoiceTotal()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
            try
            {
                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show("Subtotal is a required field.", "Entry Error");
                }
                else
                {
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);

                    if (subtotal <= 0 || subtotal >= 10000)
                    {
                        MessageBox.Show("Subtotals must be between 1 and 9,999.", "Entry Error");
                    }
                    else
                    {
                        decimal discountPercent = .25m;
                        decimal discountAmount = subtotal * discountPercent;
                        decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString();
                        txtTotal.Text = invoiceTotal.ToString();

                        txtSubtotal.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number for the Subtotal field.", "Entry Error");
            }
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}