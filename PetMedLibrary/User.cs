using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace PetMedLibrary
{
    public class User
    {
        //this class contains information about a user
        private string userID;
        private string name;
        private string password;
        private string email;
        private string address;
        private string phoneNumber;
        private string id;

        //database connection
        DBConnect db = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet dataset = new DataSet();

        //default constructor
        public User() { }

        public User(string name, string password, string email, string address, string phoneNumber)
        {
            this.name = name;
            this.password = password;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public bool CreateUser()
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_CreateUser";

                //Execute the stored procedure using the DBConnect and SqlCommand
                objCommand.Parameters.AddWithValue("@theName", name);
                objCommand.Parameters.AddWithValue("@theEmail", email);
                objCommand.Parameters.AddWithValue("@theAddress", address);
                objCommand.Parameters.AddWithValue("@thePhone", phoneNumber);
                objCommand.Parameters.AddWithValue("@thePassword", password);

                db.GetDataSetUsingCmdObj(objCommand);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool GetUser()
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetUser";
                objCommand.Parameters.AddWithValue("theEmail", email);
                objCommand.Parameters.AddWithValue("thePassword", password);

                db.GetDataSetUsingCmdObj(objCommand);
                id= dataset.Tables[0].Rows[0]["UserId"].ToString();

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        //public bool LoadUser() { }

        //getters and setters
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string ID
        {
            get { return id; }
        }

    }
}
