using ClinicBusinessLayer;
using System;
using System.Data;

namespace ClinicSystem.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsUser p1 = clsUser.Find(1);
            Console.WriteLine(p1.User_FirstName); 
            
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