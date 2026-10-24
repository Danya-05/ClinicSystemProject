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
                decimal Amount_Paid, string Payment_Method, int Patient_ID)
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
            command.Parameters.AddWithValue("@Payment_ID", Payment_ID);

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
            string query = @"select pay.Payment_ID, p.PAT_FirstName+' '+p.PAT_LastName as PatientName,pay.Amount_Paid,
                                pay.Payment_Date,pay.Payment_Time,pay.Payment_Method
                            from Payments_TBL pay 
                            inner join Patients_TBL p
                            on pay.Patient_ID = p.Patient_ID
                            order by pay.Payment_Date DESC, pay.Payment_Time DESC";

            return clsDataAccessSettings.GetData(query);
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

        public static decimal GetMonthlyEarnings()
        {
            decimal TotalEarnings = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"SELECT ISNULL(SUM(Amount_Paid), 0) AS TotalEarnings
                            FROM Payments_TBL
                            WHERE Payment_Date >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
                            AND Payment_Date < DATEADD(MONTH, 1, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))";
            
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out decimal InsertedID))
                {
                    TotalEarnings = InsertedID;
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


            return TotalEarnings;
        }

        public static DataTable GetAllPatientsFinancialSummary() 
        {
            string query = @"WITH TotalFees AS
                            (
                                SELECT
                                    A.Patient_ID,
                                    SUM(MV.MedicalVisit_Fee) AS Total_Fees
                                FROM Appointments_TBL A
                            
                                INNER JOIN MedicalVisits_TBL MV
                                ON A.Appointment_ID = MV.Appointment_ID
                            
                                GROUP BY A.Patient_ID
                            ),
                            TotalPayments AS
                            (
                                SELECT
                                    Patient_ID,
                                    SUM(Amount_Paid) AS Total_Paid
                                FROM Payments_TBL
                            
                                GROUP BY Patient_ID
                            )
                            SELECT
                                P.Patient_ID,
                                (P.PAT_FirstName +' '+ P.PAT_LastName) as Patient_Name,
                            
                                ISNULL(F.Total_Fees, 0) AS Total_Fees,
                            
                                ISNULL(Pay.Total_Paid, 0) AS Total_Paid,
                            
                                ISNULL(F.Total_Fees, 0) -
                                ISNULL(Pay.Total_Paid, 0) AS Remaining_Amount
                            
                            FROM Patients_TBL P
                            
                            LEFT JOIN TotalFees F
                            ON P.Patient_ID = F.Patient_ID
                            
                            LEFT JOIN TotalPayments Pay
                            ON P.Patient_ID = Pay.Patient_ID;";

            return clsDataAccessSettings.GetData(query);
        }

    }
}
