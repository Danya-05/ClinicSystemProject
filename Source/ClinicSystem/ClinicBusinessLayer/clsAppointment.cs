using ClinicDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBusinessLayer
{
    public class clsAppointment
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; set; }

        public int Appointment_ID { get; set; }
        public DateTime Appointment_Date { get; set; }
        public TimeSpan Appointment_Time { get; set; }
        public string Appointment_Status { get; set; }
        public int Patient_ID { get; set; }
        public int Doctor_ID { get; set; }

        public clsAppointment()
        {
            this.Appointment_ID = -1;
            this.Patient_ID = -1;
            this.Doctor_ID = -1;

            this.Appointment_Date = DateTime.Today;
            this.Appointment_Time = DateTime.Now.TimeOfDay;
            this.Appointment_Status = "";

            this.Mode = enMode.AddNew;
        }

        public clsAppointment(int Appointment_ID,int Patient_ID, int Doctor_ID, DateTime Appointment_Date, TimeSpan Appointment_Time, string Appointment_Status)
        {
            this.Appointment_ID = Appointment_ID;
            this.Patient_ID = Patient_ID;
            this.Doctor_ID = Doctor_ID;

            this.Appointment_Date = Appointment_Date;
            this.Appointment_Time = Appointment_Time;
            this.Appointment_Status = Appointment_Status;

            this.Mode = enMode.Update;
        }

        private bool _AddNewAppointment()
        {
            this.Appointment_ID = clsAppointmentDataAccess.AddNewAppointment(this.Appointment_Date, this.Appointment_Time, this.Appointment_Status,
                                            this.Patient_ID, this.Doctor_ID);
            return (this.Appointment_ID != -1);
        }

        private bool _UpdateAppointment()
        {
            return clsAppointmentDataAccess.UpdateAppointment(this.Appointment_ID, this.Appointment_Date, this.Appointment_Time, this.Appointment_Status,
                                            this.Patient_ID, this.Doctor_ID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAppointment())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateAppointment();

            }
            return false;
        }

        public static clsAppointment FindAppointment(int Appointment_ID)
        {
            DataTable dt = clsAppointmentDataAccess.GetAppointmentInfoByID(Appointment_ID);

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            return new clsAppointment(
                 Convert.ToInt32(row["Appointment_ID"]),
                 Convert.ToInt32(row["Patient_ID"]),
                 Convert.ToInt32(row["Doctor_ID"]),
                 Convert.ToDateTime(row["Appointment_Date"]),
                 TimeSpan.Parse(row["Appointment_Time"].ToString()),
                 row["Appointment_Status"].ToString()
            );
        }

        public static int TotalScheduledAppointments()
        {
            return clsAppointmentDataAccess.TotalScheduledAppointments();
        }

        public static int TotalCompletedAppointment()
        {
            return clsAppointmentDataAccess.TotalCompletedAppointment();
        }

        public static int TotalCancelledAppointment()
        {
            return clsAppointmentDataAccess.TotalCancelledAppointment();
        }

        public static DataTable GetAllAppointments()
        {
            return clsAppointmentDataAccess.GetAllAppointments();
        }

        public static DataTable GetAppointmentsToday()
        {
            return clsAppointmentDataAccess.GetAppointmentsToday();
        }

        public static DataTable SearchAppointments(string searchText)
        {
            return clsAppointmentDataAccess.SearchAppointments(searchText);
        }


    }
}
