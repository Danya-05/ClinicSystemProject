using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class MedicalVisitDataAccess
    {
        public static int AddNewMedicalVisit(decimal MedicalVisit_Fee, int Appointment_ID)
        {
            int MedicalVisit_ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into MedicalVisits_TBL (MedicalVisit_Fee,Appointment_ID)
                        VALUES (@MedicalVisit_Fee,@Appointment_ID);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalVisit_Fee", MedicalVisit_Fee);
            command.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    MedicalVisit_ID = InsertedID;
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
            return MedicalVisit_ID;
        }

        public static bool UpdateMedicalVisit(int MedicalVisit_ID, decimal MedicalVisit_Fee, int Appointment_ID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update MedicalVisits_TBL set MedicalVisit_Fee = @MedicalVisit_Fee,
                                             Appointment_ID = @Appointment_ID
                                    where MedicalVisit_ID = @MedicalVisit_ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MedicalVisit_Fee", MedicalVisit_Fee);
            command.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);
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

        // for find function
        public static DataTable GetMedicalVisitByID(int MedicalVisit_ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"SELECT *
                         FROM MedicalVisits_TBL
                         WHERE MedicalVisit_ID = @MedicalVisit_ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MedicalVisit_ID", MedicalVisit_ID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static DataTable GetMedicalVisits()
        {
            string query = @"SELECT
                    V.MedicalVisit_ID,
                    CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) AS Patient_Name,
                    CONCAT(U.User_FirstName, ' ', U.User_LastName) AS Doctor_Name,
                    A.Appointment_Date,
                    A.Appointment_Time,
                    V.MedicalVisit_Fee

                    FROM MedicalVisits_TBL V

                    INNER JOIN Appointments_TBL A
                        ON V.Appointment_ID = A.Appointment_ID

                    INNER JOIN Patients_TBL P
                        ON A.Patient_ID = P.Patient_ID

                    INNER JOIN Doctors_TBL D
                        ON A.Doctor_ID = D.Doctor_ID

                    INNER JOIN Users_TBL U
                        ON D.User_ID = U.User_ID

                    ORDER BY
                        A.Appointment_Date DESC,
                        A.Appointment_Time DESC;";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable GetMedicalVisitsToday()
        {
            string query = @"SELECT
                    V.MedicalVisit_ID,
                    CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) AS Patient_Name,
                    CONCAT(U.User_FirstName, ' ', U.User_LastName) AS Doctor_Name,
                    A.Appointment_Date,
                    A.Appointment_Time,
                    V.MedicalVisit_Fee

                    FROM MedicalVisits_TBL V

                    INNER JOIN Appointments_TBL A
                        ON V.Appointment_ID = A.Appointment_ID

                    INNER JOIN Patients_TBL P
                        ON A.Patient_ID = P.Patient_ID

                    INNER JOIN Doctors_TBL D
                        ON A.Doctor_ID = D.Doctor_ID

                    INNER JOIN Users_TBL U
                        ON D.User_ID = U.User_ID

                    WHERE CAST(A.Appointment_Date AS DATE) = CAST(GETDATE() AS DATE)
                    ORDER BY
                        A.Appointment_Date DESC,
                        A.Appointment_Time DESC;";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable SearchAppointments(string searchText)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT
                    V.MedicalVisit_ID,
                    CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) AS Patient_Name,
                    CONCAT(U.User_FirstName, ' ', U.User_LastName) AS Doctor_Name,
                    A.Appointment_Date,
                    A.Appointment_Time,
                    V.MedicalVisit_Fee

                    FROM MedicalVisits_TBL V

                    INNER JOIN Appointments_TBL A
                        ON V.Appointment_ID = A.Appointment_ID

                    INNER JOIN Patients_TBL P
                        ON A.Patient_ID = P.Patient_ID

                    INNER JOIN Doctors_TBL D
                        ON A.Doctor_ID = D.Doctor_ID

                    INNER JOIN Users_TBL U
                        ON D.User_ID = U.User_ID
                            
                            WHERE CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) LIKE @SearchText
                            OR CONCAT(U.User_FirstName, ' ', U.User_LastName) LIKE @SearchText
                            OR CAST(A.Appointment_Date AS NVARCHAR(20)) LIKE @SearchText
                            OR CAST(A.Appointment_Time AS NVARCHAR(20)) LIKE @SearchText
                            ORDER BY
                                A.Appointment_Date desc,
                                A.Appointment_Time desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SearchText", "%" + searchText.Trim() + "%");

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




    }
}
