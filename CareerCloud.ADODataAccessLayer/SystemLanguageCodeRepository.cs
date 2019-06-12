using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class SystemLanguageCodeRepository : IDataRepository<SystemLanguageCodePoco>
    {
        public void Add(params SystemLanguageCodePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[System_Language_Codes]
                                                   ([LanguageID]
                                                   ,[Name]
                                                   ,[Native_Name])
                                             VALUES
                                                   (@LanguageID
                                                   ,@Name
                                                   ,@Native_Name)";

                    sqlCommand.Parameters.AddWithValue("@LanguageID", poco.LanguageID);
                    sqlCommand.Parameters.AddWithValue("@Name", poco.Name);
                    sqlCommand.Parameters.AddWithValue("@Native_Name", poco.NativeName);

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

        public IList<SystemLanguageCodePoco> GetAll(params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            var result = new List<SystemLanguageCodePoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [LanguageID]
                                            ,[Name]
                                            ,[Native_Name]
                                        FROM [dbo].[System_Language_Codes]";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new SystemLanguageCodePoco();
                    poco.LanguageID = (sqlDataReader[0].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[0];
                    poco.Name = (sqlDataReader[1].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[1];
                    poco.NativeName = (sqlDataReader[2].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[2];
                     
                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<SystemLanguageCodePoco> GetList(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemLanguageCodePoco GetSingle(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            IQueryable<SystemLanguageCodePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SystemLanguageCodePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"DELETE FROM [dbo].[System_Language_Codes]
                                              WHERE LanguageID=@LanguageID";

                    sqlCommand.Parameters.AddWithValue("@LanguageID", poco.LanguageID);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params SystemLanguageCodePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"UPDATE [dbo].[System_Language_Codes]
                                                SET [Name] = @Name
                                                    ,[Native_Name] = @Native_Name
                                                WHERE [LanguageID] = @LanguageID";

                    sqlCommand.Parameters.AddWithValue("@LanguageID", poco.LanguageID);
                    sqlCommand.Parameters.AddWithValue("@Name", poco.Name);
                    sqlCommand.Parameters.AddWithValue("@Native_Name", poco.NativeName);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }
    }

}
