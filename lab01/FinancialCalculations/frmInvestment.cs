using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCalculations
{
    public partial class frmInvestment : Form
	{
		public frmInvestment()
		{
			InitializeComponent();
		}

		private void rdoFutureValue_CheckedChanged(object sender, EventArgs e)
		{
			// make Future Value text box read-only
			txtFutureValue.ReadOnly = true;
			txtFutureValue.TabStop = false;

			// make Monthly Investment text box read-write
			txtMonthlyInvestment.ReadOnly = false;
			txtMonthlyInvestment.TabStop = true;

			this.ClearControls();
			txtMonthlyInvestment.Focus();
		}

		private void rdoMonthlyInvestment_CheckedChanged(object sender, EventArgs e)
		{
			// make Monthly Investment text box read-only
			txtMonthlyInvestment.ReadOnly = true;
			txtMonthlyInvestment.TabStop = false;

			// make Future Value text box read-write
			txtFutureValue.ReadOnly = false;
			txtFutureValue.TabStop = true;

			this.ClearControls();
			txtInterestRate.Focus();
		}

		private void ClearControls()
		{
			txtMonthlyInvestment.Text = "";
			txtInterestRate.Text = "";
			txtYears.Text = "";
			txtFutureValue.Text = "";
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			try
			{
				// get the monthly interest rate
				decimal yearlyInterestRate =
					Convert.ToDecimal(txtInterestRate.Text);
				decimal monthlyInterestRate =
					yearlyInterestRate / 12 / 100;

				// get the number of months
				int years = Convert.ToInt32(txtYears.Text);
				int months = years * 12;

				if (rdoFutureValue.Checked) // future value
				{
					decimal monthlyInvestment =
						Convert.ToDecimal(
							txtMonthlyInvestment.Text);
					decimal futureValue =
						Calculations.CalculateFutureValue(
							monthlyInvestment,
							monthlyInterestRate,
							months);
					txtFutureValue.Text =
						String.Format("{0:c}", futureValue);
				}
				else // monthly investment
				{
					decimal futureValue =
						Convert.ToDecimal(txtFutureValue.Text);
					decimal monthlyInvestment =
						Calculations.CalculateMonthlyInvestment(
							futureValue,
							monthlyInterestRate,
							months);
					txtMonthlyInvestment.Text =
						String.Format("{0:c}", monthlyInvestment);
				}
			}
			catch (OverflowException)
			{
				MessageBox.Show("OverflowException. Try using smaller numbers.", "Entry Error");
			}
			catch (FormatException)
			{
				MessageBox.Show("All entries must be numeric.", "Entry Error");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace + ": " + ex.Message, "Unknown Exception");
			}

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}