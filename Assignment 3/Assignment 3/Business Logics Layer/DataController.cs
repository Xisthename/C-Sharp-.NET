using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logics_Layer
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-11
    /// </summary>
    public class DataController
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private BuildingManager buildingManager;
        private int index;

        /// <summary>
        /// Constructor that takes in the DataGridView table which is later used to display objects of buildings
        /// </summary>
        /// <param name="table"></param>
        public DataController(BuildingManager buildingManager)
        {
            this.buildingManager = buildingManager;
        }

        /// <summary>
        /// Tries to add an object into the building list
        /// </summary>
        /// <param name="newBuilding"></param>
        internal bool AddBuilding(Building newBuilding)
        {
            newBuilding.BuildingID = buildingManager.GenerateID();
            return buildingManager.Add(newBuilding);
        }

        /// <summary>
        /// Tries to update a building´s information
        /// </summary>
        /// <param name="buildingID"></param>
        /// <param name="building"></param>
        internal bool EditBuilding(string buildingID, Building editedBuilding)
        {
            if (CheckID(buildingID))
            {
                return buildingManager.EditAt(index, editedBuilding);
            }
            return false;
        }

        /// <summary>
        /// Tries to Remove an object with a given building ID
        /// </summary>
        /// <param name="buildingID"></param>
        internal bool RemoveBuildingWithID(string buildingID)
        {
            if (CheckID(buildingID))
            {
                return buildingManager.DeleteAt(index);
            }
            return false;
        }

        /// <summary>
        /// Searches through the list of buildings in hope of finding buildings matching both city and buildingType or one of them
        /// </summary>
        /// <param name="city"></param>
        /// <param name="buildingType"></param>
        internal void Search(string city, string buildingType)
        {
            buildingManager.SearchCityAndBuildingType(city, buildingType);
        }

        /// <summary>
        /// returns true if the buildingID is found in the list and the index place in the list of this building will be stored 
        /// otherwise the index will be set to -1 and return false
        /// </summary>
        /// <param name="buildingID"></param>
        /// <returns></returns>
        private bool CheckID(string buildingID)
        {
            index = buildingManager.GetIndexFromID(buildingID);

            if (index != -1)
            {
                return true;
            }
            return false;
        }
    }
}
