using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobSkillRepository : IDataRepository<CompanyJobSkillPoco>
    {
        public void Add(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Company_Job_Skills]
                                                   ([Id]
                                                   ,[Job]
                                                   ,[Skill]
                                                   ,[Skill_Level]
                                                   ,[Importance])
                                             VALUES
                                                   (@Id
                                                   ,@Job
                                                   ,@Skill
                                                   ,@Skill_Level
                                                   ,@Importance)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Job", poco.Job);
                    sqlCommand.Parameters.AddWithValue("@Skill", poco.Skill);
                    sqlCommand.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
                    sqlCommand.Parameters.AddWithValue("@Importance", poco.Importance);

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

        public IList<CompanyJobSkillPoco> GetAll(params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            var result = new List<CompanyJobSkillPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Job]
                                              ,[Skill]
                                              ,[Skill_Level]
                                              ,[Importance]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Company_Job_Skills]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new CompanyJobSkillPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Job = (Guid)sqlDataReader[1];
                    poco.Skill = (string)sqlDataReader[2];
                    poco.SkillLevel = (string)sqlDataReader[3];
                    poco.Importance = (int)sqlDataReader[4];
                    poco.TimeStamp = (byte[])sqlDataReader[5];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<CompanyJobSkillPoco> GetList(Expression<Func<CompanyJobSkillPoco, bool>> where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobSkillPoco GetSingle(Expression<Func<CompanyJobSkillPoco, bool>> where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"DELETE FROM [dbo].[Company_Job_Skills]
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

        public void Update(params CompanyJobSkillPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"UPDATE [dbo].[Company_Job_Skills]
                                        SET [Job] = @Job
                                            ,[Skill] = @Skill
                                            ,[Skill_Level] = @Skill_Level
                                            ,[Importance] = @Importance
                                        WHERE [Id] = @Id",
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Job", poco.Job);
                    sqlCommand.Parameters.AddWithValue("@Skill", poco.Skill);
                    sqlCommand.Parameters.AddWithValue("@Skill_Level", poco.SkillLevel);
                    sqlCommand.Parameters.AddWithValue("@Importance", poco.Importance);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }
    }

}
