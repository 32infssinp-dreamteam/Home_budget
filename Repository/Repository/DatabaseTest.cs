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
                
            }
        }
    }
}