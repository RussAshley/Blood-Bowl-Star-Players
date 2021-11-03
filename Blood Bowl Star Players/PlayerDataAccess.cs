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

        public StarPlayer ReadStarByName(string starplayername)
        {
            StarPlayer result = new StarPlayer("", 0, 0, 0,0,0,"","","","","","","","","","","",0,"");
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT* FROM StarPlayers WHERE Name=@Name ";
                command.Parameters.AddWithValue("@Name", starplayername);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        
                        result.StarPlayerName = reader.GetString(0);
                        result.MovementAllowance = reader.GetInt32(1);
                        result.Strength = reader.GetInt32(2);
                        result.Agility = reader.GetInt32(3);
                        result.PassingAbility = reader.GetInt32(4);
                        result.ArmourValue = reader.GetInt32(5);
                        result.Skills = reader.GetString(6);
                        result.SpecialRules = reader.GetString(7);
                        result.HalflingThimbleCup = reader.GetString(8);
                        result.LustrianSuperLeague = reader.GetString(9);
                        result.OldWorldClassic = reader.GetString(10);
                        result.SylvanianSpotlight = reader.GetString(11);
                        result.ElvenKingdomsLeague = reader.GetString(12);
                        result.WorldsEdgeSuperleague = reader.GetString(13);
                        result.BadlandsBrawl = reader.GetString(14);
                        result.UnderworldChallenge = reader.GetString(15);
                        result.FavouredOf = reader.GetString(16);
                        result.Cost = reader.GetInt32(17);
                        result.StarPlayerImage = reader.GetString(18);
                    }
                }
            }
            return result;
        }
        public void UpdateStar(StarPlayer starToUpdate)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE StarPlayers SET Name = @Name, MA = @MA, ST = @ST, AG=@AG, PA=@PA, AV=@AV, Skills=@Skills,Special Rules =@Special Rules, Halfling Thimble Cup= WHERE id = @id";

                command.Parameters.AddWithValue("@make", carToUpdate.Make);
                command.Parameters.AddWithValue("@model", carToUpdate.Model);
                command.Parameters.AddWithValue("@colour", carToUpdate.Colour);
                command.Parameters.AddWithValue("@engineSize", carToUpdate.EngineSize);
                command.Parameters.AddWithValue("@id", carToUpdate.Id);

                try
                {
                    int count = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                connection.Close();
            }

        }
    }
}



   


    

