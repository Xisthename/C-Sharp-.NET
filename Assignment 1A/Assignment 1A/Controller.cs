using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1A
{
    class Controller
    {
        private DataGridView table;
        private BuildingManager buildingManager;

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
            table.Rows.Clear();
            Image image = null;

            for (int i = 0; i < buildingManager.GetBuildingList().Count; i++)
            {
                Building b = buildingManager.GetBuilding(i);
                table.Rows.Add(b.Id.ToString(), b.Address.ToString(), b.GetBuildingCategory(), b.BuildingType, b.LegalType.ToString(), image);
            }
        }
    }
}
