/******************************
 * CSC 224
 * Programming Assignment # 4
 * Author:  Alec Barker
 * Date:  February 18, 2020
 ******************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4
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
            fileDialog.InitialDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\TextFiles";
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

        private void btnSave_Click(object sender, EventArgs e)
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

                string output = "CSC 224 - Program # 4\r\n" +
                    "Written by: Alec Barker\r\n\r\n";
                string theLine;
                int totalCustomers = 0;
                decimal totalDue = 0.0m;

                string currentState = null;
                int currentStateCustomers = 0;
                decimal currentStateTotalDue = 0.0m;
                
                while (textIn.Peek() != -1)
                {
                    theLine = textIn.ReadLine();
                    string[] data = theLine.Split(';');

                    decimal customerBalance = 0.0m;

                    if (data[0] != currentState)
                    {
                        if (currentState != null)
                        {
                            output += "\r\n\tNumber of customers from " + currentState + ": " +
                                currentStateCustomers + "  (total due from " + currentState +
                                " customers: " + currentStateTotalDue.ToString("c") + ")\r\n\r\n";
                        }

                        currentState = data[0];
                        currentStateCustomers = 0;
                        currentStateTotalDue = 0.0m;

                        output += "Customers from " + currentState + ":\r\n";
                    }

                    customerBalance = Convert.ToDecimal(data[2]);

                    totalCustomers++;
                    currentStateCustomers++;

                    totalDue += customerBalance;
                    currentStateTotalDue += customerBalance;

                    string[] name = data[1].Split(',');

                    output += "\t" + name[1].Trim() + " " + name[0].Trim() + " (balance due = " +
                        customerBalance.ToString("c") +")\r\n";
                }

                output += "\r\n\tNumber of customers from " + currentState + ": " +
                                currentStateCustomers + "  (total due from " + currentState +
                                " customers: " + currentStateTotalDue.ToString("c") + ")\r\n\r\n";

                output += "Total Customers from all states: " + totalCustomers + "\r\n" +
                    "\tTotal Due from ALL customers: " + totalDue.ToString("c");

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
