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
    public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void btnInvestment_Click(object sender, EventArgs e)
		{
			frmInvestment form = new frmInvestment();
			form.Show();
		}

		private void btnDepreciation_Click(object sender, EventArgs e)
		{
			frmDepreciation form = new frmDepreciation();
			form.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}