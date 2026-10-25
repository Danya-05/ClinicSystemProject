using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsInsurance
    {
        public int Insurance_ID { get; set; }
        public decimal Insurance_Rate { get; set; }
        public DateTime? Insurance_ExpiryDate { get; set; }
        public int Patient_ID { get; set; }

        public clsInsurance()
        {
            this.Insurance_ID = -1;
            this.Patient_ID = -1;
            this.Insurance_Rate = 0;
            this.Insurance_ExpiryDate = null;
        }

        public clsInsurance(int Insurance_ID, decimal Insurance_Rate, DateTime? Insurance_ExpiryDate, int Patient_ID)
        {
            this.Insurance_ID = Insurance_ID;
            this.Patient_ID = Patient_ID;
            this.Insurance_Rate = Insurance_Rate;
            this.Insurance_ExpiryDate = Insurance_ExpiryDate;
        }

        public bool AddNewInsurance()
        {
            this.Insurance_ID = clsInsuranceDataAccess.AddNewInsurance(this.Insurance_Rate, this.Insurance_ExpiryDate,this.Patient_ID);
            return (this.Insurance_ID != -1);
        }

        public bool UpdateInsurance()
        {
            return clsInsuranceDataAccess.UpdateInsurance(this.Insurance_Rate, this.Insurance_ExpiryDate, this.Patient_ID);
        }

        public static clsInsurance Find(int Patient_ID)
        {
            DataTable dt = clsInsuranceDataAccess.GetInsuranceByPatientID(Patient_ID);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new clsInsurance(
                Convert.ToInt32(row["Insurance_ID"]),
                Convert.ToDecimal(row["Insurance_Rate"]),
                row["Insurance_ExpiryDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["Insurance_ExpiryDate"]),
                Convert.ToInt32(row["Patient_ID"])
            );
        }

    }
}
