using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantEducationRepository : IDataRepository<ApplicantEducationPoco>
    {
        public void Add(params ApplicantEducationPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Applicant_Educations]
                                                   ([Id]
                                                   ,[Applicant]
                                                   ,[Major]
                                                   ,[Certificate_Diploma]
                                                   ,[Start_Date]
                                                   ,[Completion_Date]
                                                   ,[Completion_Percent])
                                             VALUES
                                                   (@Id
                                                   ,@Applicant
                                                   ,@Major
                                                   ,@Certificate_Diploma
                                                   ,@Start_Date
                                                   ,@Completion_Date
                                                   ,@Completion_Percent)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    sqlCommand.Parameters.AddWithValue("@Major", poco.Major);
                    sqlCommand.Parameters.AddWithValue("@Certificate_Diploma", poco.CertificateDiploma);
                    sqlCommand.Parameters.AddWithValue("@Start_Date", poco.StartDate);
                    sqlCommand.Parameters.AddWithValue("@Completion_Date", poco.CompletionDate);
                    sqlCommand.Parameters.AddWithValue("@Completion_Percent", poco.CompletionPercent);

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

        public IList<ApplicantEducationPoco> GetAll(params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantEducationPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantEducationPoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
