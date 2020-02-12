using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dtpArrival.MinDate = DateTime.Today;
            dtpDeparture.MinDate = DateTime.Today.AddDays(1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime arrival = dtpArrival.Value;
            DateTime departure = dtpDeparture.Value;

            TimeSpan elapsedTime = departure - arrival;

            int numDays = elapsedTime.Days + 1;

            if (numDays < 1)
            {
                MessageBox.Show("Departure Date can't be before Arrival Date", "Date Error");
            }
            else
            {
                int cost;

                if(arrival.DayOfWeek == DayOfWeek.Friday ||
                    arrival.DayOfWeek == DayOfWeek.Saturday)
                {
                    cost = 120;
                }
                else
                {
                    cost = 250;
                }

                txtNumNights.Text = numDays.ToString();
                txtTotalPrice.Text = "$" + (cost * numDays);
                txtAvgPrice.Text = "$" + cost;
            }
        }
    }
}
