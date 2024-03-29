﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyLocationRepository : IDataRepository<CompanyLocationPoco>
    {
        public void Add(params CompanyLocationPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Company_Locations]
                                                   ([Id]
                                                   ,[Company]
                                                   ,[Country_Code]
                                                   ,[State_Province_Code]
                                                   ,[Street_Address]
                                                   ,[City_Town]
                                                   ,[Zip_Postal_Code])
                                             VALUES
                                                   (@Id
                                                   ,@Company
                                                   ,@Country_Code
                                                   ,@State_Province_Code
                                                   ,@Street_Address
                                                   ,@City_Town
                                                   ,@Zip_Postal_Code)";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Company", poco.Company);
                    sqlCommand.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    sqlCommand.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    sqlCommand.Parameters.AddWithValue("@Street_Address", poco.Street);
                    sqlCommand.Parameters.AddWithValue("@City_Town", poco.City);
                    sqlCommand.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);

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

        public IList<CompanyLocationPoco> GetAll(params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            var result = new List<CompanyLocationPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Company]
                                              ,[Country_Code]
                                              ,[State_Province_Code]
                                              ,[Street_Address]
                                              ,[City_Town]
                                              ,[Zip_Postal_Code]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Company_Locations]";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new CompanyLocationPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Company = (Guid)sqlDataReader[1];
                    poco.CountryCode = sqlDataReader[2] as string;
                    poco.Province = sqlDataReader[3] as string;
                    poco.Street = sqlDataReader[4] as string;
                    poco.City = sqlDataReader[5] as string;
                    poco.PostalCode = sqlDataReader[6] as string;
                    poco.TimeStamp = sqlDataReader[7] as byte[];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<CompanyLocationPoco> GetList(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyLocationPoco GetSingle(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyLocationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyLocationPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"DELETE FROM [dbo].[Company_Locations]
                                              WHERE Id=@Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params CompanyLocationPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"UPDATE [dbo].[Company_Locations]
                                                SET [Company] = @Company
                                                    ,[Country_Code] = @Country_Code
                                                    ,[State_Province_Code] = @State_Province_Code
                                                    ,[Street_Address] = @Street_Address
                                                    ,[City_Town] = @City_Town
                                                    ,[Zip_Postal_Code] = @Zip_Postal_Code
                                                WHERE [Id] = @Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Company", poco.Company);
                    sqlCommand.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    sqlCommand.Parameters.AddWithValue("@State_Province_Code", poco.Province);
                    sqlCommand.Parameters.AddWithValue("@Street_Address", poco.Street);
                    sqlCommand.Parameters.AddWithValue("@City_Town", poco.City);
                    sqlCommand.Parameters.AddWithValue("@Zip_Postal_Code", poco.PostalCode);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }
    }

}
