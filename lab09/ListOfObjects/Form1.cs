﻿using System;
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

        public void DisplayVehicles()
        {
            int lineNum = 0;

            lbxOutput.Items.Clear();
            CLEAR DOES NOT WORK

            foreach (Vehicle vehicle in vehicles)
            {
                lineNum++;
                lbxOutput.Items.Add("Car #" + lineNum + ": " + vehicle.GetDisplayText());
            }
        }

        public Form1()
        {
            InitializeComponent();
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
            DialogResult resultFromAddForm = addVehicleForm.ShowDialog();

            if (resultFromAddForm == DialogResult.OK && addVehicleForm.Tag != null)
            {
                Vehicle vehicle = (Vehicle)addVehicleForm.Tag;
                vehicles.Add(vehicle);
                DisplayVehicles();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lbxOutput.SelectedIndex;
            if (i != -1)
            {
                Vehicle vehicle = vehicles[i];
                string message = "Are you sure you want to delete " + vehicle.Year + " " + vehicle.Make + " " + vehicle.Model + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    vehicles.Remove(vehicle);
                    DisplayVehicles();
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            FileStream fs = null;

            try
            {
                string fileName = txtInputFileName.Text;
                fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                foreach (Vehicle vehicle in vehicles)
                {
                    sw.WriteLine(vehicle.Make + ", " + vehicle.Model + ", " + vehicle.Year + ", " + vehicle.Miles + ", " + vehicle.Price);
                }

                sw.Flush();
                MessageBox.Show("File " + fileName + " was written to disk.", "Save File Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Write Error");
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
