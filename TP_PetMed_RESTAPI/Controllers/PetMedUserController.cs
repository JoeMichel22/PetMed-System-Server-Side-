using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PetMedLibrary;
using Utilities;

namespace TP_PetMed_RESTAPI.Controllers
{
    [Route("PetMedUser/[controller]")]
    public class PetMedUserController : Controller
    {
        User user = new User();
        DataSet ds = new DataSet();
        DBConnect db = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        [HttpGet]
        [HttpGet("GetUserProfile")]
        [HttpGet("GetUserProfile/{userID}")]
        public User GetUser(string userID)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadUser";
                objCommand.Parameters.AddWithValue("theId", userID);

                ds = db.GetDataSetUsingCmdObj(objCommand);
                user.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                user.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                user.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                user.PhoneNumber = ds.Tables[0].Rows[0]["Phone"].ToString();

                return user;
            }
            catch (Exception ex)
            {
                return null;
            }

        }


        [HttpPost("CreateUser")]//add in the attribute names
        public bool CreateUser([FromBody] string name, string email, string password, string address, string phoneNumber)
        {
            User newUser = new User();
            newUser.Name = name;
            newUser.Email = email;
            newUser.Password = password;
            newUser.Address = address;
            newUser.PhoneNumber = phoneNumber;

            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_CreateUser";
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
    }
}
