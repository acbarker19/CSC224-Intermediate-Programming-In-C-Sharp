/******************************
 * CSC 224
 * Programming Assignment # 2
 * Author:  Alec Barker
 * Date:  January 23, 2020
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

namespace PA2
{
    public partial class Form1 : Form
    {
        private string[] monthNames = {"January", "February", "March", "April", "May", "June",
                              "July", "August", "September", "October", "November", "December"};

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetUp_Click(object sender, EventArgs e)
        {
            string defaultString = null;

            foreach(string month in monthNames)
            {
                defaultString += month + ": ";

                if(month != "December")
                {
                    defaultString += "\r\n";
                }
            }

            txtInput.Text = defaultString;
            txtOutput.Text = "";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string output = null;
            string month = null;
            int sales = 0;
            string[] monthData = txtInput.Text.Split("\n".ToCharArray());
            Boolean sizeIsLimited = false;
            Boolean numsArePositive = true;
            Boolean containsMonths = true;

            try
            {
                foreach (string line in monthData)
                {
                    month = line.Substring(0, line.IndexOf(":"));
                    output += month;
                    output += String.Concat(Enumerable.Repeat(" ", (9 - month.Length)));
                    output += "|";
                    sales = Convert.ToInt32(line.Substring(line.IndexOf(" ")));

                    if (!monthNames.Contains(month))
                    {
                        output = "Months must be entered, not other types of data.";
                        containsMonths = false;
                        break;
                    }

                    if (sales < 0)
                    {
                        output = "Number of sales must be positive.";
                        numsArePositive = false;
                        break;
                    }

                    for (int i = 0; i < sales; i++)
                    {
                        if (i < 50)
                        {
                            output += "*";
                        }
                        else
                        {
                            sizeIsLimited = true;
                            break;
                        }
                    }

                    output += "(" + sales + ")\r\n";
                }

                if (numsArePositive && containsMonths)
                {
                    output += "         +";

                    for (int i = 0; i < 50; i++)
                    {
                        output += "=";
                    }

                    output += "\r\n         0    5    1    1    2    2    3    3    4    4    5";
                    output += "\r\n                   0    5    0    5    0    5    0    5    0";

                    if (sizeIsLimited)
                    {
                        output += "\r\n\r\nThe number of *s displayed for some values on the graph have been limited to only display 50, " +
                            "but their actual values have been listed.";
                    }
                }
            }
            catch
            {
                output = "There was an error processing the input data. Please try again with the correct format.";
            }

            txtOutput.Text = output;
        }
    }
}
