using ClinicDataAccessLayer;
using System;
using System.Data;

namespace ClinicBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode { get; set; }

        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }
        public string User_Type { get; set; }
        public string User_FirstName { get; set; }
        public string User_LastName { get; set; }
        public string User_PhoneNumber { get; set; }

        public clsUser()
        {
            this.User_ID = -1;
            this.User_Name = "";
            this.User_Password = "";
            this.User_Type = "";
            this.User_FirstName = "";
            this.User_LastName = "";
            this.User_PhoneNumber = "";

            this.Mode = enMode.AddNew;
        }

        public clsUser(int User_ID, string User_Name, string User_Password,
            string User_Type, string User_FirstName, string User_LastName, string User_PhoneNumber)
        {
            this.User_ID = User_ID;
            this.User_Name = User_Name;
            this.User_Password = User_Password;
            this.User_Type = User_Type;
            this.User_FirstName = User_FirstName;
            this.User_LastName = User_LastName;
            this.User_PhoneNumber = User_PhoneNumber;

            this.Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.User_ID = clsUserDataAccess.AddNewUser(this.User_Name, this.User_Password, this.User_Type,
                this.User_FirstName, this.User_LastName, this.User_PhoneNumber);
            return (this.User_ID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.User_ID,this.User_Name, this.User_Password, this.User_Type,
                this.User_FirstName, this.User_LastName, this.User_PhoneNumber);
        }

        public static bool DeleteUser(int User_ID)
        {
            return clsUserDataAccess.DeleteUser(User_ID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();

            }
            return false;
        }

        public static DataTable GetAllUsersName()
        {
            return clsUserDataAccess.GetAllUsersName();
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static DataTable SearchUser(string searchText)
        {
            return clsUserDataAccess.SearchUser(searchText);
        }

        public static DataTable GetAllDoctorsName()
        {
            return clsUserDataAccess.GetAllDoctorsName();
        }

        public static DataTable GetAllDoctors()
        {
            return clsUserDataAccess.GetAllDoctors();
        }

        public static bool Login(string User_Name,string Password)
        {
            return (clsUserDataAccess.Login(User_Name,Password));
        }


    }
}
