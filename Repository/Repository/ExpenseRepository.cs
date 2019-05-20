using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Models.Models;
using Repository.Helpers;

namespace Repository.Repository
{
    internal class ExpenseRepository
    {
        internal Expense GetById(int id)
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

        internal List<Expense> GetByDate(DateTime date)
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

        internal List<Expense> GetByMonth(int year, int month)
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

        internal void Add(Expense expense)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.AddExpense;
                        command.Parameters.AddWithValue("@CategoryId", expense.CategoryId);
                        command.Parameters.AddWithValue("@Value", expense.Value);
                        command.Parameters.AddWithValue("@Year", expense.Year);
                        command.Parameters.AddWithValue("@Month", expense.Month);
                        command.Parameters.AddWithValue("@Day", expense.Day);
                        command.Parameters.AddWithValue("@Date", expense.Date);
                        command.Parameters.AddWithValue("@Description", expense.Description);
                        command.Parameters.AddWithValue("@ModificationTime", expense.ModificationTime);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    expense.Id = connection.LastInsertRowId;
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        internal void Edit(Expense expense)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.EditExpense;
                        command.Parameters.AddWithValue("@CategoryId", expense.CategoryId);
                        command.Parameters.AddWithValue("@Value", expense.Value);
                        command.Parameters.AddWithValue("@Year", expense.Year);
                        command.Parameters.AddWithValue("@Month", expense.Month);
                        command.Parameters.AddWithValue("@Day", expense.Day);
                        command.Parameters.AddWithValue("@Date", expense.Date);
                        command.Parameters.AddWithValue("@Description", expense.Description);
                        command.Parameters.AddWithValue("@ModificationTime", expense.ModificationTime);
                        command.Parameters.AddWithValue("@Id", expense.Id);

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

        internal void Delete(Expense expense)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.DeleteExpense;
                        command.Parameters.AddWithValue("@Id", expense.Id);

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