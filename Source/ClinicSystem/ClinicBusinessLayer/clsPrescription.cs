using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsPrescription
    {
        public int Prescription_ID { get; set; }
        public string PRE_Medicine { get; set; }
        public string PRE_Notes { get; set; }
        public int MedicalVisit_ID { get; set; }

        public clsPrescription()
        {
            this.Prescription_ID = -1;
            this.PRE_Medicine = "";
            this.PRE_Notes = "";
            this.MedicalVisit_ID = -1;
        }

        public clsPrescription(int Prescription_ID, string PRE_Medicine, string PRE_Notes, int MedicalVisit_ID)
        {
            this.Prescription_ID = Prescription_ID;
            this.PRE_Medicine = PRE_Medicine;
            this.PRE_Notes = PRE_Notes;
            this.MedicalVisit_ID = MedicalVisit_ID;
        }

        public bool AddThisPrescription()
        {
            this.Prescription_ID = clsPrescriptionDataAccess.AddNewPrescription(this.PRE_Medicine,this.PRE_Notes,this.MedicalVisit_ID);
            return (this.Prescription_ID != -1);
        }

        public bool UpdateThisPrescription()
        {
            return clsPrescriptionDataAccess.UpdatePrescription(this.Prescription_ID, this.PRE_Medicine, this.PRE_Notes,this.MedicalVisit_ID);
        }

        public static bool DeletePrescription(int Prescription_ID)
        {
            return clsPrescriptionDataAccess.DeletePrescription(Prescription_ID);
        }

        public static clsPrescription FindPrescription(int Prescription_ID)
        {
            DataTable dt = clsPrescriptionDataAccess.GetPrescriptionInfoByID(Prescription_ID);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new clsPrescription(
                 Convert.ToInt32(row["Prescription_ID"]),
                 Convert.ToString(row["PRE_Medicine"]),
                 Convert.ToString(row["PRE_Notes"]),
                 Convert.ToInt32(row["MedicalVisit_ID"])
            );
        }

        public static DataTable ShowAllPrescriptionForPatient(int Patient_ID)
        {
            return clsPrescriptionDataAccess.GetAllPrescriptionsForPatient(Patient_ID);
        }


    }
}
