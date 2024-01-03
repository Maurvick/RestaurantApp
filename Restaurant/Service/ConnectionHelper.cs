using MySql.Data.MySqlClient;
using System.IO;
using System;

namespace RestaurantDB.Service
{
    static class ConnectionHelper
    {
		// private MySqlConnection _connection;
		public static MySqlConnection Connection { get; set; }

        /*public MySqlConnection Connection
		{
			get { return _connection; }
			set { _connection = value; }
		}*/

        /*public ConnectionHelper(MySqlConnection connection)
		{
			_connection = connection;
		}*/

        public static void EnsureDbCreated()
        {
            try
            {
                Connection.Open();

                // Read SQL script from file
                string sqlScript;
                using (StreamReader reader = new StreamReader("restaurant.sql"))
                {
                    sqlScript = reader.ReadToEnd();
                }

                // Execute SQL script
                using (MySqlCommand cmd = new MySqlCommand(sqlScript, Connection))
                {
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Database schema created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
