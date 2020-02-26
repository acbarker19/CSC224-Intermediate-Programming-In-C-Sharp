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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmViewBook viewBook = new frmViewBook();
            viewBook.ShowDialog();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            frmViewBranch viewBranch = new frmViewBranch();
            viewBranch.ShowDialog();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            frmViewAuthor viewAuthor = new frmViewAuthor();
            viewAuthor.ShowDialog();
        }

        private void btnBookCopies_Click(object sender, EventArgs e)
        {
            frmViewBookCopies viewBookCopies = new frmViewBookCopies();
            viewBookCopies.ShowDialog();
        }
    }
}
