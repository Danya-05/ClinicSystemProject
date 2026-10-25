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

        public static bool DeletePatient(int PatientID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete from Patients_TBL where Patient_ID = @PatientID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PatientID", PatientID);

            try
            {
                connection.Open();
                rowAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Delete Error : " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowAffected > 0);
        }

        public static bool UpdatePatient(int PatientID, string FirstName, string LastName,
             string PhoneNumber, DateTime? BirthDate, string Gender, string ChronicDiseases, string Allergies)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Patients_TBL set PAT_FirstName = @FirstName,
                                             PAT_LastName = @LastName,
                                             PAT_PhoneNumber = @PhoneNumber,
                                             PAT_BirthDate = @BirthDate,
                                             PAT_Gender = @Gender,
                                             PAT_ChronicDiseases = @ChronicDiseases,
                                             PAT_Allergies = @Allergies
                                    where Patient_ID = @PatientID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PatientID", PatientID);
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

        public static DataTable GetAllPatients()
        {
            string query = @"Select * from Patients_TBL";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable GetPatientsName()
        {
            string query = @"select PAT_FirstName +' '+ PAT_LastName AS PatientName from Patients_TBL";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable SearchPatients(string searchText)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"
                SELECT * FROM Patients_TBL
                WHERE
                PAT_FirstName LIKE @Search
                OR PAT_LastName LIKE @Search
                OR PAT_PhoneNumber LIKE @Search
                OR CAST(Patient_ID AS NVARCHAR(20)) LIKE @Search";

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

        public static decimal Total_Fees(int Patient_ID)
        {
            decimal TotalFees = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
            SELECT ISNULL(SUM(MV.MedicalVisit_Fee), 0) as Total_Fees
            FROM Appointments_TBL A
            INNER JOIN MedicalVisits_TBL MV
                ON A.Appointment_ID = MV.Appointment_ID
            WHERE A.Patient_ID = @Patient_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Patient_ID", Patient_ID);

                    connection.Open();

                    TotalFees = Convert.ToDecimal(command.ExecuteScalar());
                }
            }

            return TotalFees;
        }

        public static decimal Total_Paid(int Patient_ID)
        {
            decimal TotalPaid = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"
            SELECT ISNULL(SUM(Amount_Paid), 0) as Total_Paid
            FROM Payments_TBL
            WHERE Patient_ID = @Patient_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Patient_ID", Patient_ID);

                    connection.Open();

                    TotalPaid = Convert.ToDecimal(command.ExecuteScalar());
                }
            }

            return TotalPaid;
        }

        public static DataTable GetPatientInfoByID(int Patient_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT *
                         FROM Patients_TBL
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
