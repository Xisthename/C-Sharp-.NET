using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer__DAL_;

namespace Business_Logics_Layer
{
    public class SQLQuery
    {
        private static DatabaseContext db = new DatabaseContext();

        /// <summary>
        /// Funkar
        /// </summary>
        /// <returns></returns>
        public static DataTable RetrieveAllBuildings()
        {
            var query = "SELECT BuildingID, Country, City, Street, Zip, Category, Type, Legal FROM building";
            return db.ExecuteQuery(query);
        }

        /// <summary>
        /// Funkar
        /// </summary>
        /// <param name="building"></param>
        public static void AddBuilding(Building building)
        {
            var query = "INSERT INTO building(BuildingID, Country, City, Street, Zip, Category, Type, Legal) " +
                "VALUES('" + building.BuildingID + "', '" + building.Country + "', '" + building.City + "', '" + building.Street + "', '" + building.ZipCode +
                "', '" + building.GetBuildingCategory() + "', '" + building.BuildingType + "', '" + building.LegalType + "')";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// Funkar
        /// </summary>
        /// <param name="buildingID"></param>
        public static void RemoveBuilding(string buildingID)
        {
            var query = "DELETE FROM building WHERE BuildingID = '" + buildingID + "'";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// Funkar
        /// </summary>
        /// <param name="buildingID"></param>
        /// <param name="building"></param>
        public static void EditBuilding(string buildingID, Building building)
        {
            var query = "UPDATE building SET `Country` = '" + building.Country + "', `City` = '" + building.City + "', `Street` = '" + building.Street + "', " +
                "`Zip` = '" + building.ZipCode + "', `Category` = '" + building.GetBuildingCategory() +"', `Type` = '" + building.BuildingType + "', " +
                "`Legal` = '" + building.LegalType + "' WHERE(`BuildingID` = '" + buildingID + "')";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// Drops all data from the building table!
        /// </summary>
        public static void DeleteAllBuildings()
        {
            var query = "DELETE FROM building";
            db.ExecuteQuery(query);
        }
    }
}
