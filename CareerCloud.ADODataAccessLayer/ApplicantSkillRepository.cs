using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantSkillRepository : IDataRepository<ApplicantSkillPoco>
    {
        public void Add(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Applicant_Skills]
                                                   ([Id]
                                                   ,[Applicant]
                                                   ,[Skill]
                                                   ,[Skill_Level]
                                                   ,[Start_Month]
                                                   ,[Start_Year]
                                                   ,[End_Month]
                                                   ,[End_Year])
                                             VALUES
                                                   (@Id
                                                   ,@Applicant
                                                   ,@Skill
                                                   ,@Skill_Level
                                                   ,@Start_Month
                                                   ,@Start_Year
                                                   ,@End_Month
                                                   ,@End_Year)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    sqlCommand.Parameters.AddWithValue("@Skill", poco.Skill);
                    sqlCommand.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
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

        public IList<ApplicantSkillPoco> GetAll(params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            var result = new List<ApplicantSkillPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Applicant]
                                              ,[Skill]
                                              ,[Skill_Level]
                                              ,[Start_Month]
                                              ,[Start_Year]
                                              ,[End_Month]
                                              ,[End_Year]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Applicant_Skills]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new ApplicantSkillPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Applicant = (Guid)sqlDataReader[1];
                    poco.Skill = (sqlDataReader[2].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[2];
                    poco.SkillLevel = (sqlDataReader[3].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[3];
                    poco.StartMonth = (byte)sqlDataReader[4];
                    poco.StartYear = (int)sqlDataReader[5];
                    poco.EndMonth = (byte)sqlDataReader[6];
                    poco.EndYear = (int)sqlDataReader[7];
                    poco.TimeStamp = (sqlDataReader[8].GetType()).Equals(typeof(System.DBNull)) ? null : (byte[])sqlDataReader[8];

                    result.Add(poco);
                }

                sqlConnection.Close();
            }
            return result;
        }

        public IList<ApplicantSkillPoco> GetList(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantSkillPoco GetSingle(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"DELETE FROM [dbo].[Applicant_Skills]
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

        public void Update(params ApplicantSkillPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"UPDATE [dbo].[Applicant_Skills]
                                       SET [Applicant] = @Applicant
                                          ,[Skill] = @Skill
                                          ,[Skill_Level] = @Skill_Level
                                          ,[Start_Month] = @Start_Month
                                          ,[Start_Year] = @Start_Year
                                          ,[End_Month] = @End_Month
                                          ,[End_Year] = @End_Year
                                     WHERE [Id] = @Id",
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    sqlCommand.Parameters.AddWithValue("@Skill", poco.Skill);
                    sqlCommand.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
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
