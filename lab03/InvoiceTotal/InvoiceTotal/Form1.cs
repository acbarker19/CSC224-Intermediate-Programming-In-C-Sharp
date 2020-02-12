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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string customerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = .0m;
        /*
            if (customerType.ToUpper() == "R")
            {
                if (subtotal < 100)
                    discountPercent = .0m;
                else if (subtotal >= 100 && subtotal < 250)
                    discountPercent = .1m;
                else if (subtotal >= 250 && subtotal < 500)
                    discountPercent = .25m;
                else if (subtotal >= 500)
                    discountPercent = .3m;
            }
            else if (customerType.ToUpper() == "C")
            {
                discountPercent = .2m;
            }
            else if (customerType.ToUpper() == "T")
            {
                if (subtotal < 500)
                    discountPercent = .4m;
                else if (subtotal >= 500)
                    discountPercent = .5m;
            }
            else
            {
                discountPercent = .1m;
            }
        */

            switch (customerType.ToUpper())
            {
                case "R":
                    if (subtotal < 100)
                        discountPercent = .0m;
                    else if (subtotal >= 100 && subtotal < 250)
                        discountPercent = .1m;
                    else if (subtotal >= 250 && subtotal < 500)
                        discountPercent = .25m;
                    else if (subtotal >= 500)
                        discountPercent = .3m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                case "T":
                    if (subtotal < 500)
                        discountPercent = .4m;
                    else if (subtotal >= 500)
                        discountPercent = .5m;
                    break;
                default:
                    discountPercent = .1m;
                    break;
            }

            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            txtCustomerType.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}