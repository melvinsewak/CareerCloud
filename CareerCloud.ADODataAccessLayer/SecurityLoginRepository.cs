using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginRepository : IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                foreach (var poco in items)
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = @"INSERT INTO [dbo].[Security_Logins]
                                                   ([Id]
                                                   ,[Login]
                                                   ,[Password]
                                                   ,[Created_Date]
                                                   ,[Password_Update_Date]
                                                   ,[Agreement_Accepted_Date]
                                                   ,[Is_Locked]
                                                   ,[Is_Inactive]
                                                   ,[Email_Address]
                                                   ,[Phone_Number]
                                                   ,[Full_Name]
                                                   ,[Force_Change_Password]
                                                   ,[Prefferred_Language])
                                             VALUES
                                                   (@Id
                                                   ,@Login
                                                   ,@Password
                                                   ,@Created_Date
                                                   ,@Password_Update_Date
                                                   ,@Agreement_Accepted_Date
                                                   ,@Is_Locked
                                                   ,@Is_Inactive
                                                   ,@Email_Address
                                                   ,@Phone_Number
                                                   ,@Full_Name
                                                   ,@Force_Change_Password
                                                   ,@Prefferred_Language)";
                    sqlCommand.Connection = sqlConnection;

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);
                    sqlCommand.Parameters.AddWithValue("@Login", poco.Login);
                    sqlCommand.Parameters.AddWithValue("@Password", poco.Password);
                    sqlCommand.Parameters.AddWithValue("@Created_Date", poco.Created);
                    sqlCommand.Parameters.AddWithValue("@Password_Update_Date", poco.PasswordUpdate);
                    sqlCommand.Parameters.AddWithValue("@Agreement_Accepted_Date", poco.AgreementAccepted);
                    sqlCommand.Parameters.AddWithValue("@Is_Locked", poco.IsLocked);
                    sqlCommand.Parameters.AddWithValue("@Is_Inactive", poco.IsInactive);
                    sqlCommand.Parameters.AddWithValue("@Email_Address", poco.EmailAddress);
                    sqlCommand.Parameters.AddWithValue("@Phone_Number", poco.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Full_Name", poco.FullName);
                    sqlCommand.Parameters.AddWithValue("@Force_Change_Password", poco.ForceChangePassword);
                    sqlCommand.Parameters.AddWithValue("@Prefferred_Language", poco.PrefferredLanguage);

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

        public IList<SecurityLoginPoco> GetAll(params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginPoco> GetList(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingle(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }
    }

}
