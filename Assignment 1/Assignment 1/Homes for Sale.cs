using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logics_Layer;

namespace Assignment_1
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-09-09
    /// </summary>
    public partial class HomesForSale : Form
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private BuildingManager buildingManager = new BuildingManager();
        private InputData inputData;
        private DataController controller;
        private SaveFileDialog saveDialog = new SaveFileDialog();
        private OpenFileDialog openDialog = new OpenFileDialog();
        private string filePath;
        private bool savedUpToDate = true;

        public HomesForSale()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the application starts two instance to the controller and input class are made, futhermore Initlize the GUI too
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomesForSale_Load(object sender, EventArgs e)
        {
            controller = new DataController(buildingManager);
            inputData = new InputData(controller);
            openDialog.Filter = "Data Files (*.bin)|*.bin";
            openDialog.Title = "Open a file";
            saveDialog.AddExtension = true;
            InitGUI();
        }

        /// <summary>
        /// Initlize the GUI controls
        /// </summary>
        private void InitGUI()
        {
            countriesComboBox.Items.AddRange(InputData.GetCountries());
            countriesComboBox.SelectedIndex = 0;

            categoryComboBox.Items.AddRange(InputData.GetCategories());
            categoryComboBox.SelectedIndex = 0;

            legalComboBox.Items.AddRange(InputData.GetOwnerships());
            legalComboBox.SelectedIndex = 0;

            ChangeBuildingType(0);

            searchTypeComboBox.Items.AddRange(InputData.GetBothBuildingTypes());
            searchTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Resets the GUI to how the application was when it started
        /// </summary>
        private void ResetGUI()
        {
            countriesComboBox.Items.Clear();
            categoryComboBox.Items.Clear();
            legalComboBox.Items.Clear();
            searchTypeComboBox.Items.Clear();
            cityTextBox.ResetText();
            streetTextBox.ResetText();
            zipCodeTextBox.ResetText();
            searchCityTextBox.ResetText();
            ClearChosenImage();
            controller.ResetSearch();
            InitGUI();
        }

        /// <summary>
        /// Changes the building's type alternatives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeBuildingType(categoryComboBox.SelectedIndex);
        }

        /// <summary>
        /// Changes the building's type alternatives
        /// </summary>
        /// <param name="isCommercialBuilding"></param>
        private void ChangeBuildingType(int isCommercialBuilding)
        {
            typeComboBox.Items.Clear();
            typeComboBox.Items.AddRange(InputData.GetBuildingTypes(isCommercialBuilding));
            typeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Tries to read in an image and display it to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imagebutton_Click(object sender, EventArgs e)
        {
            if (inputData.ReadInImage())
            {
                displayImage.BringToFront();
                displayImage.Image = inputData.GetImage();
            }
        }

        /// <summary>
        /// Clears an image if one has been chosen before by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearImageButton_Click(object sender, EventArgs e)
        {
            ClearChosenImage();
        }

        /// <summary>
        /// Clears an image if one has been chosen before by the user
        /// </summary>
        private void ClearChosenImage()
        {
            imageLabel.BringToFront();
            inputData.ClearImage();
            displayImage.Image = inputData.GetImage();
        }

        /// <summary>
        /// Tries to add a new buildning and every input that can fail is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (InputDataIsCorrect())
            {
                if (inputData.AddBuilding())
                {
                    UpdateTable();
                    savedUpToDate = false;
                }
                else
                {
                    MessageBox.Show("Unkown Error! Could not add a building");
                }
            }
        }

        /// <summary>
        /// Tries to insert a new buildning and every input that can fail is checked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertButton_Click(object sender, EventArgs e)
        {
            if (InputDataIsCorrect())
            {
                int index;

                if (table.SelectedRows.Count == 1) // Are there even a building object to edit?
                {
                    index = table.CurrentCell.RowIndex;
                }
                else
                {
                    index = 0;
                }

                if (inputData.InsertBuilding(index))
                {
                    UpdateTable();
                    savedUpToDate = false;
                }
                else
                {
                    MessageBox.Show("Unkown Error! Could not insert a building");
                }
            }
        }

        /// <summary>
        /// Tries to edit a building that is selected in the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count == 1) // Are there even a building object to edit?
            {
                if (InputDataIsCorrect())
                {
                    string buildingID = table.SelectedCells[0].Value.ToString();

                    if (inputData.EditBuilding(buildingID))
                    {
                        UpdateTable();
                        savedUpToDate = false;
                    }
                    else
                    {
                        MessageBox.Show("Unkown Error! Could not edit the selected building");
                    }
                }
            }
            else
            {
                MessageBox.Show("No building is selected and therfore cannot be modified!");
            }
        }

        /// <summary>
        /// Returns true if the data can be used otherwise false is returned and a certain error message will appear
        /// </summary>
        /// <returns></returns>
        private bool InputDataIsCorrect()
        {
            if (inputData.ReadBuildningInput(typeComboBox, countriesComboBox, cityTextBox.Text, streetTextBox.Text, zipCodeTextBox.Text, legalComboBox))
            {
                return true;
            }
            return false;
            //ClearChosenImage();
        }

        /// <summary>
        /// Removes the selected building object from not only the GUI but also it's data from the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (table.SelectedRows.Count > 0)
            {
                string buildingID = table.SelectedCells[0].Value.ToString();

                if (inputData.RemoveBuildingWithID(buildingID))
                {
                    UpdateTable();
                    savedUpToDate = false;
                }
                else
                {
                    MessageBox.Show("Unkown Error! Could not remove the selected building");
                }
            }
            else
            {
                MessageBox.Show("No building from the list is selected and therfore cannot be removed");
            }
        }

        /// <summary>
        /// Tries to search after buildings in a city and what kind of building it is
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            inputData.Search(searchCityTextBox.Text, searchTypeComboBox.GetItemText(searchTypeComboBox.SelectedItem));
            UpdateTable();
        }

        private void ResetSearchButton_Click(object sender, EventArgs e)
        {
            controller.ResetSearch();
            UpdateTable();
        }

        /// <summary>
        /// Only allow numbers in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zipCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Starts off with asking the user if the current work should be saved
        /// The return of this is then cast into the datacontroller object where the data is saved or not
        /// Then are all building objects removed and the update of the GUI comes in
        /// Lastly all components are reset to how they were when the application started
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile(SaveOrNot());
            ResetGUI();
        }

        /// <summary>
        /// Starts off with asking the user if the current work should be saved
        /// The return of this is then cast into the datacontroller object where the data is saved or not
        /// Finally the user gets the option to open a file and if a file is loaded then all it's buildings will be visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile(SaveOrNot());
        }

        /// <summary>
        /// If there are buildings then user gets asked if the current data should be saved or not
        /// True is returned if the data should be saved and false if the data should not be saved
        /// </summary>
        /// <returns></returns>
        private bool SaveOrNot()
        {
            if (table.RowCount != 0)
            {
                if (savedUpToDate)
                {
                    return true;
                }
                else if (MessageBox.Show("Do you want to save the current work?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Tries to save the current file
        /// If the file haven't been saved before the user will be given the option to save the file by namning it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// The user will be given the option to save the current work into any location on their computer with a given name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs(false);
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs(true);
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
            savedUpToDate = true;
            controller.ResetSearch();
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

                try
                {

                    buildingManager.BinaryDeSerialization(filePath);
                    controller.ResetSearch();
                    UpdateTable();
                    savedUpToDate = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
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
                try
                {
                    buildingManager.BinarySerialization(filePath);
                    savedUpToDate = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
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
                        try
                        {
                            buildingManager.XMLSerialize(filePath);
                            savedUpToDate = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
                    }
                    else
                    {
                        try
                        {
                            buildingManager.BinarySerialization(filePath);
                            savedUpToDate = true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.ToString());
                        }
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

            if (controller.SearchedAfterBuildings)
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

                    if (controller.SearchedAfterBuildings)
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


        /// <summary>
        /// Asks the user if the want to save their work before the application closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveOrNot())
            {
                SaveFile();
            }
            Close();
        }
    }
}
