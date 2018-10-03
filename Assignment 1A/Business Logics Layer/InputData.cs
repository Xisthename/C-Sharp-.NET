using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_Access_Layer__DAL_;

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
        private Image tempImage;
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
        public static string[] ChangeBuildingType(int isCommercialBuilding)
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
        /// Tries to read in an image that is chosen by the user
        /// </summary>
        /// <returns></returns>
        public bool ReadInImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = false,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tempImage = Picture.ReadInImage(openFileDialog.FileName);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// Returns the image chosen by the user earlier
        /// </summary>
        /// <returns></returns>
        public Image GetImage()
        {
            return tempImage;
        }

        /// <summary>
        /// Clears an image if one has been chosen before
        /// </summary>
        public void ClearImage()
        {
            if (tempImage != null)
            {
                tempImage = null;
            }
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
        public bool ReadBuildningInput(ComboBox typeComboBox, ComboBox countriesComboBox, String city, String street, String zipcode, ComboBox legalComboBox)
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

            if (!CheckBuildingCity(city) || !CheckBuildingStreet(street) || !CheckBuildingZipCode(zipcode) || !CheckImage())
            {
                return false;
            }
            tempBuilding.Country = (Countries)countriesComboBox.SelectedIndex; // Cant get wrong input
            tempBuilding.LegalType = (LegalType)legalComboBox.SelectedIndex; // Cant get wrong input 
            return true;
        }

        /// <summary>
        /// If the string 'city' isn´t null nor empty it's value will be declared into tempBuilding and return true
        /// Otherwise an error message will be displayed to the user and false is returned
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        private bool CheckBuildingCity(String city)
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
        private bool CheckBuildingStreet(String street)
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
        private bool CheckBuildingZipCode(String zipCode)
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
        /// If the Image 'tempImage' isn´t null it's value will be declared into tempBuilding and return true
        /// Otherwise an error message will be displayed to the user and false is returned
        /// </summary>
        /// <returns></returns>
        private bool CheckImage()
        {
            if (tempImage != null)
            {
                tempBuilding.Image = tempImage;
                return true;
            }
            DisplayTryAgainMessage("Please select an image for the buildning");
            return false;
        }

        /// <summary>
        /// Used to display an error message to the user
        /// </summary>
        /// <param name="errorText"></param>
        private void DisplayTryAgainMessage(String errorText)
        {
            MessageBox.Show(errorText + " and try again!");
        }

        /// <summary>
        /// Adds the temporary building object to a list
        /// </summary>
        public void AddBuilding()
        {
            if (controller.AddBuilding(tempBuilding))
            {
                controller.UpdateTable();
            }
            else
            {
                MessageBox.Show("Unkown Error! Could not add a building");
            }
        }

        /// <summary>
        /// Edits an existing building object's fields in a list with the given ID to this temporary building object
        /// </summary>
        /// <param name="buildingID"></param>
        public void EditBuilding(String buildingID)
        {
            if (controller.EditBuilding(buildingID, tempBuilding))
            {
                controller.UpdateTable();
            }
            else
            {
                MessageBox.Show("Unkown Error! Could not edit the selected building");
            }
        }

        public void RemoveBuildingWithID(String buildingID)
        {
            if (controller.RemoveBuildingWithID(buildingID))
            {
                controller.UpdateTable();
            }
            else
            {
                MessageBox.Show("Unkown Error! Could not remove the selected building");
            }
        }
    }
}