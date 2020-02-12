using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtInvestment.Text);
            decimal yearlyInterest = Convert.ToDecimal(txtInterest.Text);
            int years = Convert.ToInt32(txtYears.Text);
            decimal value = 0m;

            int numMonths = years * 12;
            decimal monthlyInterest = yearlyInterest / 12 / 100;

            for (int i = 0; i < numMonths; i++)
            {
                value = (value + monthlyInvestment) * (1 + monthlyInterest);
            }

            txtValue.Text = value.ToString("c");
            txtInvestment.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
