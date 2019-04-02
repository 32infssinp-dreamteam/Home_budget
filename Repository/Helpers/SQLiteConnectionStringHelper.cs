using System.Data.SQLite;

namespace Repository.Helpers
{
    public static class SQLiteConnectionStringHelper
    {
        public static string Database { get; set; }

        private static string _connectionString { get; set; }

        public static string GetConnectionString()
        {
            if (_connectionString == null)
            {
                var connectionStringBuilder = new SQLiteConnectionStringBuilder();

                connectionStringBuilder.DataSource = Database;
                connectionStringBuilder.Version = 3;

                _connectionString = connectionStringBuilder.ConnectionString;
            }

            return _connectionString;
        }
    }
}