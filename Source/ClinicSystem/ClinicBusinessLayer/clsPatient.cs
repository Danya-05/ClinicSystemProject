using ClinicDataAccessLayer;
using System;
using System.Data;

namespace ClinicBusinessLayer
{
    public class clsPatient
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; set; }

        public int Patient_ID { get; set; }
        public string PAT_FirstName { get; set; }
        public string PAT_LastName { get; set; }
        public string PAT_PhoneNumber { get; set; }
        public DateTime? PAT_BirthDate { get; set; }
        public string PAT_Gender { get; set; }
        public string PAT_ChronicDiseases { get; set; }
        public string PAT_Allergies { get; set; }
        public decimal Total_Fees { get; private set; }
        public decimal Total_Paid { get; private set; }
        public decimal Remaining_Amount { get; private set; }

        public clsPatient()
        {
            this.Patient_ID = -1;
            this.PAT_FirstName = "";
            this.PAT_LastName = "";
            this.PAT_PhoneNumber = "";
            this.PAT_BirthDate = null;
            this.PAT_Gender = "";
            this.PAT_ChronicDiseases = "";
            this.PAT_Allergies = "";
            this.Total_Fees = clsPatientDataAccess.Total_Fees(this.Patient_ID);
            this.Total_Paid = clsPatientDataAccess.Total_Paid(this.Patient_ID);
            this.Remaining_Amount = Total_Fees - Total_Paid;

            this.Mode = enMode.AddNew;
        }

        public clsPatient(int Patient_ID,string PAT_FirstName,string PAT_LastName,string PAT_PhoneNumber,
            DateTime? PAT_BirthDate,string PAT_Gender,string PAT_ChronicDiseases, string PAT_Allergies)
        {
            this.Patient_ID = Patient_ID;
            this.PAT_FirstName = PAT_FirstName;
            this.PAT_LastName = PAT_LastName;
            this.PAT_PhoneNumber = PAT_PhoneNumber;
            this.PAT_BirthDate = PAT_BirthDate;
            this.PAT_Gender = PAT_Gender;
            this.PAT_ChronicDiseases = PAT_ChronicDiseases;
            this.PAT_Allergies = PAT_Allergies;
            this.Total_Fees = clsPatientDataAccess.Total_Fees(this.Patient_ID);
            this.Total_Paid = clsPatientDataAccess.Total_Paid(this.Patient_ID);
            this.Remaining_Amount = Total_Fees - Total_Paid;

            this.Mode = enMode.Update;
        }

        private bool _AddNewPatient()
        {
            this.Patient_ID = clsPatientDataAccess.AddNewPatient(this.PAT_FirstName, this.PAT_LastName, this.PAT_PhoneNumber,
                                            this.PAT_BirthDate, this.PAT_Gender, this.PAT_ChronicDiseases, this.PAT_Allergies);
            return (this.Patient_ID != -1);
        }

        private bool _UpdatePatient()
        {
            return clsPatientDataAccess.UpdatePatient(this.Patient_ID, this.PAT_FirstName, this.PAT_LastName, this.PAT_PhoneNumber,
                                    this.PAT_BirthDate, this.PAT_Gender, this.PAT_ChronicDiseases, this.PAT_Allergies);
        }

        public static bool DeletePatient(int PatientID)
        {
            return clsPatientDataAccess.DeletePatient(PatientID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPatient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePatient();

            }
            return false;
        }

        public static DataTable GetAllPatients()
        {
            return clsPatientDataAccess.GetAllPatients();
        }

        public static DataTable GetPatientsName()
        {
            return clsPatientDataAccess.GetPatientsName();
        }

        public static DataTable SearchPatients(string searchText)
        {
            return clsPatientDataAccess.SearchPatients(searchText);
        }

        public static clsPatient Find(int Patient_ID)
        {
            DataTable dt = clsPatientDataAccess.GetPatientInfoByID(Patient_ID);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new clsPatient(
                Convert.ToInt32(row["Patient_ID"]),
                row["PAT_FirstName"].ToString(),
                row["PAT_LastName"].ToString(),
                row["PAT_PhoneNumber"].ToString(),
                row["PAT_BirthDate"] == DBNull.Value? (DateTime?)null : Convert.ToDateTime(row["PAT_BirthDate"]),
                row["PAT_Gender"].ToString(),
                row["PAT_ChronicDiseases"].ToString(),
                row["PAT_Allergies"].ToString()
            );
        }

    }
}
