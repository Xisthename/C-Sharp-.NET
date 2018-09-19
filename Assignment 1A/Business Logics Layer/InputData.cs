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
        private DataController dataController;
        private Building newBuilding;
        private Picture picture;
        public static int selectedindex;

        public InputData(DataController dataController)
        {
            this.dataController = dataController;
        }

        public static string[] GetCountries()
        {
            string[] countries = Enum.GetNames(typeof(Countries));

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = countries[i].Replace("_", " ");
            }
            return countries;
        }

        public static string[] GetCategories()
        {
            return Enum.GetNames(typeof(BuildingCategory));
        }

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
        public bool ReadImage()
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
                    picture = new Picture(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the image chosen by the user earlier
        /// </summary>
        /// <returns></returns>
        public Image GetImage()
        {
            return picture.Image;
        }

        public bool ReadInputAndSetData(int id, ComboBox typeComboBox, ComboBox countriesComboBox, String city, String street, String zipcode, ComboBox legalComboBox)
        {
            if (selectedindex == 1)
            {
                newBuilding = new CommercialBuilding();
                newBuilding.BuildingType = ((CommercialType) typeComboBox.SelectedIndex).ToString();
            }
            else
            {
                newBuilding = new ResidentialBuilding();
                newBuilding.BuildingType = ((ResidentialType) typeComboBox.SelectedIndex).ToString();
            }
            newBuilding.Id = id;
            newBuilding.Country = (Countries)countriesComboBox.SelectedIndex;
            newBuilding.City = city;
            newBuilding.Street = street;
            newBuilding.ZipCode = zipcode;
            newBuilding.LegalType = (LegalType)legalComboBox.SelectedIndex;

            newBuilding.Image = picture.Image;
            picture.Image = null;
            dataController.AddBuilding(newBuilding);

            return true;
        }

        /*private bool ReadBuildingType()
        {


            return false;
        }*/
    }
}
