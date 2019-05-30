using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using Models.Models;
using Repository.Helpers;

namespace Repository.Repository
{
    internal class CategoryRepository
    {
        internal List<Category> GetAll()
        {
            var categories = new List<Category>();

            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.GetCategories;

                        using (var dr = command.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                var category = new Category
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Name = dr["Name"].ToString(),
                                    ColorText = dr["Color"].ToString()
                                };

                                categories.Add(category);
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

            return categories;
        }

        internal void Add(Category category)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.AddCategory;
                        command.Parameters.AddWithValue("@Name", category.Name);
                        command.Parameters.AddWithValue("@Color", category.ColorText);
                        
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    category.Id = connection.LastInsertRowId;
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        internal void Edit(Category category)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.EditCategory;
                        command.Parameters.AddWithValue("@Name", category.Name);
                        command.Parameters.AddWithValue("@Color", category.ColorText);
                        command.Parameters.AddWithValue("@Id", category.Id);

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

        internal void Delete(Category category)
        {
            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.DeleteCategory;
                        command.Parameters.AddWithValue("@CategoryId", category.Id);

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

        internal bool IsCategoryUsed(Category category)
        {
            var isCategoryUsed = false;

            using (var connection = new SQLiteConnection(SQLiteConnectionStringHelper.GetConnectionString()))
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = SqlQuerries.IsCategoryUsed;
                        command.Parameters.AddWithValue("@CategoryId", category.Id);

                        using (var dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                isCategoryUsed = Convert.ToBoolean(dr[0]);
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

            return isCategoryUsed;
        }
    }
}