﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantResumeRepository : IDataRepository<ApplicantResumePoco>
    {
        public void Add(params ApplicantResumePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Applicant_Resumes]
                                                   ([Id]
                                                   ,[Applicant]
                                                   ,[Resume]
                                                   ,[Last_Updated])
                                             VALUES
                                                   (@Id
                                                   ,@Applicant
                                                   ,@Resume
                                                   ,@Last_Updated)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    sqlCommand.Parameters.AddWithValue("@Resume", poco.Resume);
                    sqlCommand.Parameters.AddWithValue("@Last_Updated", poco.LastUpdated);

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

        public IList<ApplicantResumePoco> GetAll(params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            var result = new List<ApplicantResumePoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = @"SELECT [Id]
                                              ,[Applicant]
                                              ,[Resume]
                                              ,[Last_Updated] 
                                          FROM [dbo].[Applicant_Resumes]";
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new ApplicantResumePoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Applicant = (Guid)sqlDataReader[1];
                    poco.Resume = (sqlDataReader[2].GetType()).Equals(typeof(System.DBNull)) ? null : (string)sqlDataReader[2];

                    //PATCH FIX: To avoid error, added check on type
                    poco.LastUpdated = (sqlDataReader[3].GetType()).Equals(typeof(System.DBNull)) ?null: (DateTime?)sqlDataReader[3];

                    result.Add(poco);
                }

                sqlConnection.Close();
            }
            return result;
        }

        public IList<ApplicantResumePoco> GetList(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantResumePoco GetSingle(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantResumePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantResumePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"DELETE FROM [dbo].[Applicant_Resumes]
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

        public void Update(params ApplicantResumePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand
                    {
                        CommandText = @"UPDATE [dbo].[Applicant_Resumes]
                                       SET [Applicant] = @Applicant
                                          ,[Resume] = @Resume
                                          ,[Last_Updated] = @Last_Updated
                                     WHERE [Id] = @Id",
                        Connection = sqlConnection
                    };

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Applicant", poco.Applicant);
                    sqlCommand.Parameters.AddWithValue("@Resume", poco.Resume);
                    sqlCommand.Parameters.AddWithValue("@Last_Updated", poco.LastUpdated);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }
    }

}
