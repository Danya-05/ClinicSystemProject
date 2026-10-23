using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ClinicBusinessLayer
{
    public class clsDoctor : clsUser
    {
        public int Doctor_ID { get; set; }
        public string Doctor_Specialty { get; set; }

        public clsDoctor() : base()
        {
            Doctor_ID = -1;
            Doctor_Specialty = "";
        }

        public clsDoctor(int User_ID,string User_Name,string User_Password,string User_Type,
               string User_FirstName,string User_LastName,string User_PhoneNumber,int Doctor_ID,
               string Doctor_Specialty) : base(User_ID,User_Name,User_Password,User_Type,User_FirstName, 
                                                User_LastName,User_PhoneNumber)
        {
            this.Doctor_ID = Doctor_ID;
            this.Doctor_Specialty = Doctor_Specialty;
        }


    }
}
