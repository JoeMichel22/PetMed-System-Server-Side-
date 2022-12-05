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

        //method returns true if user has been found and false if user is not found or error occurred
        public bool GetUser()
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetUser";
                objCommand.Parameters.AddWithValue("theEmail", email);
                objCommand.Parameters.AddWithValue("thePassword", password);

                dataset = db.GetDataSetUsingCmdObj(objCommand);
                id= dataset.Tables[0].Rows[0]["UserId"].ToString();

                objCommand.Parameters.Clear();

                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public string GetPassword(string email)
        {
            try
            {

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetPassword";
                objCommand.Parameters.AddWithValue("theEmail", email);

                dataset = db.GetDataSetUsingCmdObj(objCommand);

                return dataset.Tables[0].Rows[0]["Password"].ToString();
            }
            catch
            {
                return "";
            }
        }
        //Method to update user information
        public bool UpdateUser(string userID)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_UpdateUSer";
                objCommand.Parameters.AddWithValue("@ID", int.Parse(userID));
                objCommand.Parameters.AddWithValue("@Name", name);
                objCommand.Parameters.AddWithValue("@Email", email);
                objCommand.Parameters.AddWithValue("@Address", address);
                objCommand.Parameters.AddWithValue("@Phone", phoneNumber);

                db.DoUpdateUsingCmdObj(objCommand);

                objCommand.Parameters.Clear();

                return true;
            }
            catch
            {
                return false;
            }
        }

        //(overloaded) Method returns a dataset containing the user found based on the ID
        public DataSet GetUser(string userID)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadUser";
                objCommand.Parameters.AddWithValue("theId", userID);

                return db.GetDataSetUsingCmdObj(objCommand);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


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
