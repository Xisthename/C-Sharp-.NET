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
        private BuildingManager buildingManager = new BuildingManager();
        private DataGridView table;
        private int index;
        private SaveFileDialog saveDialog = new SaveFileDialog();
        private OpenFileDialog openDialog = new OpenFileDialog();
        private string filePath;
        private bool searchedAfterBuildings = false;

        /// <summary>
        /// Constructor that takes in the DataGridView table which is later used to display objects of buildings
        /// </summary>
        /// <param name="table"></param>
        public DataController(DataGridView table)
        {
            this.table = table;
            openDialog.Filter = "Data Files (*.bin)|*.bin";
            openDialog.Title = "Open a file";
            saveDialog.AddExtension = true;
        }

        /// <summary>
        /// Tries to add an object into the building list
        /// </summary>
        /// <param name="newBuilding"></param>
        internal bool AddBuilding(Building newBuilding)
        {
            newBuilding.ID = buildingManager.GenerateID();
            return buildingManager.Add(newBuilding);
        }

        /// <summary>
        /// Tries to insert an object into the building list at a given index place
        /// </summary>
        /// <param name="index"></param>
        /// <param name="newBuilding"></param>
        /// <returns></returns>
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
            searchedAfterBuildings = true;
            buildingManager.SearchCityAndBuildingType(city, buildingType);
            UpdateTable();
        }

        /// <summary>
        /// Resets the current search after buildings and displays all the buildings
        /// </summary>
        public void ResetSearch()
        {
            buildingManager.ResetSearch();
            searchedAfterBuildings = false;
            UpdateTable();
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

        /// <summary>
        /// The user have decided to save or not to save the current file via the parameter
        /// Then are all building objects removed and the update of the GUI comes in
        /// Lastly all components are reset to how they were when the application started
        /// </summary>
        /// <param name="save"></param>
        public void NewFile(bool save)
        {
            if (save) 
            {
                SaveFile();
            }
            buildingManager.DeleteAll();
            ClearTable();
            filePath = null;
        }

        /// <summary>
        /// The user have decided to save or not to save the current file via the parameter
        /// The user gets the option to open a file and if a file is loaded then all it's buildings will be visible
        /// </summary>
        /// <param name="save"></param>
        public void OpenFile(bool save)
        {
            if (save)
            {
                SaveFile();
            }

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openDialog.FileName;
                buildingManager.DeleteAll();
                buildingManager.BinaryDeSerialization(filePath);
                UpdateTable();
            }
        }

        /// <summary>
        /// If the file have not been saved before the user gets asked to fill in a name 
        /// and the user can easily store the file anywhere on their computer
        /// Otherwise the data will be saved in a file that already exits
        /// </summary>
        public void SaveFile()
        {
            if (String.IsNullOrEmpty(filePath))
            {
                SaveFileAs(false);
            }
            else
            {
                buildingManager.BinarySerialization(filePath);
            }
        }

        /// <summary>
        /// The user gets the option to save the buildings data into a file
        /// The user must put in a name of the file and choose a place on the computer where the file should be saved
        /// The user has of course the option of exiting without saving the data
        /// </summary>
        public void SaveFileAs(bool saveAsXML)
        {
            if (buildingManager.Count > 0)
            {
                if (saveAsXML)
                {
                    saveDialog.Filter = "XML (*.xml)|*.xml";
                    saveDialog.DefaultExt = ".xml";
                }
                else
                {
                    saveDialog.Filter = "(*.bin)|*.bin";
                    saveDialog.DefaultExt = "bin";
                }

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveDialog.FileName;

                    if (saveAsXML)
                    {
                        buildingManager.XMLSerialize(filePath);
                    }
                    else
                    {
                        buildingManager.BinarySerialization(filePath);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data is available to save!");
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
            List<string> list;

            if (searchedAfterBuildings)
            {
                list = buildingManager.GetSearchedList();
            }
            else
            {
                list = buildingManager.ToStringList();
            }

            if (list != null)
            {
                for (int row = 0; row < list.Count; row++)
                {
                    table.Rows.Add();

                    for (int col = 0; col < table.ColumnCount - 1; col++)
                    {
                        table[col, row].Value = list[row].Split(',').ToArray()[col];
                    }

                    if (searchedAfterBuildings)
                    {
                        table[table.ColumnCount - 1, row].Value = buildingManager.GetBuildingList()[row].Image;
                    }
                    else
                    {
                        table[table.ColumnCount - 1, row].Value = buildingManager.GetImageAt(row);
                    }
                }
            }
        }
    }
}
