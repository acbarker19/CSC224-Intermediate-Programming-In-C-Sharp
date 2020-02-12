/******************************
 * CSC 224
 * Programming Assignment # 3
 * Author:  Alec Barker
 * Date:  February 11, 2020
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
using System.IO;

namespace PA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\textFiles";
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;

                txtInput.Text = fileName;
                txtInput.Focus();
                txtInput.SelectionStart = fileName.Length;
                txtInput.SelectionLength = 0;

                int dotPosition = fileName.IndexOf(".");
                string fileNameNoExtension = fileName.Substring(0, dotPosition);
                
                txtOutput.Text = fileNameNoExtension + ".out";
                txtOutput.SelectionStart = fileName.Length;
                txtOutput.SelectionLength = 0;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string inputPath = txtInput.Text;
            string outputPath = txtOutput.Text;
            FileStream fsInput = null;
            FileStream fsOutput = null;

            try
            {
                fsInput = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
                fsOutput = new FileStream(outputPath, FileMode.Create, FileAccess.Write);
                StreamReader textIn = new StreamReader(fsInput);
                StreamWriter textOut = new StreamWriter(fsOutput);

                string output = "CSC 224 - Program # 3\r\n" +
                    "Credit Card Account Summary for: Alec Barker\r\n\r\n" +
                    "\t  Date    Description                       Amount      Balance\r\n" +
                    "\t--------  ------------------------------  ----------  ----------\r\n" +
                    "\t          Beginning Balance . . . . . . . . . . . . . $     0.00\r\n";                
                string theLine = null;
                string date = null;
                string description = null;
                decimal cost = decimal.Zero;
                string vendor = null;

                decimal balance = decimal.Zero;
                decimal totalPayments = decimal.Zero;
                decimal totalPurchases = decimal.Zero;

                decimal[] vendorAmounts = new decimal[20];
                
                while (textIn.Peek() != -1)
                {
                    theLine = textIn.ReadLine();

                    date = theLine.Substring(0, 8);
                    description = theLine.Substring(8, 30);
                    cost = Convert.ToDecimal(theLine.Substring(38, theLine.IndexOf(".") + 3 - 38).Trim());
                    vendor = theLine.Substring(48);

                    balance += cost;

                    if (cost < 0)
                    {
                        totalPayments += cost * -1;
                    }

                    if (vendor != "xx")
                    {
                        vendorAmounts[Convert.ToInt32(vendor.Trim())] += cost;
                    }

                    output += "\t" + date + "  " + description + "  " + string.Format("{0, 10:######0.00}", cost) +
                        "  " + string.Format("{0, 10:######0.00}", balance) + "\r\n";
                }

                output += "\t--------  ------------------------------  ----------  ----------\r\n" +
                    "Total Purchases from each vendor:             Total Payments: "
                    + string.Format("{0, 10:######0.00}", totalPayments) +
                    "\r\n\r\n\tVendor #  Amount Purchased\r\n" +
                    "\t--------  ----------------\r\n";

                for (int i = 0; i < vendorAmounts.Length; i++)
                {
                    if (vendorAmounts[i] != 0)
                    {
                        output += "\t      " + string.Format("{0, 2:#0}", i) + "  " +
                            string.Format("{0, 16:############0.00}", vendorAmounts[i]) + "\r\n";
                        totalPurchases += vendorAmounts[i];
                    }
                }

                output += "\r\n\t   Total  " + string.Format("{0, 16:############0.00}", totalPurchases);

                textOut.Write(output);
                textOut.Flush();

                MessageBox.Show("The input file was successfully formatted and sent to the output file.",
                    "Formatting Complete");

                txtInput.Text = "";
                txtInput.Focus();
                txtOutput.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Reading Error");
            }
            finally
            {
                if (fsInput != null)
                {
                    fsInput.Close();
                }

                if (fsOutput != null)
                {
                    fsOutput.Close();
                }
            }
        }
    }
}
