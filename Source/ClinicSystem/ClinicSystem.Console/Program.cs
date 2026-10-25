using ClinicBusinessLayer;
using System;
using System.Data;

namespace ClinicSystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsInsurance p1 = new clsInsurance();
            p1.Patient_ID = 4;
            p1.Insurance_Rate = 15;
            p1.Insurance_ExpiryDate = new DateTime(2027, 12, 31);
            
            Console.WriteLine(p1.UpdateInsurance()); 
            
            //DataTable dt = clsPayment.GetAllPatientsFinancialSummary();

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (DataColumn col in dt.Columns)
            //    {
            //        Console.Write($"{row[col]} | ");
            //    }

            //    Console.WriteLine();
            //}



        }
    }
}