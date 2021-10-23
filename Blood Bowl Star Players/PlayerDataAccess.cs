using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace Blood_Bowl_Star_Players
{
    class PlayerDataAccess
    {

        private string connectionString;

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public PlayerDataAccess(string connectionString)
        {
        ConnectionString = connectionString;
        }

        //ReadsDB

        public StarPlayer[] ReadAllStars()   {
            List<StarPlayer> result = new List<StarPlayer>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT * From StarPlayers";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new StarPlayer(reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), reader.GetString(11), reader.GetString(12), reader.GetString(13), reader.GetString(14), reader.GetString(15), reader.GetString(16), reader.GetInt32(17), reader.GetString(18)));
                    }
                }
            }
            return result.ToArray();
        }



     }
}



   


    

