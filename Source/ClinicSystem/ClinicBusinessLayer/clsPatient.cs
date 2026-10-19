using System;
using ClinicDataAccessLayer;

namespace ClinicBusinessLayer
{
    public class clsPatient
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; set; }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string ChronicDiseases { get; set; }
        public string Allergies { get; set; }

        private bool _AddNewPatient()
        {
            this.ID = clsPatientDataAccess.AddNewPatient(this.FirstName, this.LastName, this.PhoneNumber,
                                            this.BirthDate, this.Gender, this.ChronicDiseases, this.Allergies);
            return (this.ID != -1);
        }
    }
}
