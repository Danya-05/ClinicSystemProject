using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsInsuranceDataAccess
    {
        public static int AddNewInsurance(decimal Insurance_Rate, DateTime? Insurance_ExpiryDate,int Patient_ID)
        {
            int Insurance_ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Health_Insurance_TBL (Insurance_Rate,Insurance_ExpiryDate,Patient_ID)
                        VALUES (@Insurance_Rate,@Insurance_ExpiryDate,@Patient_ID);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Insurance_Rate", Insurance_Rate);
            command.Parameters.AddWithValue("@Insurance_ExpiryDate", (object)Insurance_ExpiryDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@Patient_ID", Patient_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Insurance_ID = InsertedID;
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
            return Insurance_ID;
        }

        public static bool UpdateInsurance(decimal Insurance_Rate, DateTime? Insurance_ExpiryDate, int Patient_ID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Health_Insurance_TBL set Insurance_Rate = @Insurance_Rate,
                                             Insurance_ExpiryDate = @Insurance_ExpiryDate
                                    where Patient_ID = @Patient_ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Patient_ID", Patient_ID);
            command.Parameters.AddWithValue("@Insurance_Rate", Insurance_Rate);
            command.Parameters.AddWithValue("@Insurance_ExpiryDate", (object)Insurance_ExpiryDate ?? DBNull.Value);
            
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

        public static DataTable GetInsuranceByPatientID(int Patient_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT *
                         FROM Health_Insurance_TBL
                         WHERE Patient_ID = @Patient_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Patient_ID", Patient_ID);

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
