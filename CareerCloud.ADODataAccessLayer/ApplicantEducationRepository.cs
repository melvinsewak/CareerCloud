using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
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
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
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
            var result = new List<ApplicantEducationPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Applicant]
                                              ,[Major]
                                              ,[Certificate_Diploma]
                                              ,[Start_Date]
                                              ,[Completion_Date]
                                              ,[Completion_Percent]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Applicant_Educations]";

                sqlConnection.Open();
                SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new ApplicantEducationPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Applicant = (Guid)sqlDataReader[1];
                    poco.Major = (sqlDataReader[2].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[2];
                    poco.CertificateDiploma = (sqlDataReader[3].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[3];
                    poco.StartDate = (sqlDataReader[4].GetType()).Equals(typeof(System.DBNull)) ? null : (DateTime?)sqlDataReader[4];
                    poco.CompletionDate = (sqlDataReader[5].GetType()).Equals(typeof(System.DBNull)) ? null : (DateTime?)sqlDataReader[5];
                    poco.CompletionPercent = (sqlDataReader[6].GetType()).Equals(typeof(System.DBNull)) ? null : (byte?)sqlDataReader[6];
                    poco.TimeStamp = (sqlDataReader[7].GetType()).Equals(typeof(System.DBNull)) ? null : (byte[])sqlDataReader[7];

                    result.Add(poco);
                }

                sqlConnection.Close();
            }
            return result;
        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            IQueryable <ApplicantEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantEducationPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"DELETE FROM [dbo].[Applicant_Educations]
                                              WHERE Id=@Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params ApplicantEducationPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"UPDATE [dbo].[Applicant_Educations]
                                                SET [Applicant] = @Applicant
                                                    ,[Major] = @Major
                                                    ,[Certificate_Diploma] = @Certificate_Diploma
                                                    ,[Start_Date] = @Start_Date
                                                    ,[Completion_Date] = @Completion_Date
                                                    ,[Completion_Percent] = @Completion_Percent
                                                WHERE [Id] = @Id";

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
    }

}
