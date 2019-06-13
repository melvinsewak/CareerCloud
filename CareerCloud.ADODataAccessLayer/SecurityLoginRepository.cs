using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginRepository : IDataRepository<SecurityLoginPoco>
    {
        public void Add(params SecurityLoginPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
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
            var result = new List<SecurityLoginPoco>();

            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = @"SELECT [Id]
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
                                              ,[Prefferred_Language]
                                              ,[Time_Stamp]
                                          FROM [dbo].[Security_Logins]";

                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var poco = new SecurityLoginPoco();
                    poco.Id = (Guid)sqlDataReader[0];
                    poco.Login = sqlDataReader[1] as string;
                    poco.Password = sqlDataReader[2] as string;
                    poco.Created = (DateTime)sqlDataReader[3];
                    poco.PasswordUpdate = sqlDataReader[4] as DateTime?;
                    poco.AgreementAccepted = sqlDataReader[5] as DateTime?;
                    poco.IsLocked = (bool)sqlDataReader[6];
                    poco.IsInactive = (bool)sqlDataReader[7];
                    poco.EmailAddress = sqlDataReader[8] as string;
                    poco.PhoneNumber = sqlDataReader[9] as string;
                    poco.FullName = sqlDataReader[10] as string;
                    poco.ForceChangePassword = (bool)sqlDataReader[11];
                    poco.PrefferredLanguage = sqlDataReader[12] as string;
                    poco.TimeStamp = sqlDataReader[13] as byte[];

                    result.Add(poco);
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<SecurityLoginPoco> GetList(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingle(Expression<Func<SecurityLoginPoco, bool>> where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            IQueryable<SecurityLoginPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SecurityLoginPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"DELETE FROM [dbo].[Security_Logins]
                                              WHERE Id=@Id";

                    sqlCommand.Parameters.AddWithValue("@Id", poco.Id);

                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }

        public void Update(params SecurityLoginPoco[] items)
        {
            using (SqlConnection sqlConnection = new SqlConnection(SqlUtility.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                foreach (var poco in items)
                {
                    sqlCommand.CommandText = @"UPDATE [dbo].[Security_Logins]
                                                SET [Login] = @Login
                                                    ,[Password] = @Password
                                                    ,[Created_Date] = @Created_Date
                                                    ,[Password_Update_Date] = @Password_Update_Date
                                                    ,[Agreement_Accepted_Date] = @Agreement_Accepted_Date
                                                    ,[Is_Locked] = @Is_Locked
                                                    ,[Is_Inactive] = @Is_Inactive
                                                    ,[Email_Address] = @Email_Address
                                                    ,[Phone_Number] = @Phone_Number
                                                    ,[Full_Name] = @Full_Name
                                                    ,[Force_Change_Password] = @Force_Change_Password
                                                    ,[Prefferred_Language] = @Prefferred_Language
                                                WHERE [Id] = @Id";

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
    }

}
