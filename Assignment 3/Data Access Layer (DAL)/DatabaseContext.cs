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
    public class DatabaseContext
    {
        public static readonly string connectionString = "SERVER=195.178.232.16;port=3306;DATABASE=ae3317;UID=AE3317;PASSWORD=123SchoolConnection!";
        private readonly MySqlConnection connection;

        public DatabaseContext()
        {
            connection = new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(String query)
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
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
