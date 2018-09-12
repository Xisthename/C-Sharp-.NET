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
    /// 2018-09-11
    /// </summary>
    class Controller
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        private DataGridView table;
        private BuildingManager buildingManager;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        public Controller(DataGridView table)
        {
            this.table = table;
        }

        public void SetbuildingManager(BuildingManager buildingManager)
        {
            this.buildingManager = buildingManager;
            UpdateTable();
        }

        public void UpdateTable()
        {
            Image image = null;
            table.Rows.Clear();

            for (int i = 0; i < buildingManager.GetBuildingList().Count; i++)
            {
                Building b = buildingManager.GetBuilding(i);
                image = b.Image;
                table.Rows.Add(b.Id.ToString(), b.Address.GetGetCountry(), b.Address.City, b.Address.Street, b.Address.ZipCode, b.GetBuildingCategory(), b.BuildingType, b.LegalType.ToString(), image);
            }
        }
    }
}
