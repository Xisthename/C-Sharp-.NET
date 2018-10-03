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
        private int index;

        /// <summary>
        /// Constructor that takes in the DataGridView table which is later used to display objects of buildings
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
        internal bool AddBuilding(Building newBuilding)
        {
            newBuilding.ID = buildingManager.GenerateID();
            return buildingManager.Add(newBuilding);
        }

        /// <summary>
        /// Tries to update a building´s information
        /// </summary>
        /// <param name="buildingID"></param>
        /// <param name="building"></param>
        internal bool EditBuilding(String buildingID, Building editedBuilding)
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
        internal bool RemoveBuildingWithID(String buildingID)
        {
            if (CheckID(buildingID))
            {
                return buildingManager.DeleteAt(index);
            }
            return false;
        }

        private bool CheckID(String buildingID)
        {
            index = buildingManager.GetIndexFromID(buildingID);

            if (index != -1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Clears the table
        /// </summary>
        private void ClearTable()
        {
            table.Rows.Clear();
        }

        /// <summary>
        /// Updates the GUI that displays objects of buildings
        /// </summary>
        public void UpdateTable()
        {
            ClearTable();
            List<String> list = buildingManager.ToStringList();

            for (int row = 0; row < buildingManager.Count; row++)
            {
                table.Rows.Add();

                for (int col = 0; col < table.ColumnCount - 1; col++)
                {
                    table[col, row].Value = list[row].Split(',').ToArray()[col];
                }
                table[table.ColumnCount - 1, row].Value = buildingManager.GetImageAt(row);
            }
        }
    }
}
