using System;
using System.Data;
using System.Data.SqlClient;

namespace ClinicDataAccessLayer
{
    public class clsPatientDataAccess
    {
        public static int AddNewPatient(string FirstName, string LastName,
             string PhoneNumber, DateTime? BirthDate, string Gender, string ChronicDiseases, string Allergies)
        {
            int PatientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Patients_TBL (PAT_FirstName,PAT_LastName,PAT_PhoneNumber,PAT_BirthDate,
                             PAT_Gender,PAT_ChronicDiseases,PAT_Allergies)
                        VALUES (@FirstName,@LastName,@PhoneNumber,@BirthDate,@Gender,@ChronicDiseases,@Allergies);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

            command.Parameters.AddWithValue("@BirthDate", (object)BirthDate ?? DBNull.Value);
            command.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(Gender) ? (object)DBNull.Value : Gender);
            command.Parameters.AddWithValue("@ChronicDiseases", string.IsNullOrEmpty(ChronicDiseases) ? (object)DBNull.Value : ChronicDiseases);
            command.Parameters.AddWithValue("@Allergies", string.IsNullOrEmpty(Allergies) ? (object)DBNull.Value : Allergies);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PatientID = InsertedID;
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
            return PatientID;
        }











    }
}
