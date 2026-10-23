using ClinicBusinessLayer;
using System;
using System.Data;

namespace ClinicSystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //clsPatient p1 = new clsPatient();
            //p1.PatientID = 4;
            //p1.FirstName = "Mohammed";
            //p1.LastName = "Zaino";
            //p1.PhoneNumber = "077777770";
            //p1.Gender = "Male";
            //p1.BirthDate = new DateTime(2002, 11, 26);
            //p1.Allergies = null;
            //p1.ChronicDiseases = null;

            //string ss = Console.ReadLine();

            //DataTable dt = clsPatient.SearchPatients(ss);

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        Console.Write($"{row[col]} | ");
            //    }

            //    Console.WriteLine();
            //}

            //clsUser u1 = new clsUser(3,"Doctor2","654321", "Doctor","Sara","Ali", "0793333333");

            DataTable dt = clsDoctor.GetAllDoctors();
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