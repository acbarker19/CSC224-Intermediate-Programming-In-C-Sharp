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
    public partial class frmDepreciation : Form
	{
		public frmDepreciation()
		{
			InitializeComponent();
		}

        private void frmDepreciation_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                cboLife.Items.Add(i);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (IsValidEntry(txtInitialCost.Text, 500, 1000000))
			{
				double cost = Convert.ToDouble(txtInitialCost.Text);

				if (IsValidEntry(txtFinalValue.Text, 0, cost))
				{
					double salvage = Convert.ToDouble(txtFinalValue.Text);

					if (cboLife.SelectedIndex != -1)
					{
						lstDepreciation.Items.Clear();
						int life = Convert.ToInt32(cboLife.Text);
						double dLife = (double)life;

						for (int i = 1; i <= life; i++)
						{
							double period = (double)i;
							// there's no SYD function available in C#
							// so I created one in the Calculations class
							double yearlyAllowance =
								Calculations.CalculateSYDDepreciation(
									cost, salvage, dLife, period);
							lstDepreciation.Items.Add(
								"Year " + i + ": " +
								String.Format("{0:c}", yearlyAllowance));
						}
						txtInitialCost.Focus();
					}
					else
						MessageBox.Show("You must select a value "
							+ "for the asset life.", "Entry Error");
				}
				else
					MessageBox.Show("Final value must be a number "
						+ "between 0 and the initial cost.",
						"Entry Error");
			}
			else
			{
				MessageBox.Show("Initial cost must be a number "
					+ "between 500 and 1,000,000", "Entry Error");
			}
		}

		private bool IsValidEntry(string s, double min, double max)
		{
			try
			{
				double x = Convert.ToDouble(s);
				if (x >= min && x <= max)
					return true;
				else
					return false;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		private bool IsValidEntry(string s, int min, int max)
		{
			try
			{
				int x = Convert.ToInt32(s);
				if (x >= min && x <= max)
					return true;
				else
					return false;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}