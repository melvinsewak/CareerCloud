using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class SystemLanguageCodeRepository : IDataRepository<SystemLanguageCodePoco>
    {
        public void Add(params SystemLanguageCodePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[System_Language_Codes]
                                                   ([LanguageID]
                                                   ,[Name]
                                                   ,[Native_Name])
                                             VALUES
                                                   (@LanguageID
                                                   ,@Name
                                                   ,@Native_Name)";
                    sqlCommand.Connection = sqlConnection;

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
                sqlCommand.CommandText = @"SELECT [LanguageID]
                                            ,[Name]
                                            ,[Native_Name]
                                        FROM [dbo].[System_Language_Codes]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new SystemLanguageCodePoco();
                    poco.LanguageID = (string)sqlDataReader[0];
                    poco.Name = (string)sqlDataReader[1];
                    poco.NativeName = (string)sqlDataReader[2];

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
            throw new NotImplementedException();
        }

        public void Remove(params SystemLanguageCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SystemLanguageCodePoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
