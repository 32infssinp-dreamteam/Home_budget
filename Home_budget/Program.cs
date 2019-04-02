using System;
using Home_budget.Helpers;
using Repository.Helpers;
using Repository.Utils;

namespace Home_budget
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var databaseFile = ConfigurationHelper.GetConfigurationValue("DatabaseFile");

            SQLiteConnectionStringHelper.Database = databaseFile;

            DatabaseMaker.CreateDatabase(databaseFile);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
