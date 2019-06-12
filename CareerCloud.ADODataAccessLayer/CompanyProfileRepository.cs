using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyProfileRepository : IDataRepository<CompanyProfilePoco>
    {
        public void Add(params CompanyProfilePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Company_Profiles]
                                                   ([Id]
                                                   ,[Registration_Date]
                                                   ,[Company_Website]
                                                   ,[Contact_Phone]
                                                   ,[Contact_Name]
                                                   ,[Company_Logo])
                                             VALUES
                                                   (@Id
                                                   ,@Registration_Date
                                                   ,@Company_Website
                                                   ,@Contact_Phone
                                                   ,@Contact_Name
                                                   ,@Company_Logo)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Registration_Date", poco.RegistrationDate);
                    sqlCommand.Parameters.AddWithValue("@Company_Website", poco.CompanyWebsite);
                    sqlCommand.Parameters.AddWithValue("@Contact_Phone", poco.ContactPhone);
                    sqlCommand.Parameters.AddWithValue("@Contact_Name", poco.ContactName);
                    sqlCommand.Parameters.AddWithValue("@Company_Logo", poco.CompanyLogo);

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

        public IList<CompanyProfilePoco> GetAll(params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyProfilePoco> GetList(Expression<Func<CompanyProfilePoco, bool>> where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            var result = new List<CompanyProfilePoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Registration_Date]
                                              ,[Company_Website]
                                              ,[Contact_Phone]
                                              ,[Contact_Name]
                                              ,[Company_Logo]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Company_Profiles]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new CompanyProfilePoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.RegistrationDate = (DateTime)sqlDataReader[1];
                    poco.CompanyWebsite = (string)sqlDataReader[2];
                    poco.ContactPhone = (string)sqlDataReader[3];
                    poco.ContactName = (string)sqlDataReader[4];
                    poco.CompanyLogo = (byte[])sqlDataReader[5];
                    poco.TimeStamp = (byte[])sqlDataReader[6];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public CompanyProfilePoco GetSingle(Expression<Func<CompanyProfilePoco, bool>> where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyProfilePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyProfilePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"DELETE FROM [dbo].[Company_Profiles]
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

        public void Update(params CompanyProfilePoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
