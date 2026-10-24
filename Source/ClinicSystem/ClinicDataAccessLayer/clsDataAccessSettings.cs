using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicDataAccessLayer
{
    internal class clsDataAccessSettings
    {
        public static string connectionString =
            "Server=.;Database=ClinicSystem_Database;User Id=sa;Password =123456;";

        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

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
    }

}
