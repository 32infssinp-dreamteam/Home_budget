using System.Data;
using System.Data.SQLite;
using Repository.Helpers;

namespace Repository.Repository
{
    public class DatabaseTest
    {
        public void TestConnection()
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        //command.CommandText = SqlQuerries.;
                        //command.Parameters.AddWithValue("", );

                        //command.ExecuteNonQuery();

                        //using (var dr = command.ExecuteReader())
                        //{
                        //    while (dr.Read())
                        //    {
                        //    }
                        //}
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