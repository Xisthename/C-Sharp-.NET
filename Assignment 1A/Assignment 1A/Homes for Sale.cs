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
    public partial class HomesForSale : Form
    {
        private Building tempBuilding;
        private BuildingManager buildingManager;
        int tempCount;

        public HomesForSale()
        {
            InitializeComponent();
        }

        private void HomesForSale_Load(object sender, EventArgs e)
        {
            buildingManager = new BuildingManager(table);
            tempBuilding = new ResidentialBuilding(1, new Address(Countries.Russia, "Moskva", "Cold street", 63256), LegalType.Rental, ResidentialType.Villa);
            buildingManager.AddBuilding(tempBuilding);
            tempBuilding = new CommercialBuilding(2, new Address(Countries.Thailand, "Bankog", "Worm street", 34322), LegalType.Ownership, CommercialType.Shop);
            buildingManager.AddBuilding(tempBuilding);
            InitGUI();
        }

        private void InitGUI()
        {
            string[] countries = Enum.GetNames(typeof(Countries));

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = countries[i].Replace("_", " ");
            }
            countriesComboBox.Items.AddRange(countries);
            countriesComboBox.SelectedIndex = 0;
        }

        private void ReadInputAndSetData()
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            tempCount++;
            tempBuilding = new CommercialBuilding(2, new Address(Countries.Thailand, "Bankog", "Worm street", 34322), LegalType.Ownership, CommercialType.Shop);
            tempBuilding.Id = tempCount;
            buildingManager.AddBuilding(tempBuilding);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            buildingManager.RemoveBuildingAtIndex(table.CurrentCell.RowIndex);
        }
    }
}
