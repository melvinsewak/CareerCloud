﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantProfileRepository : IDataRepository<ApplicantProfilePoco>
    {
        public void Add(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Applicant_Profiles]
                                                   ([Id]
                                                   ,[Login]
                                                   ,[Current_Salary]
                                                   ,[Current_Rate]
                                                   ,[Currency]
                                                   ,[Country_Code]
                                                   ,[State_Province_Code]
                                                   ,[Street_Address]
                                                   ,[City_Town]
                                                   ,[Zip_Postal_Code])
                                             VALUES
                                                   (@Id
                                                   ,@Login
                                                   ,@Current_Salary
                                                   ,@Current_Rate
                                                   ,@Currency
                                                   ,@Country_Code
                                                   ,@State_Province_Code
                                                   ,@Street_Address
                                                   ,@City_Town
                                                   ,@Zip_Postal_Code)";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Login", poco.Login);
                    sqlCommand.Parameters.AddWithValue("@Current_Salary", poco.CurrentSalary);
                    sqlCommand.Parameters.AddWithValue("@Current_Rate", poco.CurrentRate);
                    sqlCommand.Parameters.AddWithValue("@Currency", poco.Currency);
                    sqlCommand.Parameters.AddWithValue("@Country_Code", poco.Country);
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

        public IList<ApplicantProfilePoco> GetAll(params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            var result = new List<ApplicantProfilePoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Login]
                                              ,[Current_Salary]
                                              ,[Current_Rate]
                                              ,[Currency]
                                              ,[Country_Code]
                                              ,[State_Province_Code]
                                              ,[Street_Address]
                                              ,[City_Town]
                                              ,[Zip_Postal_Code]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Applicant_Profiles]";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new ApplicantProfilePoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Login = (Guid)sqlDataReader[1];
                    poco.CurrentSalary = sqlDataReader[2] as decimal?;
                    poco.CurrentRate = sqlDataReader[3] as decimal?;
                    poco.Currency = sqlDataReader[4] as string;
                    poco.Country = sqlDataReader[5] as string;
                    poco.Province = sqlDataReader[6] as string;
                    poco.Street = sqlDataReader[7] as string;
                    poco.City =  sqlDataReader[8] as string;
                    poco.PostalCode =  sqlDataReader[9] as string;
                    poco.TimeStamp =  sqlDataReader[10] as byte[];

                    result.Add(poco);
                }

                sqlConnection.Close();
            }
            return result;
        }

        public IList<ApplicantProfilePoco> GetList(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantProfilePoco GetSingle(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantProfilePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"DELETE FROM [dbo].[Applicant_Profiles]
                                              WHERE Id=@Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"UPDATE [dbo].[Applicant_Profiles]
                                                SET [Login] = @Login
                                                    ,[Current_Salary] = @Current_Salary
                                                    ,[Current_Rate] = @Current_Rate
                                                    ,[Currency] = @Currency
                                                    ,[Country_Code] = @Country_Code
                                                    ,[State_Province_Code] = @State_Province_Code
                                                    ,[Street_Address] = @Street_Address
                                                    ,[City_Town] = @City_Town
                                                    ,[Zip_Postal_Code] = @Zip_Postal_Code
                                                WHERE [Id] = @Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Login", poco.Login);
                    sqlCommand.Parameters.AddWithValue("@Current_Salary", poco.CurrentSalary);
                    sqlCommand.Parameters.AddWithValue("@Current_Rate", poco.CurrentRate);
                    sqlCommand.Parameters.AddWithValue("@Currency", poco.Currency);
                    sqlCommand.Parameters.AddWithValue("@Country_Code", poco.Country);
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
