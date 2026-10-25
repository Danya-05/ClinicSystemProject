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
            string query = @"SELECT User_Name FROM Users_TBL";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable GetAllUsers()
        {
            string query = @"SELECT * FROM Users_TBL";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable SearchUser(string searchText)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                SELECT * FROM User_TBL
                WHERE
                User_Name LIKE @Search
                OR User_FirstNumber LIKE @Search
                OR User_LastNumber LIKE @Search
                OR CAST(User_ID AS NVARCHAR(20)) LIKE @Search";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Search", "%" + searchText.Trim() + "%");

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);
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

        public static DataTable GetAllDoctorsName()
        {
            string query = @"select (User_FirstName+' '+User_LastName) as DoctorName from Users_TBL
                                     where User_Type = 'Doctor'";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable GetAllDoctors()
        {
            string query = @"select Doctor_ID,User_FirstName,User_LastName,Doctor_Specialty,User_PhoneNumber 
                             from Doctors_TBL d inner join Users_TBL u 
                             on u.User_ID= d.User_ID";

            return clsDataAccessSettings.GetData(query);
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

        public static DataTable GetUserInfoByID(int User_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT *
                         FROM Users_TBL
                         WHERE User_ID = @User_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@User_ID", User_ID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }


    }
}
