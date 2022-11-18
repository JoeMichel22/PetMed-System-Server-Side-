using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMedLibrary
{
    public class User 
    {
        //this class contains information about a user

        private int userID;
        private string username;
        private string password;
        private string email;
        private string address;
        private string phoneNumber;

        //default constructor
        public User() { }

        public User(int userID, string username, string password, string email, string address, string phoneNumber)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.email = email;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        //getters and setters
        public int UserID { get { return userID; } set { userID = value; }}

        public string UserName { get { return username; } set { username = value; }}

        public string Password { get { return password; } set { password = value; }}

        public string Email { get { return email; } set { email = value; }}

        public string Address { get { return address; } set { address = value; }}

        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; }}
    }
}
