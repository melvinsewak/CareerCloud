﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginsLogRepository : IDataRepository<SecurityLoginsLogPoco>
    {
        public void Add(params SecurityLoginsLogPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Security_Logins_Log]
                                                   ([Id]
                                                   ,[Login]
                                                   ,[Source_IP]
                                                   ,[Logon_Date]
                                                   ,[Is_Succesful])
                                             VALUES
                                                   (@Id
                                                   ,@Login
                                                   ,@Source_IP
                                                   ,@Logon_Date
                                                   ,@Is_Succesful)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Login", poco.Login);
                    sqlCommand.Parameters.AddWithValue("@Source_IP", poco.SourceIP);
                    sqlCommand.Parameters.AddWithValue("@Logon_Date", poco.LogonDate);
                    sqlCommand.Parameters.AddWithValue("@Is_Succesful", poco.IsSuccesful);

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

        public IList<SecurityLoginsLogPoco> GetAll(params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            var result = new List<SecurityLoginsLogPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Login]
                                              ,[Source_IP]
                                              ,[Logon_Date]
                                              ,[Is_Succesful]
                                          FROM [dbo].[Security_Logins_Log]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new SecurityLoginsLogPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Login = (Guid)sqlDataReader[1];
                    poco.SourceIP = (string)sqlDataReader[2];
                    poco.LogonDate = (DateTime)sqlDataReader[3];
                    poco.IsSuccesful = (bool)sqlDataReader[4];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<SecurityLoginsLogPoco> GetList(Expression<Func<SecurityLoginsLogPoco, bool>> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsLogPoco GetSingle(Expression<Func<SecurityLoginsLogPoco, bool>> where, params Expression<Func<SecurityLoginsLogPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SecurityLoginsLogPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SecurityLoginsLogPoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}