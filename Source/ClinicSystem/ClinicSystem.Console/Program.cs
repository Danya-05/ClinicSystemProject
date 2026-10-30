using ClinicBusinessLayer;
using System;
using System.Data;

namespace ClinicSystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //clsAppointment p1 = clsAppointment.FindAppointment(1);
            //p1.Appointment_Status = "Test";

            //Console.WriteLine(clsAppointment.TotalCancelledAppointment()); 

           // string s = "2";

            DataTable dt = clsAppointment.GetAppointmentsToday();

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write($"{row[col]} | ");
                }

                Console.WriteLine();
            }



        }
    }
}