using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1A
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-10
    /// </summary>
    class BuildingManager
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private List<Building> buildingList = new List<Building>();
        private Controller controller;

        public BuildingManager(Controller controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Adds a new building object to the buildingList
        /// </summary>
        /// <param name="newBuilding"></param>
        public void AddBuilding(Building newBuilding)
        {
            buildingList.Add(newBuilding);
            controller.UpdateTable();
        }

        /// <summary>
        /// Removes an object at a given index from the buildingList
        /// </summary>
        /// <param name="index"></param>
        public void RemoveBuildingAtIndex(int index)
        {
            buildingList.RemoveAt(index);
            controller.UpdateTable();
        }

        /// <summary>
        /// Removes all objects from the buildingList
        /// </summary>
        public void RemoveAllBuildings()
        {
            buildingList.Clear();
            controller.UpdateTable();
        }

        /*public List<Building> SearchAfterObject()
        {
        }*/

        /// <summary>
        /// Takes in an index and returns a copy object of the task at that index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Building GetBuilding(int index)
        {
            Building copyBuilding = (Building) buildingList[index].Clone();
            return copyBuilding;
        }

        public List<Building> GetBuildingList()
        {
            return buildingList;
        }
    }
}
