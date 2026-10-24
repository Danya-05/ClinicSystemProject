using ClinicBusinessLayer;
using System;
using System.Data;

namespace ClinicSystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //clsPayment p1 = new clsPayment();
            //p1.Payment_Date = DateTime.Today;
            //p1.Payment_Time = DateTime.Now.TimeOfDay;
            //p1.Payment_Amount = 5;
            //p1.Payment_Method = "Cash";
            //p1.Patient_ID = 4;
            //p1.AddPayment();

            //clsUser u1 = new clsUser(3,"Doctor2","654321", "Doctor","Sara","Ali", "0793333333");

            DataTable dt = clsPayment.GetAllPatientsFinancialSummary();
            //Console.WriteLine(dt);

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