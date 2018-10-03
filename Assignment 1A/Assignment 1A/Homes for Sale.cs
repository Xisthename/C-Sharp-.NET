using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logics_Layer;

namespace Assignment_1
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    public partial class HomesForSale : Form
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private InputData inputData;
        private DataController controller;

        public HomesForSale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the application starts two instance to the controller and input class are made, futhermore Initlize the GUI too
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomesForSale_Load(object sender, EventArgs e)
        {
            controller = new DataController(table);
            inputData = new InputData(controller);
            InitGUI();
        }

        /// <summary>
        /// Initlize the GUI controls
        /// </summary>
        private void InitGUI()
        {
            countriesComboBox.Items.AddRange(InputData.GetCountries());
            countriesComboBox.SelectedIndex = 0;

            categoryComboBox.Items.AddRange(InputData.GetCategories());
            categoryComboBox.SelectedIndex = 0;

            legalComboBox.Items.AddRange(InputData.GetOwnerships());
            legalComboBox.SelectedIndex = 0;

            ChangeBuildingType(0);
        }

        /// <summary>
        /// Changes the building's type alternatives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBuildingType(categoryComboBox.SelectedIndex);
        }

        /// <summary>
        /// Changes the building's type alternatives
        /// </summary>
        /// <param name="isCommercialBuilding"></param>
        private void ChangeBuildingType(int isCommercialBuilding)
        {
            typeComboBox.Items.Clear();
            typeComboBox.Items.AddRange(InputData.ChangeBuildingType(isCommercialBuilding));
            typeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Tries to read in an image and display it to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imagebutton_Click(object sender, EventArgs e)
        {
            if (inputData.ReadInImage())
            {
                displayImage.BringToFront();
                displayImage.Image = inputData.GetImage();
            }
        }

        /// <summary>
        /// Clears an image if one has been chosen before by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearImageButton_Click(object sender, EventArgs e)
        {
            ClearChosenImage();
        }

        /// <summary>
        /// Clears an image if one has been chosen before by the user
        /// </summary>
        private void ClearChosenImage()
        {
            imageLabel.BringToFront();
            inputData.ClearImage();
            displayImage.Image = inputData.GetImage();
        }

        /// <summary>
        /// Tries to add a new buildning and every input that can fail is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        /// <summary>
        /// Tries to edit the building that is selected in the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count == 1) // Are there even a building object to edit?
            {
                AddOrEdit(false);
            }
            else
            {
                MessageBox.Show("No building is selected!");
            }
        }

        /// <summary>
        /// Tries to add or edit a building
        /// </summary>
        /// <param name="addBuilding"></param>
        private void AddOrEdit(bool addBuilding)
        {
            if (inputData.ReadBuildningInput(typeComboBox, countriesComboBox, cityTextBox.Text, streetTextBox.Text, zipCodeTextBox.Text, legalComboBox))
            {
                if (addBuilding)
                {
                    inputData.AddBuilding();
                }
                else
                {
                    if (table.SelectedRows.Count > 0)
                    {
                        String buildingID = table.SelectedCells[0].Value.ToString();
                        inputData.EditBuilding(buildingID);
                    }
                    else
                    {
                        MessageBox.Show("No building from the list is selected and therfore cannot be modified");
                    }
                }
                //ClearChosenImage();
            }
        }

        /// <summary>
        /// Removes the selected building object from not only the GUI but also it's data from the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0)
            {
                String buildingID = table.SelectedCells[0].Value.ToString();
                inputData.RemoveBuildingWithID(buildingID);
            }
            else
            {
                MessageBox.Show("No building from the list is selected and therfore cannot be removed");
            }
        }

        /// <summary>
        /// Only allow numbers in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
