using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Models.Models;
using Repository.Helpers;

namespace Repository.Repository
{
    public class ExpenseRepository
    {
        public Expense GetById(int id)
        {
            Expense expense = null;

            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.GetExpenseById;
                        command.Parameters.AddWithValue("@Id", id);

                        using (var dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                expense = new Expense
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                                    Value = Convert.ToDecimal(dr["Value"]),
                                    Year = Convert.ToInt32(dr["Year"]),
                                    Month = Convert.ToInt32(dr["Month"]),
                                    Day = Convert.ToInt32(dr["Day"]),
                                    Date = Convert.ToDateTime(dr["Date"].ToString()),
                                    Description = dr["Description"].ToString(),
                                    ModificationTime = Convert.ToDateTime(dr["ModificationTime"].ToString())
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

            return expense;
        }

        public List<Expense> GetByDate(DateTime date)
        {
            List<Expense> expenses = new List<Expense>();

            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.GetExpensesByDate;
                        command.Parameters.AddWithValue("@Year", date.Year);
                        command.Parameters.AddWithValue("@Month", date.Month);
                        command.Parameters.AddWithValue("@Day", date.Day);

                        using (var dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var expense = new Expense
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                                    Value = Convert.ToDecimal(dr["Value"]),
                                    Year = Convert.ToInt32(dr["Year"]),
                                    Month = Convert.ToInt32(dr["Month"]),
                                    Day = Convert.ToInt32(dr["Day"]),
                                    Date = Convert.ToDateTime(dr["Date"].ToString()),
                                    Description = dr["Description"].ToString(),
                                    ModificationTime = Convert.ToDateTime(dr["ModificationTime"].ToString())
                                };

                                expenses.Add(expense);
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

            return expenses;
        }

        public List<Expense> GetByMonth(int year, int month)
        {
            List<Expense> expenses = new List<Expense>();

            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.GetExpensesByMonth;
                        command.Parameters.AddWithValue("@Year", year);
                        command.Parameters.AddWithValue("@Month", month);

                        using (var dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var expense = new Expense
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    CategoryId = Convert.ToInt32(dr["CategoryId"]),
                                    Value = Convert.ToDecimal(dr["Value"]),
                                    Year = Convert.ToInt32(dr["Year"]),
                                    Month = Convert.ToInt32(dr["Month"]),
                                    Day = Convert.ToInt32(dr["Day"]),
                                    Date = Convert.ToDateTime(dr["Date"].ToString()),
                                    Description = dr["Description"].ToString(),
                                    ModificationTime = Convert.ToDateTime(dr["ModificationTime"].ToString())
                                };

                                expenses.Add(expense);
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

            return expenses;
        }
        //todo
        public void Add(int year, int month, decimal budgetValue)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.AddCategory;
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