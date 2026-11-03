using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsDiagnosis
    {
        public int Diagnosis_ID { get; set; }
        public string Diagnosis_Name { get; set; }
        public int MedicalVisit_ID { get; set; }

        public clsDiagnosis()
        {
            this.Diagnosis_ID = -1;
            this.Diagnosis_Name = "";
            this.MedicalVisit_ID = -1;
        }

        public clsDiagnosis(int Diagnosis_ID, string Diagnosis_Name, int MedicalVisit_ID)
        {
            this.Diagnosis_ID = Diagnosis_ID;
            this.Diagnosis_Name = Diagnosis_Name;
            this.MedicalVisit_ID = MedicalVisit_ID;
        }

        public bool AddThisDiagnosis()
        {
            this.Diagnosis_ID = clsDiagnosisDataAccess.AddNewDiagnosis(this.Diagnosis_Name, this.MedicalVisit_ID);
            return (this.Diagnosis_ID != -1);
        }

        public bool UpdateThisDiagnosis()
        {
            return clsDiagnosisDataAccess.UpdateDiagnosis(this.Diagnosis_ID, this.Diagnosis_Name, this.MedicalVisit_ID);
        }

        public static bool DeleteDiagnosis(int Diagnosis_ID)
        {
            return clsDiagnosisDataAccess.DeleteDiagnosis(Diagnosis_ID);
        }

        public static clsDiagnosis FindDiagnosis(int Diagnosis_ID)
        {
            DataTable dt = clsDiagnosisDataAccess.GetDiagnosisInfoByID(Diagnosis_ID);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new clsDiagnosis(
                 Convert.ToInt32(row["Diagnosis_ID"]),
                 Convert.ToString(row["Diagnosis_Name"]),
                 Convert.ToInt32(row["MedicalVisit_ID"])
            );
        }

        public static DataTable ShowAllDiagnosisForPatient(int Patient_ID)
        {
            return clsDiagnosisDataAccess.GetAllDiagnosticsForPatient(Patient_ID);
        }


    }
}
