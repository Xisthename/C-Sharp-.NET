using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Data_Access_Layer__DAL_
{
    /// <summary>
    /// Daniel Petersén
    /// 2018-10-29
    /// </summary>
    public class DatabaseContext
    {
        /// <summary>
        /// Delecering necessary variables
        /// </summary>
        public static readonly string connectionString = "SERVER=195.178.232.16;port=3306;DATABASE=ae3317;UID=AE3317;PASSWORD=123SchoolConnection!";
        private readonly MySqlConnection connection = new MySqlConnection(connectionString);
        private MySqlDataAdapter adapter;

        /// <summary>
        /// Tries to execute a mysql command and return all the rows affected, in the database, into a datatable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(String query)
        {
            try
            {
                adapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }
    }
}
