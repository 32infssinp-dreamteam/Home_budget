using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Home_budget.Helpers;
using Home_budget.Views;
using Models.Models;
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

            var cat = new List<Category>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CategoriesView(cat));
        }
    }
}
