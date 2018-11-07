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
    /// <summary>
    /// Daniel Petersén
    /// 2018-10-29
    /// </summary>
    public class SQLQuery
    {
        /// <summary>
        /// Delecering necessary variable
        /// </summary>
        private static DatabaseContext db = new DatabaseContext();

        /// <summary>
        /// Tries to retrieve all buildings from the database and return it in a datatable
        /// </summary>
        /// <returns></returns>
        public static DataTable RetrieveAllBuildings()
        {
            var query = "SELECT ID, Country, City, Street, Zip, Category, Type, Legal FROM building";
            return db.ExecuteQuery(query);
        }

        /// <summary>
        /// Tries to add a new building into the datbase
        /// </summary>
        /// <param name="building"></param>
        public static void AddBuilding(Building building)
        {
            var query = "INSERT INTO building(ID, Country, City, Street, Zip, Category, Type, Legal) " +
                "VALUES('" + building.BuildingID + "', '" + building.GetCountry() + "', '" + building.City + "', '" + building.Street + "', '" + building.ZipCode +
                "', '" + building.GetBuildingCategory() + "', '" + building.BuildingType + "', '" + building.LegalType + "')";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// Tries to remove a specific building from the datbase
        /// </summary>
        /// <param name="buildingID"></param>
        public static void RemoveBuilding(string buildingID)
        {
            var query = "DELETE FROM building WHERE ID = '" + buildingID + "'";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// Tries to edit a specific building from the datbase
        /// </summary>
        /// <param name="buildingID"></param>
        /// <param name="building"></param>
        public static void EditBuilding(string buildingID, Building building)
        {
            var query = "UPDATE building SET `Country` = '" + building.GetCountry() + "', `City` = '" + building.City + "', `Street` = '" + building.Street + "', " +
                "`Zip` = '" + building.ZipCode + "', `Category` = '" + building.GetBuildingCategory() +"', `Type` = '" + building.BuildingType + "', " +
                "`Legal` = '" + building.LegalType + "' WHERE(`ID` = '" + buildingID + "')";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// Tries to drop all buildings stored in the database!
        /// </summary>
        public static void DeleteAllBuildings()
        {
            var query = "DELETE FROM building";
            db.ExecuteQuery(query);
        }
    }
}
