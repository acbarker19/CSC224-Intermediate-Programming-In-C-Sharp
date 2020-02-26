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
    public partial class frmViewBookCopies : Form
    {
        public frmViewBookCopies()
        {
            InitializeComponent();
        }

        private void bookCopiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookCopiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.collegeDataSet);

        }

        private void frmViewBookCopies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collegeDataSet.BookCopies' table. You can move, or remove it, as needed.
            this.bookCopiesTableAdapter.Fill(this.collegeDataSet.BookCopies);

        }
    }
}
