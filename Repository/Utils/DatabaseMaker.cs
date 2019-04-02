using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Repository.Helpers;

namespace Repository.Utils
{
    public static class DatabaseMaker
    {
        public static void CreateDatabase(string filename)
        {
            //if (File.Exists(filename))
            //{
            //    return;
            //}

            //SQLiteConnection.CreateFile(filename);

            var connectionString = SQLiteConnectionStringHelper.GetConnectionString();
            
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        //command.CommandText = "CREATE TABLE Test (Id INT)";
                        //command.ExecuteNonQuery();

                        //command.CommandText = "INSERT INTO Test (Id) VALUES (55)";
                        //command.ExecuteNonQuery();
                        command.CommandText = "SELECT * FROM Test";

                        using (var dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Console.WriteLine($"_test_ {dr[0].ToString()}");
                            }
                        }
                    }

                    transaction.Commit();
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}