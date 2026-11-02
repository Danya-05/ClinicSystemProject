using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsMedicalVisit
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; set; }

        public int MedicalVisit_ID { get; set; }
        public decimal MedicalVisit_Fee { get; set; }
        public int Appointment_ID { get; set; }

        public clsMedicalVisit()
        {
            this.Mode = enMode.AddNew;
            this.MedicalVisit_ID = -1;
            this.MedicalVisit_Fee = 0;
            this.Appointment_ID = -1;
        }

        public clsMedicalVisit(int MedicalVisit_ID, decimal MedicalVisit_Fee, int Appointment_ID)
        {
            this.Mode = enMode.Update;
            this.MedicalVisit_ID = MedicalVisit_ID;
            this.MedicalVisit_Fee = MedicalVisit_Fee;
            this.Appointment_ID = Appointment_ID;
        }

        private bool _AddNewMedicalVisit()
        {
            this.MedicalVisit_ID = clsMedicalVisitDataAccess.AddNewMedicalVisit(this.MedicalVisit_Fee, this.Appointment_ID);
            return (this.MedicalVisit_ID != -1);
        }

        private bool _UpdateMedicalVisit()
        {
            return clsMedicalVisitDataAccess.UpdateMedicalVisit(this.MedicalVisit_ID, this.MedicalVisit_Fee, this.Appointment_ID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewMedicalVisit())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateMedicalVisit();

            }
            return false;
        }

        public static clsMedicalVisit FindMedicalVisit(int MedicalVisit_ID)
        {
            DataTable dt = clsMedicalVisitDataAccess.GetMedicalVisitByID(MedicalVisit_ID);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new clsMedicalVisit(
                 Convert.ToInt32(row["MedicalVisit_ID"]),
                 Convert.ToInt32(row["MedicalVisit_Fee"]),
                 Convert.ToInt32(row["Appointment_ID"])
            );
        }

        public static DataTable GetAllMedicalVisits()
        {
            return clsMedicalVisitDataAccess.GetMedicalVisits();
        }

        public static DataTable GetAllMedicalVisitsToday()
        {
            return clsMedicalVisitDataAccess.GetMedicalVisitsToday();
        }

        public static DataTable SearchMedicalVisits(string searchText)
        {
            return clsMedicalVisitDataAccess.SearchMedicalVisits(searchText);
        }



    }
}
