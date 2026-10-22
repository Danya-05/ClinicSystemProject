using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsUserDataAccess
    {
        public static int AddNewUser(string User_Name, string User_Password,
     string User_Type, string User_FirstName, string User_LastName, string User_PhoneNumber)
        {
            int User_ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Users_TBL (User_Name,User_Password,User_Type,User_FirstName,
                             User_LastName,User_PhoneNumber)
                        VALUES (@User_Name,@User_Password,@User_Type,@User_FirstName,@User_LastName,@User_PhoneNumber);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_Name", User_Name);
            command.Parameters.AddWithValue("@User_Password", User_Password);
            command.Parameters.AddWithValue("@User_Type", User_Type);

            command.Parameters.AddWithValue("@User_FirstName", string.IsNullOrEmpty(User_FirstName) ? (object)DBNull.Value : User_FirstName);
            command.Parameters.AddWithValue("@User_LastName", string.IsNullOrEmpty(User_LastName) ? (object)DBNull.Value : User_LastName);
            command.Parameters.AddWithValue("@User_PhoneNumber", string.IsNullOrEmpty(User_PhoneNumber) ? (object)DBNull.Value : User_PhoneNumber);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    User_ID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add New Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return User_ID;
        }

        public static bool UpdateUser(int User_ID,string User_Name, string User_Password,
     string User_Type, string User_FirstName, string User_LastName, string User_PhoneNumber)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Users_TBL set User_Name = @User_Name,
                                             User_Password = @User_Password,
                                             User_Type = @User_Type,
                                             User_FirstName = @User_FirstName,
                                             User_LastName = @User_LastName,
                                             User_PhoneNumber = @User_PhoneNumber
                                    where User_ID = @User_ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@User_ID", User_ID);
            command.Parameters.AddWithValue("@User_Name", User_Name);
            command.Parameters.AddWithValue("@User_Password", User_Password);
            command.Parameters.AddWithValue("@User_Type", User_Type);

            command.Parameters.AddWithValue("@User_FirstName", string.IsNullOrEmpty(User_FirstName) ? (object)DBNull.Value : User_FirstName);
            command.Parameters.AddWithValue("@User_LastName", string.IsNullOrEmpty(User_LastName) ? (object)DBNull.Value : User_LastName);
            command.Parameters.AddWithValue("@User_PhoneNumber", string.IsNullOrEmpty(User_PhoneNumber) ? (object)DBNull.Value : User_PhoneNumber);

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);
        }

        public static bool DeleteUser(int User_ID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete from Users_TBL where User_ID = @User_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User_ID", User_ID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deletion Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);
        }

        public static DataTable GetAllUsersName()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT User_Name FROM Users_TBL";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool Login(string User_Name, string password)
        {
            string passwordHash = "";

            string query = @"SELECT User_Password FROM Users_TBL WHERE User_Name = @User_Name";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@User_Name",User_Name);

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                   return false;

                passwordHash = result.ToString();
            }
            

            return (password == passwordHash);
        }

    }
}
