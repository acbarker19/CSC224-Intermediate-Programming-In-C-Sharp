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

namespace lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            string path = txtFile.Text;
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);

                txtOutput.Text = "Contents of file \"" + path + "\":\r\n==================\r\n";

                string theLine = null;
                int numLines = 0;
                int numBlankLines = 0;

                while (textIn.Peek() != -1)
                {
                    numLines++;

                    theLine = textIn.ReadLine();

                    if(theLine == "")
                    {
                        numBlankLines++;
                    }
                    else
                    {
                        txtOutput.Text += theLine + "\r\n";
                    }
                }

                txtOutput.Text += "================== end of file\r\n";
                txtOutput.Text += "Total Number of Lines: " + numLines +
                    "\r\nNumber of Blank Lines: " + numBlankLines;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Reading Error");
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\Users\\acbar\\Documents\\School Work\\CSC 224 - C#";
            fileDialog.Filter ="Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                txtFile.Text = fileName;
                txtFile.Focus();
                txtFile.SelectionStart = fileName.Length;
                txtFile.SelectionLength = 0;
            }
        }
    }
}
