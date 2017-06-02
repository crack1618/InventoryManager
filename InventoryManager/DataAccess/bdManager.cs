using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InventoryManager.DataAccess
{
    class bdManager
    {
        private string connectionString;

        public bdManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["InventoryManager.Properties.Settings.IMDBConnectionString"].ConnectionString;
        }

        public bool validateUser(string user, string password)
        {
            bool valid = false;
            string queryString = "SELECT count(*) FROM dbo.Usuario WHERE nombre='"+user+"' and password='"+password+"'";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if(Int32.Parse(reader[0].ToString()) == 1)
                        {
                            valid = true;
                        }
                    }
                }
            }
            return valid;
        }

        public int getNextCode()
        {
            int nextBarCode;
            string queryString = "SELECT TOP 1 barcode FROM dbo.Producto ORDER BY barcode DESC";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        nextBarCode = Int32.Parse(reader[0].ToString());
                    }
                    else
                    {
                        nextBarCode = 752364;
                    }
                }
            }
            return nextBarCode;
        }

        public bool InsertProduct(string gender, string type, decimal price, int stock, int xibit, string description)
        {
            bool valid = false;
            string queryString = "INSERT INTO dbo.Producto(gender,type,price,stock,xibit,description)"
                                +"VALUES(@gend,@type,@pric,@stck,@xibt,@desc)";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@gend", gender);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@pric", price);
                command.Parameters.AddWithValue("@stck", stock);
                command.Parameters.AddWithValue("@xibt", xibit);
                command.Parameters.AddWithValue("@desc", description);
                
                connection.Open();
                valid = (command.ExecuteNonQuery() > 0);
            }
            return valid;
        }

        public int total(string product, string tipo)
        {
            int total = 0;
            string query = "SELECT "+tipo+" FROM dbo.Producto WHERE type='"+product+"'";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        total += Int32.Parse(reader[tipo].ToString());
                    }
                }
            }
            return total;
        }

        public float totalPrecio(string product, string tipo)
        {
            float total = 0;
            string query = "SELECT price, "+ tipo + " FROM dbo.Producto WHERE type='"+product+"'";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total += float.Parse(reader["price"].ToString()) * Int32.Parse(reader[tipo].ToString());
                    }
                }
            }
            return total;
        }


        public int prendasDiferentestipos(string product)
        {
            int nprendas = 0;
            string query = "SELECT count(*) FROM dbo.Producto WHERE type='"+product+"'";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nprendas = Int32.Parse(reader[0].ToString());
                    }
                }
            }
            return nprendas;
        }

        public bool ValidateQuantityInStock(int code, string from, int itemsToMove)
        {
            string queryString = "SELECT TOP 1 "+from+" FROM dbo.Producto WHERE barcode=@code and "+from+">=@moving";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@code", code);
                command.Parameters.AddWithValue("@moving", itemsToMove);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public bool GenerateChange(int code, string from, int quantity)
        {
            string to = (from == "stock") ? "xibit" : "stock";
            string queryString = "UPDATE dbo.Producto set "+ from + " = "+from+"-"+quantity+", "
                                + to + " = " + to + "+" + quantity
                                + " WHERE barcode = @barcode";
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@barcode", code);
                connection.Open();
                return (command.ExecuteNonQuery() > 0);
            }
        }
    }
}
