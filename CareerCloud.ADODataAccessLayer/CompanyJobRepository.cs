using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobRepository : IDataRepository<CompanyJobPoco>
    {
        public void Add(params CompanyJobPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Company_Jobs]
                                                   ([Id]
                                                   ,[Company]
                                                   ,[Profile_Created]
                                                   ,[Is_Inactive]
                                                   ,[Is_Company_Hidden])
                                             VALUES
                                                   (@Id
                                                   ,@Company
                                                   ,@Profile_Created
                                                   ,@Is_Inactive
                                                   ,@Is_Company_Hidden)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Company", poco.Company);
                    sqlCommand.Parameters.AddWithValue("@Profile_Created", poco.ProfileCreated);
                    sqlCommand.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    sqlCommand.Parameters.AddWithValue("@Is_Company_Hidden", poco.IsCompanyHidden);

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

        public IList<CompanyJobPoco> GetAll(params Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            var result = new List<CompanyJobPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                            ,[Company]
                                            ,[Profile_Created]
                                            ,[Is_Inactive]
                                            ,[Is_Company_Hidden]
                                            ,[Time_Stamp]
                                        FROM [dbo].[Company_Jobs]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new CompanyJobPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Company = (Guid)sqlDataReader[1];
                    poco.ProfileCreated = (DateTime)sqlDataReader[2];
                    poco.IsInactive = (bool)sqlDataReader[3];
                    poco.IsCompanyHidden = (bool)sqlDataReader[4];
                    poco.TimeStamp = (byte[])sqlDataReader[5];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<CompanyJobPoco> GetList(Expression<Func<CompanyJobPoco, bool>> where, params Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobPoco GetSingle(Expression<Func<CompanyJobPoco, bool>> where, params Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"DELETE FROM [dbo].[Company_Jobs]
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

        public void Update(params CompanyJobPoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
