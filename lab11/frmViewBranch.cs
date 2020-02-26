using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class frmViewBranch : Form
    {
        public frmViewBranch()
        {
            InitializeComponent();
        }

        private void branchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.branchBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.collegeDataSet);

        }

        private void frmViewBranch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet.Branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.collegeDataSet.Branch);

        }
    }
}
