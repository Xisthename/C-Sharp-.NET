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
    /// 2018-09-11
    /// </summary>
    public class DataController
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private DataGridView table;
        private BuildingManager buildingManager = new BuildingManager();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        public DataController(DataGridView table)
        {
            this.table = table;
        }

        /// <summary>
        /// Adds an object to the building list
        /// </summary>
        /// <param name="newBuilding"></param>
        internal void AddBuilding(Building newBuilding)
        {
            buildingManager.AddBuilding(newBuilding);
            UpdateTable();
        }

        /// <summary>
        /// Removes an object at a given index from the buildingList
        /// </summary>
        /// <param name="index"></param>
        public void RemoveBuildingAtIndex(int index)
        {
            buildingManager.RemoveBuildingAtIndex(index);
            UpdateTable();
        }

        public void UpdateTable()
        {
            table.Rows.Clear();
            for (int i = 0; i < buildingManager.GetBuildingList().Count; i++)
            {
                Building b = buildingManager.GetBuilding(i);
                table.Rows.Add(b.Id.ToString(), b.GetCountry(), b.City, b.Street, b.ZipCode, b.GetBuildingCategory(), b.BuildingType, b.LegalType.ToString(), b.Image);
            }
        }
    }
}
