using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyDescriptionRepository : IDataRepository<CompanyDescriptionPoco>
    {
        public void Add(params CompanyDescriptionPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Company_Descriptions]
                                                   ([Id]
                                                   ,[Company]
                                                   ,[LanguageID]
                                                   ,[Company_Name]
                                                   ,[Company_Description])
                                             VALUES
                                                   (@Id
                                                   ,@Company
                                                   ,@LanguageID
                                                   ,@Company_Name
                                                   ,@Company_Description)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Company", poco.Company);
                    sqlCommand.Parameters.AddWithValue("@LanguageID", poco.LanguageId);
                    sqlCommand.Parameters.AddWithValue("@Company_Name", poco.CompanyName);
                    sqlCommand.Parameters.AddWithValue("@Company_Description", poco.CompanyDescription);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyDescriptionPoco> GetAll(params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            var result = new List<CompanyDescriptionPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Company]
                                              ,[LanguageID]
                                              ,[Company_Name]
                                              ,[Company_Description]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Company_Descriptions]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new CompanyDescriptionPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Company = (Guid)sqlDataReader[1];
                    poco.LanguageId = (sqlDataReader[2].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[2];
                    poco.CompanyName = (sqlDataReader[3].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[3];
                    poco.CompanyDescription = (sqlDataReader[4].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[4];
                    poco.TimeStamp = (sqlDataReader[5].GetType()).Equals(typeof(System.DBNull)) ? null : (byte[])sqlDataReader[5];

                    result.Add(poco);
                }

                sqlConnection.Close();
            }
            return result;
        }

        public IList<CompanyDescriptionPoco> GetList(Expression<Func<CompanyDescriptionPoco, bool>> where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyDescriptionPoco GetSingle(Expression<Func<CompanyDescriptionPoco, bool>> where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyDescriptionPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"DELETE FROM [dbo].[Company_Descriptions]
                                              WHERE Id=@Id",
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params CompanyDescriptionPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"UPDATE [dbo].[Company_Descriptions]
                                        SET [Company] = @Company
                                            ,[LanguageID] = @LanguageID
                                            ,[Company_Name] = @Company_Name
                                            ,[Company_Description] = @Company_Description
                                        WHERE [Id] = @Id",
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Company", poco.Company);
                    sqlCommand.Parameters.AddWithValue("@LanguageID", poco.LanguageId);
                    sqlCommand.Parameters.AddWithValue("@Company_Name", poco.CompanyName);
                    sqlCommand.Parameters.AddWithValue("@Company_Description", poco.CompanyDescription);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }
    }

}
