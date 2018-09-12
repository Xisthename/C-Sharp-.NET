using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1A
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    public partial class HomesForSale : Form
    {
        private Building tempBuilding;
        private Controller controller;
        private BuildingManager buildingManager;
        private int IsCommercialBuilding;

        public HomesForSale()
        {
            InitializeComponent();
        }

        private void HomesForSale_Load(object sender, EventArgs e)
        {
            controller = new Controller(table);
            buildingManager = new BuildingManager(controller);
            controller.SetbuildingManager(buildingManager);

            tempBuilding = new ResidentialBuilding(1, new Address(Countries.Russia, "Moskva", "Cold street", "63256"), LegalType.Rental, ResidentialType.Villa);
            buildingManager.AddBuilding(tempBuilding);
            tempBuilding = new CommercialBuilding(2, new Address(Countries.Thailand, "Bankog", "Worm street", "34322"), LegalType.Ownership, CommercialType.Shop);
            buildingManager.AddBuilding(tempBuilding);
            InitGUI();
        }

        /// <summary>
        /// Initlize the GUI controls
        /// </summary>
        private void InitGUI()
        {
            string[] countries = Enum.GetNames(typeof(Countries));

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = countries[i].Replace("_", " ");
            }
            countriesComboBox.Items.AddRange(countries);
            countriesComboBox.SelectedIndex = 0;

            string[] categories = Enum.GetNames(typeof(BuildingCategory));
            categoryComboBox.Items.AddRange(categories);
            categoryComboBox.SelectedIndex = 0;

            string[] ownerships = Enum.GetNames(typeof(LegalType));
            legalComboBox.Items.AddRange(ownerships);
            legalComboBox.SelectedIndex = 0;

            ChangeBuildingType();
        }

        /// <summary>
        /// Changes the building's type alternatives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsCommercialBuilding = categoryComboBox.SelectedIndex;
            ChangeBuildingType();
        }

        /// <summary>
        /// Changes the building's type alternatives
        /// </summary>
        private void ChangeBuildingType()
        {
            typeComboBox.Items.Clear();
            string[] buildingType;

            if (IsCommercialBuilding == 0)
            {
                buildingType = Enum.GetNames(typeof(ResidentialType));
            }
            else
            {
                buildingType = Enum.GetNames(typeof(CommercialType));
            }
            typeComboBox.Items.AddRange(buildingType);
            typeComboBox.SelectedIndex = 0;
        }

        private void ReadInputAndSetData()
        {
            tempBuilding = null;

            if (IsCommercialBuilding == 1)
            {
                tempBuilding = new CommercialBuilding();
                tempBuilding.BuildingType = ((CommercialType) typeComboBox.SelectedIndex).ToString();
            }
            else
            {
                tempBuilding = new ResidentialBuilding();
                tempBuilding.BuildingType = ((ResidentialType) typeComboBox.SelectedIndex).ToString();
            }
            tempBuilding.Id = (int) idNumericUpDown.Value;
            tempBuilding.Address = new Address((Countries) countriesComboBox.SelectedIndex, cityTextBox.Text, streetTextBox.Text, zipCodeTextBox.Text);
            tempBuilding.LegalType = (LegalType) legalComboBox.SelectedIndex;
            MessageBox.Show(tempBuilding.Address.ToString());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ReadInputAndSetData();
            buildingManager.AddBuilding(tempBuilding);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            buildingManager.RemoveBuildingAtIndex(table.CurrentCell.RowIndex);
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
