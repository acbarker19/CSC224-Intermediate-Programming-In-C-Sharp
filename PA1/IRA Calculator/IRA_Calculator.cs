/******************************
 * CSC 224
 * Programming Assignment # 1
 * Author:  Alec Barker
 * Date:  January 16, 2020
 ******************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRA_Calculator
{
    public partial class IRA_Calculator : Form
    {
        public IRA_Calculator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            String output = "";

            if (txtName.Text.Equals("") ||
                txtAge.Text.Equals("") ||
                txtRetirement.Text.Equals("") ||
                txtInvestment.Text.Equals("") ||
                txtInterest.Text.Equals(""))
            {
                output = "PLEASE ENTER ALL INFORMATION";
            }
            else
            {
                try
                {
                    decimal interestRate = Convert.ToDecimal(txtInterest.Text);
                    int retirementAge = Convert.ToInt32(txtRetirement.Text);
                    DateTime current = DateTime.Now;
                    int year = current.Year;
                    int currentAge = Convert.ToInt32(txtAge.Text);
                    decimal beginningBalance = 0.0m;
                    decimal investment = Convert.ToDecimal(txtInvestment.Text);
                    decimal interestEarned = 0.0m;
                    decimal endingBalance = investment;
                    decimal totalInvestment = 0.0m;

                    if (currentAge > retirementAge)
                    {
                        output = "CURRENT AGE MUST BE LESS THAN PLANNED RETIREMENT AGE";
                    }
                    else
                    {
                        output = "IRA Summary Projection for " + txtName.Text + "\r\n\r\nFixed Annual Investment: " +
                            String.Format("{0," + txtInvestment.Text.Length + ":$##,###,##0.00}", investment) +
                            "\tAnnual Interest Rate: " + String.Format("{0,7:##0.00%}", interestRate) + "\r\n\r\n" +
                            "       \t   \t     Beginning\t        Annual\t      Interest\t        Ending\r\n" +
                            "   Year\tAge\t       Balance\t    Investment\t        Earned\t       Balance\r\n" +
                            "   ----\t---\t     ---------\t    ----------\t      --------\t       -------";

                        while (currentAge <= retirementAge)
                        {
                            output += "\r\n   " + year +
                                "\t" + currentAge +
                                "\t" + String.Format("{0,14:$##,###,##0.00}", beginningBalance) +
                                "\t" + String.Format("{0,14:$##,###,##0.00}", investment) +
                                "\t" + String.Format("{0,14:$##,###,##0.00}", interestEarned) +
                                "\t" + String.Format("{0,14:$##,###,##0.00}", endingBalance);

                            currentAge++;
                            year++;
                            beginningBalance = endingBalance;
                            interestEarned = beginningBalance * interestRate;

                            if (currentAge <= retirementAge)
                            {
                                endingBalance = beginningBalance + investment + interestEarned;
                            }

                            totalInvestment += investment;
                        }

                        output += "\r\n\t\tACCOUNT TOTALS: " + String.Format("{0,14:$##,###,##0.00}", totalInvestment) +
                            "\t" + String.Format("{0,14:$##,###,##0.00}", endingBalance - totalInvestment);
                    }
                }
                catch (FormatException)
                {
                    output = "PLEASE INPUT ONLY NUMBER VALUES IN THE FOLLOWING FIELDS:\r\n" +
                        "CURRENT AGE, PLANNED RETIREMENT AGE, FIXED ANNUAL INVESTMENT, AND INTEREST RATE";
                }
                
            }

            txtOutput.Text = output;
        }
    }
}
