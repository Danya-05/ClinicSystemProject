using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsPayment
    {
        public int Payment_ID { get; set; }
        public DateTime Payment_Date { get; set; }
        public TimeSpan Payment_Time { get; set; }
        public decimal Payment_Amount { get; set; }
        public string Payment_Method { get; set; }
        public int Patient_ID { get; set; }

        public clsPayment()
        {
            this.Payment_ID = -1;
            this.Payment_Date = DateTime.Today;
            this.Payment_Time = DateTime.Now.TimeOfDay;
            this.Payment_Amount = 0;
            this.Payment_Method = "";
            this.Patient_ID = -1;
        }

        public bool AddPayment()
        {
            this.Payment_ID = clsPaymentDataAccess.AddNewPayment(this.Payment_Date, this.Payment_Time, this.Payment_Amount,
                                            this.Payment_Method, this.Patient_ID);
            return (this.Patient_ID != -1);
        }

        public static bool DeletePayment(int Payment_ID)
        {
            return clsPaymentDataAccess.DeletePayment(Payment_ID);
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentDataAccess.GetAllPayments();
        }

        public static DataTable GetAllPaymentForPatient(int Payment_ID)
        {
            return clsPaymentDataAccess.GetAllPaymentForPatient(Payment_ID);
        }

        public static decimal GetMonthlyEarnings()
        {
            return clsPaymentDataAccess.GetMonthlyEarnings();
        }

        public static DataTable GetAllPatientsFinancialSummary()
        {
            return clsPaymentDataAccess.GetAllPatientsFinancialSummary();
        }
    }
}
