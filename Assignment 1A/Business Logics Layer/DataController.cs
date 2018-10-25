using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private BuildingManager buildingManager = new BuildingManager();
        private DataGridView table;
        private int index;
        private SaveFileDialog saveDialog = new SaveFileDialog();
        private OpenFileDialog openDialog = new OpenFileDialog();
        private String fileName;

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


        internal bool InsertBuildingAt(int index, Building newBuilding)
        {
            newBuilding.ID = buildingManager.GenerateID();
            return buildingManager.InsertAt(index, newBuilding);
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

        /// <summary>
        /// returns true if the buildingID is found in the list and the index place in the list of this building will be stored 
        /// otherwise the index will be set to -1 and return false
        /// </summary>
        /// <param name="buildingID"></param>
        /// <returns></returns>
        private bool CheckID(String buildingID)
        {
            index = buildingManager.GetIndexFromID(buildingID);

            if (index != -1)
            {
                return true;
            }
            return false;
        }


        public void NewFile(bool save)
        {
            if (save) 
            {
                SaveFile();
            }
            buildingManager.DeleteAll();
            ClearTable();
            fileName = null;
        }

        public void OpenFile(bool save)
        {
            if (save)
            {
                SaveFile();
            }
            openDialog.Filter = "|*.bin";
            openDialog.Title = "Open a file";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openDialog.FileName;
                buildingManager.DeleteAll();
                buildingManager.BinaryDeSerialization(fileName);
                UpdateTable();
            }
        }

        public void SaveFile()
        {
            if (String.IsNullOrEmpty(fileName))
            {
                SaveFileAs();
            }
            else
            {
                buildingManager.BinarySerialization(fileName);
            }
        }

        public void SaveFileAs()
        {
            saveDialog = new SaveFileDialog();

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveDialog.FileName;

                if (!fileName.Contains(".bin")) // Adds ".bin" if the filename dosen't already contain it
                {
                    fileName += ".bin";
                }
                buildingManager.BinarySerialization(fileName);
            }
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
