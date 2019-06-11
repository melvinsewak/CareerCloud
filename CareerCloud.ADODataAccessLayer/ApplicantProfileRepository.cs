using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantProfileRepository : IDataRepository<ApplicantProfilePoco>
    {
        public void Add(params ApplicantProfilePoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
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
                    sqlCommand.Connection = sqlConnection;

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
            throw new NotImplementedException();
        }

        public IList<ApplicantProfilePoco> GetList(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantProfilePoco GetSingle(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantProfilePoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
