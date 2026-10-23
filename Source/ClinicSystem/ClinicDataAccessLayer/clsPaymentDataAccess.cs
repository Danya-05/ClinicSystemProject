using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicDataAccessLayer
{
    public class clsPaymentDataAccess
    {
        public static int AddNewPayment(DateTime Payment_Date, TimeSpan Payment_Time,
                float Amount_Paid, string Payment_Method, int Patient_ID)
        {
            int Pyment_ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Payments_TBL (Payment_Date,Payment_Time,Amount_Paid,Payment_Method,
                             Patient_ID)
                        VALUES (@Payment_Date,@Payment_Time,@Amount_Paid,@Payment_Method,@Patient_ID);
                        Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Payment_Date", Payment_Date);
            command.Parameters.AddWithValue("@Payment_Time", Payment_Time);
            command.Parameters.AddWithValue("@Amount_Paid", Amount_Paid);
            command.Parameters.AddWithValue("@Payment_Method", Payment_Method);
            command.Parameters.AddWithValue("@Patient_ID", Patient_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    Pyment_ID = InsertedID;
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
            return Pyment_ID;
        }

        public static bool DeletePayment(int Payment_ID)
        {
            int rowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Delete from Payments_TBL where Payment_ID = @Payment_ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PatientID", Payment_ID);

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

        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select pay.Payment_ID, p.PAT_FirstName+' '+p.PAT_LastName as PatientName,pay.Amount_Paid,
                                pay.Payment_Date,pay.Payment_Time,pay.Payment_Method
                            from Payments_TBL pay 
                            inner join Patients_TBL p
                            on pay.Patient_ID = p.Patient_ID
                            order by pay.Payment_Date DESC, pay.Payment_Time DESC";

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

        public static DataTable GetAllPaymentForPatient(int Patient_ID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select pay.Payment_ID, pay.Amount_Paid,pay.Payment_Date,pay.Payment_Time, pay.Payment_Method 
                             from Payments_TBL pay 
                             inner join Patients_TBL p
                             ON pay.Patient_ID = p.Patient_ID
                             WHERE pay.Patient_ID = @Patient_ID
                             ORDER BY pay.Payment_Date DESC, pay.Payment_Time DESC";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Patient_ID", Patient_ID);

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

        public static DataTable ShowPaymentsReport(string query)
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
