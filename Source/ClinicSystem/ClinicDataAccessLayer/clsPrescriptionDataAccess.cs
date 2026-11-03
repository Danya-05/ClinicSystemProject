using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsPrescriptionDataAccess
    {
        public static int AddNewPrescription(string PRE_Medicine,string PRE_Notes,int MedicalVisit_ID)
        {
            int Prescription_ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Prescriptions_TBL (PRE_Medicine,PRE_Notes,MedicalVisit_ID)
                        VALUES (@PRE_Medicine,@PRE_Notes,@MedicalVisit_ID);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PRE_Medicine", PRE_Medicine);
            command.Parameters.AddWithValue("@PRE_Notes", PRE_Notes);
            command.Parameters.AddWithValue("@MedicalVisit_ID", MedicalVisit_ID);
            

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Prescription_ID = InsertedID;
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
            return Prescription_ID;
        }

        public static bool UpdatePrescription(int Prescription_ID, string PRE_Medicine, string PRE_Notes, int MedicalVisit_ID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Prescriptions_TBL set PRE_Medicine = @PRE_Medicine,
                                                          PRE_Notes = @PRE_Notes,
                                                          MedicalVisit_ID = @MedicalVisit_ID
                                    where Prescription_ID = @Prescription_ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Prescription_ID", Prescription_ID);
            command.Parameters.AddWithValue("@PRE_Medicine", PRE_Medicine);
            command.Parameters.AddWithValue("@PRE_Notes", PRE_Notes);
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

        public static bool DeletePrescription(int Prescription_ID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete from Prescriptions_TBL where Prescription_ID = @Prescription_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Prescription_ID", Prescription_ID);

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
        public static DataTable GetPrescriptionInfoByID(int Prescription_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT *
                         FROM Prescriptions_TBL
                         WHERE Prescription_ID = @Prescription_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Prescription_ID", Prescription_ID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        // for layout
        public static DataTable GetAllPrescriptionsForPatient(int Patient_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT
                                  P.Prescription_ID, P.PRE_Medicine,
                                  CONCAT(A.Appointment_Date ,' ' , A.Appointment_Time) as Date_Time,
                                  P.PRE_Notes
                             FROM Prescriptions_TBL P
                                  
                                  INNER JOIN MedicalVisits_TBL M
                                      ON M.MedicalVisit_ID = P.MedicalVisit_ID
                                  
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
