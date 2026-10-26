using System;
using System.Collections.Generic;
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








    }
}
