using ClinicDataAccessLayer;
using System;
using System.Data;

namespace ClinicBusinessLayer
{
    public class clsPatient
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; set; }

        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string ChronicDiseases { get; set; }
        public string Allergies { get; set; }

        public clsPatient()
        {
            this.PatientID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.PhoneNumber = "";
            this.BirthDate = null;
            this.Gender = "";
            this.ChronicDiseases = "";
            this.Allergies = "";

            this.Mode = enMode.AddNew;
        }

        private bool _AddNewPatient()
        {
            this.PatientID = clsPatientDataAccess.AddNewPatient(this.FirstName, this.LastName, this.PhoneNumber,
                                            this.BirthDate, this.Gender, this.ChronicDiseases, this.Allergies);
            return (this.PatientID != -1);
        }

        private bool _UpdatePatient()
        {
            return clsPatientDataAccess.UpdatePatient(this.PatientID, this.FirstName, this.LastName, this.PhoneNumber,
                                    this.BirthDate, this.Gender, this.ChronicDiseases, this.Allergies);
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
            return clsPatientDataAccess.GetAllPationts();
        }

        public static DataTable SearchPatients(string searchText)
        {
            return clsPatientDataAccess.SearchPatients(searchText);
        }

    }
}
