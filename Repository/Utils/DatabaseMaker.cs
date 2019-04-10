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
            if (File.Exists(filename))
            {
                return;
            }

            SQLiteConnection.CreateFile(filename);

            var connectionString = SQLiteConnectionStringHelper.GetConnectionString();
            
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.CreateTableCategories;
                        command.ExecuteNonQuery();

                        command.CommandText = SqlQuerries.CreateTableExpenses;
                        command.ExecuteNonQuery();

                        command.CommandText = SqlQuerries.CreateTableMonthlyBudgets;
                        command.ExecuteNonQuery();
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