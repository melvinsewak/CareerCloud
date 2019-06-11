using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class SystemCountryCodeRepository : IDataRepository<SystemCountryCodePoco>
    {
        public void Add(params SystemCountryCodePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[System_Country_Codes]
                                                ([Code]
                                                ,[Name])
                                            VALUES
                                                (@Code
                                                ,@Name)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Code", poco.Code);
                    sqlCommand.Parameters.AddWithValue("@Name", poco.Name);

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

        public IList<SystemCountryCodePoco> GetAll(params Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            var result = new List<SystemCountryCodePoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Code]
                                            ,[Name]
                                        FROM [dbo].[System_Country_Codes]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new SystemCountryCodePoco();
                    poco.Code = (string)sqlDataReader[0];
                    poco.Name = (string)sqlDataReader[1];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<SystemCountryCodePoco> GetList(Expression<Func<SystemCountryCodePoco, bool>> where, params Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemCountryCodePoco GetSingle(Expression<Func<SystemCountryCodePoco, bool>> where, params Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
