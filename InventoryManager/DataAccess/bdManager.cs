using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryManager.DataAccess
{
    class bdManager
    {
        public bool validateUser(string user, string password)
        {
            bool valid = false;
            var connectionString = ConfigurationManager.ConnectionStrings["InventoryManager.Properties.Settings.IMDBConnectionString"].ConnectionString;
            string queryString = "SELECT count(*) FROM dbo.Usuario WHERE nombre='"+user+"' and password='"+password+"'";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.Write("numero de registros = " + reader[0].ToString());
                        if(Int32.Parse(reader[0].ToString()) == 1)
                        {
                            valid = true;
                        }
                    }
                }
            }
            return valid;
        }

        public string column(string producto, string attribute)
        {
            string column = "";
            var connectionString = ConfigurationManager.ConnectionStrings["InventoryManager.Properties.Settings.IMDBConnectionString"].ConnectionString;
            string query = "SELECT "+attribute+" FROM dbo.Producto WHERE type = '"+producto+"'";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        column = reader[attribute].ToString();
                    } else
                    {
                        column = "---";
                    }
                }
            }
            return column;
        }
    }
}
