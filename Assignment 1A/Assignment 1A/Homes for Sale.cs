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
        /// Delecering necessary variable
        /// </summary>
        private InputData inputData;
        private DataController dataController;

        public HomesForSale()
        {
            InitializeComponent();
        }

        private void HomesForSale_Load(object sender, EventArgs e)
        {
            dataController = new DataController(table);
            inputData = new InputData(dataController);
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

        private void ChangeBuildingType(int isCommercialBuilding)
        {
            typeComboBox.Items.Clear();
            typeComboBox.Items.AddRange(InputData.ChangeBuildingType(isCommercialBuilding));
            typeComboBox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (inputData.ReadInputAndSetData((int)idNumericUpDown.Value, typeComboBox, countriesComboBox,
                cityTextBox.Text, streetTextBox.Text, zipCodeTextBox.Text, legalComboBox))
            {
                MessageBox.Show("A new building has been added!");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            dataController.RemoveBuildingAtIndex(table.CurrentCell.RowIndex);
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

        /// <summary>
        /// Tries to read in an image and display it to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picturebutton_Click(object sender, EventArgs e)
        {
            if (inputData.ReadImage())
            {
                pictureBox1.Image = inputData.GetImage();
            }
        }
    }
}
