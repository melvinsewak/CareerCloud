﻿using CareerCloud.DataAccessLayer;
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
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
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
            var result = new List<CompanyProfilePoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Registration_Date]
                                              ,[Company_Website]
                                              ,[Contact_Phone]
                                              ,[Contact_Name]
                                              ,[Company_Logo]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Company_Profiles]";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())   
                {
                    var poco = new CompanyProfilePoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.RegistrationDate = (DateTime)sqlDataReader[1];
                    poco.CompanyWebsite = sqlDataReader[2] as string;
                    poco.ContactPhone = sqlDataReader[3] as string;
                    poco.ContactName = sqlDataReader[4] as string;
                    poco.CompanyLogo = sqlDataReader[5] as byte[];
                    poco.TimeStamp = sqlDataReader[6] as byte[];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<CompanyProfilePoco> GetList(Expression<Func<CompanyProfilePoco, bool>> where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
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
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"DELETE FROM [dbo].[Company_Profiles]
                                              WHERE Id=@Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params CompanyProfilePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"UPDATE [dbo].[Company_Profiles]
                                                SET [Registration_Date] = @Registration_Date
                                                    ,[Company_Website] = @Company_Website
                                                    ,[Contact_Phone] = @Contact_Phone
                                                    ,[Contact_Name] = @Contact_Name
                                                    ,[Company_Logo] = @Company_Logo
                                                WHERE [Id] = @Id";

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
    }

}
