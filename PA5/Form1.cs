/******************************
 * CSC 224
 * Programming Assignment # 5
 * Author:  Alec Barker
 * Date:  March 3, 2020
 ******************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void csc224AlecCustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.csc224AlecCustomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.expDataSet);

        }

        private void csc224AlecCustomersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.csc224AlecCustomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.expDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expDataSet.csc224AlecStates' table. You can move, or remove it, as needed.
            this.csc224AlecStatesTableAdapter.Fill(this.expDataSet.csc224AlecStates);
            stateComboBox.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'expDataSet.csc224AlecCustomers' table. You can move, or remove it, as needed.
            //this.csc224AlecCustomersTableAdapter.Fill(this.expDataSet.csc224AlecCustomers);

        }

        private void fillByCustomerIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.csc224AlecCustomersTableAdapter.FillByCustomerID(this.expDataSet.csc224AlecCustomers, ((int)(System.Convert.ChangeType(customerIDToolStripTextBox.Text, typeof(int)))));
                if (csc224AlecCustomersBindingSource.Count == 0)
                    MessageBox.Show("No customer found with this ID. " +
                        "Please try again.", "Customer Not Found");
            }
            catch (FormatException)
            {
                MessageBox.Show("Customer ID must be an integer.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.csc224AlecCustomersBindingSource.CancelEdit();
        }

        private void fillByAllCustomersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.csc224AlecCustomersTableAdapter.Fill(this.expDataSet.csc224AlecCustomers);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }

        private void stateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.csc224AlecCustomersTableAdapter.FillByState(this.expDataSet.csc224AlecCustomers, stateToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
