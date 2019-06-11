using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantWorkHistoryRepository : IDataRepository<ApplicantWorkHistoryPoco>
    {
        public void Add(params ApplicantWorkHistoryPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
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
                    sqlCommand.Connection = sqlConnection;

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
            throw new NotImplementedException();
        }

        public IList<ApplicantWorkHistoryPoco> GetList(Expression<Func<ApplicantWorkHistoryPoco, bool>> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantWorkHistoryPoco GetSingle(Expression<Func<ApplicantWorkHistoryPoco, bool>> where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantWorkHistoryPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantWorkHistoryPoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
