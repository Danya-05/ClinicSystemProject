using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsAppointmentDataAccess
    {
        public static int AddNewAppointment(DateTime Appointment_Date, TimeSpan Appointment_Time, string Appointment_Status,
                    int Patient_ID, int Doctor_ID)
        {
            int Appointment_ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Patients_TBL (Appointment_Date,Appointment_Time,Appointment_Status,Patient_ID,
                             Doctor_ID)
                        VALUES (@Appointment_Date,@Appointment_Time,@Appointment_Status,@Patient_ID,@Doctor_ID);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Appointment_Date", Appointment_Date);
            command.Parameters.AddWithValue("@Appointment_Time", Appointment_Time);
            command.Parameters.AddWithValue("@Appointment_Status", Appointment_Status);
            command.Parameters.AddWithValue("@Patient_ID", Patient_ID);
            command.Parameters.AddWithValue("@Doctor_ID", Doctor_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Appointment_ID = InsertedID;
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
            return Appointment_ID;
        }

        public static bool UpdateAppointment(int Appointment_ID, DateTime Appointment_Date, TimeSpan Appointment_Time, string Appointment_Status,
                    int Patient_ID, int Doctor_ID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Update Appointments_TBL set Appointment_Date = @Appointment_Date,
                                             Appointment_Time = @Appointment_Time,
                                             PAT_PhoneNumber = @PhoneNumber,
                                             Appointment_Status = @Appointment_Status,
                                             Patient_ID = @Patient_ID,
                                             Doctor_ID = @Doctor_ID
                                    where Appointment_ID = @Appointment_ID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);
            command.Parameters.AddWithValue("@Appointment_Date", Appointment_Date);
            command.Parameters.AddWithValue("@Appointment_Time", Appointment_Time);
            command.Parameters.AddWithValue("@Appointment_Status", Appointment_Status);
            command.Parameters.AddWithValue("@Patient_ID", Patient_ID);
            command.Parameters.AddWithValue("@Doctor_ID", Doctor_ID);

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

        public static bool CancelAppointment(int Appointment_ID)
        {
            int rowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"UPDATE TableName
                             SET Appointment_Status = 'Cancelled'
                             WHERE Appointment_ID = @Appointment_ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);

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

        public static int TotalScheduledAppointment()
        {
            int TotalAppointment = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"Select * from Appointments_TBL where Appointment_Status= 'Scheduled'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Patient_ID", TotalAppointment);

                    connection.Open();

                    TotalAppointment = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return TotalAppointment;
        }

        public static int TotalCompletedAppointment()
        {
            int TotalAppointment = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"Select * from Appointments_TBL where Appointment_Status= 'Completed'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Patient_ID", TotalAppointment);

                    connection.Open();

                    TotalAppointment = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return TotalAppointment;
        }

        public static int TotalCancelledAppointment()
        {
            int TotalAppointment = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"Select * from Appointments_TBL where Appointment_Status= 'Cancelled'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Patient_ID", TotalAppointment);

                    connection.Open();

                    TotalAppointment = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return TotalAppointment;
        }

        public static DataTable GetAllAppointments()
        {
            string query = @"SELECT
                            A.Appointment_ID,
                            CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) AS Patient_Name,
                            A.Appointment_Date,
                            A.Appointment_Time,
                            U.User_Name AS Doctor_Name,
                            A.Appointment_Status

                            FROM Appointments_TBL A
                            
                            INNER JOIN Patients_TBL P
                                ON A.Patient_ID = P.Patient_ID
                            
                            INNER JOIN Doctors_TBL D
                                ON A.Doctor_ID = D.Doctor_ID
                            
                            INNER JOIN Users_TBL U
                                ON D.User_ID = U.User_ID
                            
                            ORDER BY
                                A.Appointment_Date desc,
                                A.Appointment_Time desc;";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable GetAppointmentsToday()
        {
            string query = @"SELECT
                            A.Appointment_ID,
                            CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) AS Patient_Name,
                            A.Appointment_Date,
                            A.Appointment_Time,
                            U.User_Name AS Doctor_Name,
                            A.Appointment_Status

                            FROM Appointments_TBL A
                            
                            INNER JOIN Patients_TBL P
                                ON A.Patient_ID = P.Patient_ID
                            
                            INNER JOIN Doctors_TBL D
                                ON A.Doctor_ID = D.Doctor_ID
                            
                            INNER JOIN Users_TBL U
                                ON D.User_ID = U.User_ID
                            
                            WHERE CAST(Appointment_Date AS DATE) = CAST(GETDATE() AS DATE)
                            ORDER BY
                                A.Appointment_Date desc,
                                A.Appointment_Time desc";

            return clsDataAccessSettings.GetData(query);
        }

        public static DataTable SearchAppointments(DateTime? Appointment_Date, TimeSpan? Appointment_Time, string Patient_Name, string Doctor_Name)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT
                            A.Appointment_ID,
                            CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) AS Patient_Name,
                            A.Appointment_Date,
                            A.Appointment_Time,
                            U.User_Name AS Doctor_Name,
                            A.Appointment_Status

                            FROM Appointments_TBL A
                            
                            INNER JOIN Patients_TBL P
                                ON A.Patient_ID = P.Patient_ID
                            
                            INNER JOIN Doctors_TBL D
                                ON A.Doctor_ID = D.Doctor_ID
                            
                            INNER JOIN Users_TBL U
                                ON D.User_ID = U.User_ID
                            
                            WHERE (@Appointment_Date IS NULL OR A.Appointment_Date = @Appointment_Date)

                              AND (@Appointment_Time IS NULL OR A.Appointment_Time = @Appointment_Time)
                              
                              AND (@Patient_Name IS NULL OR
                                   CONCAT(P.PAT_FirstName, ' ', P.PAT_LastName) LIKE '%' + @Patient_Name + '%')
                              
                              AND (@Doctor_Name IS NULL OR
                                   U.User_Name LIKE '%' + @Doctor_Name + '%')
                            ORDER BY
                                A.Appointment_Date desc,
                                A.Appointment_Time desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Appointment_Date",
                (object)Appointment_Date ?? DBNull.Value);

            command.Parameters.AddWithValue("@Appointment_Time",
                (object)Appointment_Time ?? DBNull.Value);

            command.Parameters.AddWithValue("@Patient_Name",
                string.IsNullOrWhiteSpace(Patient_Name) ? DBNull.Value : (object)Patient_Name.Trim());

            command.Parameters.AddWithValue("@Doctor_Name",
                string.IsNullOrWhiteSpace(Doctor_Name) ? DBNull.Value : (object)Doctor_Name.Trim());

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
