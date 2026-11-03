using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsDiagnosisDataAccess
    {
        public static int AddNewDiagnosis(string Diagnosis_Name, int MedicalVisit_ID)
        {
            int Diagnosis_ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Diagnostics_TBL (Diagnosis_Name,MedicalVisit_ID)
                        VALUES (@Diagnosis_Name,@MedicalVisit_ID);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Diagnosis_Name", Diagnosis_Name);
            command.Parameters.AddWithValue("@MedicalVisit_ID", MedicalVisit_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Diagnosis_ID = InsertedID;
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
            return Diagnosis_ID;
        }

        public static bool UpdateDiagnosis(int Diagnosis_ID, string Diagnosis_Name, int MedicalVisit_ID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Diagnostics_TBL set Diagnosis_Name = @Diagnosis_Name,
                                                        MedicalVisit_ID = @MedicalVisit_ID
                                    where Diagnosis_ID = @Diagnosis_ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Diagnosis_ID", Diagnosis_ID);
            command.Parameters.AddWithValue("@Diagnosis_Name", Diagnosis_Name);
            command.Parameters.AddWithValue("@MedicalVisit_ID", MedicalVisit_ID);

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

        public static bool DeleteDiagnosis(int Diagnosis_ID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete from Diagnostics_TBL where Diagnosis_ID = @Diagnosis_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Diagnosis_ID", Diagnosis_ID);

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

        // for find (edit)
        public static DataTable GetDiagnosisInfoByID(int Diagnosis_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT *
                         FROM Diagnostics_TBL
                         WHERE Diagnosis_ID = @Diagnosis_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Diagnosis_ID", Diagnosis_ID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // for layout
        public static DataTable GetAllDiagnosticsForPatient(int Patient_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT
                                  D.Diagnosis_ID, D.Diagnosis_Name,
                                  CONCAT(A.Appointment_Date ,' ' , A.Appointment_Time) as Date_Time
                             FROM Diagnostics_TBL D
                                  
                                  INNER JOIN MedicalVisits_TBL M
                                      ON M.MedicalVisit_ID = D.MedicalVisit_ID
                                  
                                  INNER JOIN Appointments_TBL A
                                      ON A.Appointment_ID = M.Appointment_ID

                                  INNER JOIN Patients_TBL PA
                                      ON PA.Patient_ID = A.Patient_ID
                             WHERE PA.Patient_ID = @Patient_ID   
                                  ORDER BY
                                      A.Appointment_Date desc,
                                      A.Appointment_Time desc;";

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
