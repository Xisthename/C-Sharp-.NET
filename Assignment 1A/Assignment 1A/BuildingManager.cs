using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private DataGridView table;

        public BuildingManager(DataGridView table)
        {
            this.table = table;
            UpdateTable();
        }

        /// <summary>
        /// Adds a new building object to the buildingList
        /// </summary>
        /// <param name="newBuilding"></param>
        public void AddBuilding(Building newBuilding)
        {
            buildingList.Add(newBuilding);
            UpdateTable();
        }

        /// <summary>
        /// Removes an object at a given index from the buildingList
        /// </summary>
        /// <param name="index"></param>
        public void RemoveBuildingAtIndex(int index)
        {
            buildingList.RemoveAt(index);
            UpdateTable();
        }

        /// <summary>
        /// Removes all objects from the buildingList
        /// </summary>
        public void RemoveAllBuildings()
        {
            buildingList.Clear();
            UpdateTable();
        }

        /// <summary>
        /// Takes in an index and returns a copy object of the task at that index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Building GetBuilding(int index)
        {
            Building copyBuilding = (Building) buildingList[index].Clone();
            return copyBuilding;
        }

        public void UpdateTable()
        {
            table.Rows.Clear();
            Image image = null;

            for (int i = 0; i < buildingList.Count; i++)
            {
                Building b = GetBuilding(i);
                table.Rows.Add(b.Id.ToString(), b.Address.ToString(), b.GetBuildingCategory(), b.GetBuildingType(), b.LegalType.ToString(), image);
            }
        }
    }
}
