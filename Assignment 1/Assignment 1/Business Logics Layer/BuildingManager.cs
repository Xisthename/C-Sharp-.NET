using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private List<string> searchedList = new List<string>();

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
                return list.FindIndex(x => x.ID == id);
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// Returns a building´s image at a given index place from the list of buildings
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Image GetImageAt(int index)
        {
            return GetAt(index).Image;
        }

        /// <summary>
        /// Tries to find buildings that match the city and/or a certain building type
        /// </summary>
        /// <param name="city"></param>
        /// <param name="buildingType"></param>
        public void SearchCityAndBuildingType(string city, string buildingType)
        {
            buildingList.Clear();
            searchedList.Clear();

            if (!String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.City.ToLower().Contains(city) && x.BuildingType.ToString().ToLower().Contains(buildingType));
            }
            else if (!String.IsNullOrEmpty(city) && String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.City.ToLower().Contains(city));
            }
            else if (String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.BuildingType.ToString().ToLower().Contains(buildingType));
            }
            searchedList = buildingList.ConvertAll(c => c.ToString());
        }

        /// <summary>
        /// Removes all objects in the searchedList
        /// </summary>
        public void ResetSearch()
        {
            searchedList.Clear();
        }

        /// <summary>
        /// Returns the searchedList
        /// </summary>
        /// <returns></returns>
        public List<string> GetSearchedList()
        {
            return searchedList;
        }

        /// <summary>
        /// Returns the buildingList
        /// </summary>
        /// <returns></returns>
        public List<Building> GetBuildingList()
        {
            return buildingList;
        }
    }
}