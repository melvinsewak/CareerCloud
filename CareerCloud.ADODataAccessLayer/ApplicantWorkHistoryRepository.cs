﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantWorkHistoryRepository : IDataRepository<ApplicantWorkHistoryPoco>
    {
        public void Add(params ApplicantWorkHistoryPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Applicant_Work_History]
                                                   ([Id]
                                                   ,[Applicant]
                                                   ,[Company_Name]
                                                   ,[Country_Code]
                                                   ,[Location]
                                                   ,[Job_Title]
                                                   ,[Job_Description]
                                                   ,[Start_Month]
                                                   ,[Start_Year]
                                                   ,[End_Month]
                                                   ,[End_Year])
                                             VALUES
                                                   (@Id
                                                   ,@Applicant
                                                   ,@Company_Name
                                                   ,@Country_Code
                                                   ,@Location
                                                   ,@Job_Title
                                                   ,@Job_Description
                                                   ,@Start_Month
                                                   ,@Start_Year
                                                   ,@End_Month
                                                   ,@End_Year)";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    sqlCommand.Parameters.AddWithValue("@Company_Name", poco.CompanyName);
                    sqlCommand.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    sqlCommand.Parameters.AddWithValue("@Location", poco.Location);
                    sqlCommand.Parameters.AddWithValue("@Job_Title", poco.JobTitle);
                    sqlCommand.Parameters.AddWithValue("@Job_Description", poco.JobDescription);
                    sqlCommand.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                    sqlCommand.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                    sqlCommand.Parameters.AddWithValue("@End_Month", poco.EndMonth);
                    sqlCommand.Parameters.AddWithValue("@End_Year", poco.EndYear);

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

        public IList<ApplicantWorkHistoryPoco> GetAll(params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            var result = new List<ApplicantWorkHistoryPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Applicant]
                                              ,[Company_Name]
                                              ,[Country_Code]
                                              ,[Location]
                                              ,[Job_Title]
                                              ,[Job_Description]
                                              ,[Start_Month]
                                              ,[Start_Year]
                                              ,[End_Month]
                                              ,[End_Year]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Applicant_Work_History]";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new ApplicantWorkHistoryPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Applicant = (Guid)sqlDataReader[1];
                    poco.CompanyName = sqlDataReader[2] as string;
                    poco.CountryCode = sqlDataReader[3] as string;
                    poco.Location = sqlDataReader[4] as string;
                    poco.JobTitle = sqlDataReader[5] as string;
                    poco.JobDescription = sqlDataReader[6] as string;
                    poco.StartMonth = (short)sqlDataReader[7];
                    poco.StartYear = (int)sqlDataReader[8];
                    poco.EndMonth = (short)sqlDataReader[9];
                    poco.EndYear = (int)sqlDataReader[10];
                    poco.TimeStamp = sqlDataReader[11] as byte[];

                    result.Add(poco);
                }

                sqlConnection.Close();
            }
            return result;
        }

        public IList<ApplicantWorkHistoryPoco> GetList(Expression<Func<ApplicantWorkHistoryPoco, bool>> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantWorkHistoryPoco GetSingle(Expression<Func<ApplicantWorkHistoryPoco, bool>> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantWorkHistoryPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantWorkHistoryPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"DELETE FROM [dbo].[Applicant_Work_History]
                                              WHERE Id=@Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params ApplicantWorkHistoryPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"UPDATE [dbo].[Applicant_Work_History]
                                                SET [Applicant] = @Applicant
                                                    ,[Company_Name] = @Company_Name
                                                    ,[Country_Code] = @Country_Code
                                                    ,[Location] = @Location
                                                    ,[Job_Title] = @Job_Title
                                                    ,[Job_Description] = @Job_Description
                                                    ,[Start_Month] = @Start_Month
                                                    ,[Start_Year] = @Start_Year
                                                    ,[End_Month] = @End_Month
                                                    ,[End_Year] = @End_Year
                                                WHERE [Id] = @Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    sqlCommand.Parameters.AddWithValue("@Company_Name", poco.CompanyName);
                    sqlCommand.Parameters.AddWithValue("@Country_Code", poco.CountryCode);
                    sqlCommand.Parameters.AddWithValue("@Location", poco.Location);
                    sqlCommand.Parameters.AddWithValue("@Job_Title", poco.JobTitle);
                    sqlCommand.Parameters.AddWithValue("@Job_Description", poco.JobDescription);
                    sqlCommand.Parameters.AddWithValue("@Start_Month", poco.StartMonth);
                    sqlCommand.Parameters.AddWithValue("@Start_Year", poco.StartYear);
                    sqlCommand.Parameters.AddWithValue("@End_Month", poco.EndMonth);
                    sqlCommand.Parameters.AddWithValue("@End_Year", poco.EndYear);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }
    }

}
