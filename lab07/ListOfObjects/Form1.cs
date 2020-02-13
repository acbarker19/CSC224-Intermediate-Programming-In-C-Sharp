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

namespace ListOfObjects
{
    public partial class Form1 : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();

        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayVehicles()
        {
            int lineNum = 0;

            foreach (Vehicle vehicle in vehicles)
            {
                lineNum++;
                txtOutputArea.Text += "Car #" + lineNum + ": " + vehicle.GetDisplayText() + "\r\n";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "H:\\CSC224\\";
            fileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                FileStream fs = null;
                try
                {
                    txtInputFileName.Text = fileName;
                    txtInputFileName.Focus();
                    txtInputFileName.SelectionStart = fileName.Length;
                    txtInputFileName.SelectionLength = 0;

                    fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader textIn = new StreamReader(fs);

                    while (textIn.Peek() != -1)  // not at end of file
                    {
                        string theLine = textIn.ReadLine();
                        string[] data = theLine.Split(',');
                        
                        for (int i = 0; i < data.Length - 1; i++)
                        {
                            data[i] = data[i].Trim();
                        }

                        Vehicle currentCar = new Vehicle(data[0],
                            data[1], Convert.ToInt32(data[2]), Convert.ToDecimal(data[3]),
                            Convert.ToDecimal(data[4]));

                        vehicles.Add(currentCar);
                    }

                    txtOutputArea.Text = "Contents of vehicle list after reading input file:\r\n";
                    DisplayVehicles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File Read Error");
                }
                finally
                {
                    if (fs != null)
                        fs.Close();
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddVehicle addVehicleForm = new frmAddVehicle();
            addVehicleForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            addVehicleForm.ControlBox = false;
            addVehicleForm.MaximizeBox = false;
            addVehicleForm.ShowDialog();
        }
    }
}
