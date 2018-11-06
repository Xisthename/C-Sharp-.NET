using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logics_Layer
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-19
    /// </summary>
    public class InputData
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private DataController controller;
        private Building tempBuilding;
        public static int selectedindex;

        /// <summary>
        /// Constructor that takes in a instance of the controller object and delecers the instance object to this one
        /// </summary>
        /// <param name="controller"></param>
        public InputData(DataController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Collects the enum Countries data and returns it into a string array
        /// </summary>
        /// <returns></returns>
        public static string[] GetCountries()
        {
            string[] countries = Enum.GetNames(typeof(Countries));

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = countries[i].Replace("_", " ");
            }
            return countries;
        }

        /// <summary>
        /// Collects the enum Category data and returns it into a string array
        /// </summary>
        /// <returns></returns>
        public static string[] GetCategories()
        {
            return Enum.GetNames(typeof(BuildingCategory));
        }

        /// <summary>
        /// Collects the enum LegalType data and returns it into a string array
        /// </summary>
        /// <returns></returns>
        public static string[] GetOwnerships()
        {
            return Enum.GetNames(typeof(LegalType));
        }

        /// <summary>
        /// Changes the building's type alternatives
        /// </summary>
        public static string[] GetBuildingTypes(int isCommercialBuilding)
        {
            selectedindex = isCommercialBuilding;
            string[] buildingType;

            if (isCommercialBuilding == 0)
            {
                buildingType = Enum.GetNames(typeof(ResidentialType));
            }
            else
            {
                buildingType = Enum.GetNames(typeof(CommercialType));
            }
            return buildingType;
        }

        /// <summary>
        /// Gets all the diffrent types that a building can be
        /// </summary>
        /// <returns></returns>
        public static string[] GetBothBuildingTypes()
        {
            List<string> typeList = new List<string>();
            typeList.Add("");
            typeList.AddRange(Enum.GetNames(typeof(ResidentialType)));
            typeList.AddRange(Enum.GetNames(typeof(CommercialType)));
            return typeList.ToArray();
        }

        /// <summary>
        /// Tries to read all inputs from the user to create a new building object
        /// Returns true when all inputs are correct
        /// Returns false if any input is invalid
        /// </summary>
        /// <param name="typeComboBox"></param>
        /// <param name="countriesComboBox"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="zipcode"></param>
        /// <param name="legalComboBox"></param>
        /// <returns></returns>
        public bool ReadBuildningInput(ComboBox typeComboBox, ComboBox countriesComboBox, string city, string street, string zipcode, ComboBox legalComboBox)
        {
            if (selectedindex == 1)
            {
                tempBuilding = new CommercialBuilding();
                tempBuilding.BuildingType = ((CommercialType) typeComboBox.SelectedIndex).ToString(); // Cant get wrong input 
            }
            else
            {
                tempBuilding = new ResidentialBuilding();
                tempBuilding.BuildingType = ((ResidentialType) typeComboBox.SelectedIndex).ToString(); // Cant get wrong input 
            }

            if (!CheckBuildingCity(city) || !CheckBuildingStreet(street) || !CheckBuildingZipCode(zipcode))
            {
                return false;
            }
            tempBuilding.Country = ((Countries)countriesComboBox.SelectedIndex).ToString(); // Cant get wrong input
            tempBuilding.LegalType = ((LegalType)legalComboBox.SelectedIndex).ToString(); // Cant get wrong input 
            return true;
        }

        /// <summary>
        /// If the string 'city' isn´t null nor empty it's value will be declared into tempBuilding and return true
        /// Otherwise an error message will be displayed to the user and false is returned
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        private bool CheckBuildingCity(string city)
        {
            if (!String.IsNullOrEmpty(city))
            {
                tempBuilding.City = city;
                return true;
            }
            DisplayTryAgainMessage("Please fill in the buildning´s City");
            return false;
        }

        /// <summary>
        /// If the string 'street' isn´t null nor empty it's value will be declared into tempBuilding and return true
        /// Otherwise a error message will be displayed to the user and false is returned
        /// </summary>
        /// <param name="street"></param>
        /// <returns></returns>
        private bool CheckBuildingStreet(string street)
        {
            if (!String.IsNullOrEmpty(street))
            {
                tempBuilding.Street = street;
                return true;
            }
            DisplayTryAgainMessage("Please fill in the buildning´s Street");
            return false;
        }

        /// <summary>
        /// If the  string 'zipCode' contains 5 letters it's value will be declared into tempBuilding and return true
        /// Otherwise an error message will be displayed to the user and false is returned
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        private bool CheckBuildingZipCode(string zipCode)
        {
            if (zipCode.Length == 5)
            {
                tempBuilding.ZipCode = zipCode;
                return true;
            }
            DisplayTryAgainMessage("Please fill in the buildning´s Zip Code");
            return false;
        }

        /// <summary>
        /// Adds the temporary building object to a list
        /// </summary>
        public bool AddBuilding()
        {
            if (controller.AddBuilding(tempBuilding))
            {
                SQLQuery.AddBuilding(tempBuilding);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Inserts a new building object into the list at a given index place
        /// </summary>
        public bool InsertBuilding(int index)
        {
            if (controller.InsertBuildingAt(index, tempBuilding))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Edits an existing building object's fields in a list with the given ID to this temporary building object
        /// </summary>
        /// <param name="buildingID"></param>
        public bool EditBuilding(string buildingID)
        {
            tempBuilding.BuildingID = buildingID;

            if (controller.EditBuilding(buildingID, tempBuilding))
            {
                SQLQuery.EditBuilding(buildingID, tempBuilding);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to remove a building with a certain building ID  
        /// </summary>
        /// <param name="buildingID"></param>
        public bool RemoveBuildingWithID(string buildingID)
        {
            if (controller.RemoveBuildingWithID(buildingID))
            {
                SQLQuery.RemoveBuilding(buildingID);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Tries to search after buildings in a city and/or for a certain building type
        /// </summary>
        /// <param name="city"></param>
        /// <param name="BuildingType"></param>
        public void Search(string city, string BuildingType)
        {
            if (String.IsNullOrEmpty(city) && String.IsNullOrEmpty(BuildingType))
            {
                DisplayTryAgainMessage("Fill in something to search after");
            }
            else
            {
                city = city.ToLower();
                BuildingType = BuildingType.ToLower();
                controller.Search(city, BuildingType);
            }
        }

        /// <summary>
        /// Used to display an error message to the user
        /// </summary>
        /// <param name="errorText"></param>
        private void DisplayTryAgainMessage(string errorText)
        {
            MessageBox.Show(errorText + " and try again!");
        }
    }
}