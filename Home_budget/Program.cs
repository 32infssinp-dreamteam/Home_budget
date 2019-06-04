using System;
using System.Windows.Forms;
using Home_budget.Helpers;
using Home_budget.Views;
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

            DatabaseMaker.CreateDatabaseIfNotExists();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
