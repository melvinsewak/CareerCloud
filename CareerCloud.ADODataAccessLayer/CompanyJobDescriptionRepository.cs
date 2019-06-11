using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobDescriptionRepository : IDataRepository<CompanyJobDescriptionPoco>
    {
        public void Add(params CompanyJobDescriptionPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Company_Jobs_Descriptions]
                                                   ([Id]
                                                   ,[Job]
                                                   ,[Job_Name]
                                                   ,[Job_Descriptions])
                                             VALUES
                                                   (@Id
                                                   ,@Job
                                                   ,@Job_Name
                                                   ,@Job_Descriptions)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Job", poco.Job);
                    sqlCommand.Parameters.AddWithValue("@Job_Name", poco.JobName);
                    sqlCommand.Parameters.AddWithValue("@Job_Descriptions", poco.JobDescriptions);

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

        public IList<CompanyJobDescriptionPoco> GetAll(params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            var result = new List<CompanyJobDescriptionPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                            ,[Job]
                                            ,[Job_Name]
                                            ,[Job_Descriptions]
                                            ,[Time_Stamp]
                                        FROM [dbo].[Company_Jobs_Descriptions]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new CompanyJobDescriptionPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Job = (Guid)sqlDataReader[1];
                    poco.JobName = (string)sqlDataReader[2];
                    poco.JobDescriptions = (string)sqlDataReader[3];
                    poco.TimeStamp = (byte[])sqlDataReader[4];

                    result.Add(poco);
                }

                sqlConnection.Close();
            }
            return result;
        }

        public IList<CompanyJobDescriptionPoco> GetList(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobDescriptionPoco GetSingle(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyJobDescriptionPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyJobDescriptionPoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
