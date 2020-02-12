using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        DateTime today = DateTime.Today;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            DateTime future = Convert.ToDateTime(txtFutureDate.Text);
            TimeSpan daysUntilDue = future - today;

            MessageBox.Show("Current Date:\t" + today.ToShortDateString() +
                "\r\nFuture Date:\t" + future.ToShortDateString() +
                "\r\nDays Until Due:\t" + daysUntilDue.TotalDays,
                "Due Days Calculation");
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            DateTime birthDate = Convert.ToDateTime(txtBirthDate.Text);
            TimeSpan daysFromBirthDate = today - birthDate;

            MessageBox.Show("Current Date:\t" + today.ToShortDateString() +
                "\r\nBirth Date:\t" + birthDate.ToShortDateString() +
                "\r\nAge:\t" + Math.Floor(daysFromBirthDate.TotalDays/365),
                "Age Calculation");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}