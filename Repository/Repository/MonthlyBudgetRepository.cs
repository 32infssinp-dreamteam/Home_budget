using System;
using System.Data;
using System.Data.SQLite;
using Models.Models;
using Repository.Helpers;

namespace Repository.Repository
{
    public class MonthlyBudgetRepository
    {
        public MonthlyBudget Get(int year, int month)
        {
            MonthlyBudget monthlyBudget = null;

            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.GetMonthlyBudget;
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Month", month);

                        using (var dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                monthlyBudget = new MonthlyBudget
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Year = year,
                                    Month = month,
                                    BudgetValue = Convert.ToDecimal(dr["BudgetValue"])
                                };
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

            return monthlyBudget;
        }

        public void Add(int year, int month, decimal budgetValue)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.AddMonthlyBudget;
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Month", month);
                        command.Parameters.AddWithValue("@BudgetValue", budgetValue);

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

        public void Edit(MonthlyBudget monthlyBudget)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.EditMonthlyBudget;
                        command.Parameters.AddWithValue("@BudgetValue", monthlyBudget.BudgetValue);
                        command.Parameters.AddWithValue("@Year", monthlyBudget.Year);
                        command.Parameters.AddWithValue("@Month", monthlyBudget.Month);

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

        public void Delete(MonthlyBudget monthlyBudget)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.DeleteMonthlyBudget;
                        command.Parameters.AddWithValue("@Year", monthlyBudget.Year);
                        command.Parameters.AddWithValue("@Month", monthlyBudget.Month);

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