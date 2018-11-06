using Data_Access_Layer__DAL_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Business_Logics_Layer
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-10
    /// </summary>
    public class BuildingManager : ListManager<Building>
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private List<Building> buildingList = new List<Building>();
        private List<string> displayList = new List<string>();

        /// <summary>
        /// Generates and returns an Unique ID to a building
        /// </summary>
        /// <returns></returns>
        public string GenerateID()
        {
            return IDManager.GenerateUniqueID();
        }

        /// <summary>
        /// Returns at what index place a building is in the list with a certain ID
        /// Returns -1 if no building was found with the certain ID from the parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetIndexFromID(String id)
        {
            try
            {
                return list.FindIndex(x => x.BuildingID == id);
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// Tries to find buildings that match the city and/or a certain building type
        /// </summary>
        /// <param name="city"></param>
        /// <param name="buildingType"></param>
        public void SearchCityAndBuildingType(string city, string buildingType)
        {
            buildingList.Clear();
            displayList.Clear();

            if (!String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.City.ToLower().Contains(city) && x.BuildingType.ToString().ToLower().Equals(buildingType));
            }
            else if (!String.IsNullOrEmpty(city) && String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.City.ToLower().Contains(city));
            }
            else if (String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.BuildingType.ToString().ToLower().Equals(buildingType));
            }
            displayList = buildingList.ConvertAll(c => c.ToString());
        }

        /// <summary>
        /// The displayList gets all the building objects
        /// </summary>
        public void ResetSearch()
        {
            displayList = ToStringList();
        }

        public void SetDataFromDatabase()
        {
            DataTable dataTable = SQLQuery.RetrieveAllBuildings();
            string residentialCategory = new ResidentialBuilding().GetBuildingCategory();
            string category;
            Building building;

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                category = dataTable.Rows[row].Field<string>("Category");

                if (category.Equals(residentialCategory))
                {
                    building = SetResidentialBuilding(dataTable, row);
                }
                else
                {
                    building = SetCommercialBuilding(dataTable, row);
                }
                list.Add(building);
            }
            ResetSearch();
        }

        private Building SetResidentialBuilding(DataTable dataTable, int row)
        {
            var building = (from rw in dataTable.AsEnumerable()
                        where dataTable.Rows.IndexOf(rw).Equals(row)
                        select new ResidentialBuilding()
                        {
                            BuildingID = (string)(rw["BuildingID"]),
                            Country = (string)(rw["Country"]),
                            City = (string)(rw["City"]),
                            Street = (string)(rw["Street"]),
                            ZipCode = (string)(rw["Zip"]),
                            BuildingType = (string)(rw["Type"]),
                            LegalType = (string)(rw["Legal"])
                        }).First();
            return building;
        }

        private Building SetCommercialBuilding(DataTable dataTable, int row)
        {
            var building = (from rw in dataTable.AsEnumerable()
                        where dataTable.Rows.IndexOf(rw).Equals(row)
                        select new CommercialBuilding()
                        {
                            BuildingID = (string)(rw["BuildingID"]),
                            Country = (string) (rw["Country"]),
                            City = (string)(rw["City"]),
                            Street = (string)(rw["Street"]),
                            ZipCode = (string)(rw["Zip"]),
                            BuildingType = (string)(rw["Type"]),
                            LegalType = (string)(rw["Legal"])
                        }).First();
            return building;
        }

        public void UpdateDatabase()
        {
            foreach (Building building in list)
            {
                SQLQuery.AddBuilding(building);
            }
        }

        /// <summary>
        /// Returns the displayList
        /// </summary>
        /// <returns></returns>
        public List<string> GetDisplayList()
        {
            return displayList;
        }
    }
}