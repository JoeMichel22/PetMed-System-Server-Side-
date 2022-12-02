using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PetMedLibrary;

namespace TP_PetMed_RESTAPI.Controllers
{
    [Route("PetMed/[controller]")]
    [ApiController]
    public class PetMedUserController : ControllerBase
    {
        User request = new User();

        //
        [HttpGet]
        [HttpGet("GetUser/")]
        public bool GetUser()
        {
            
            //request.Email = ;
            //request.Password = ;
            return request.GetUser();
        }

        [HttpGet("GetUser/{email}. {password}")]
        public bool GetUser(string email, string password)
        {
            request.Email = email;
            request.Password = password;

            if (request.GetUser())
            {
                
            }

            return false;
        }

        [HttpPost("CreateUser/{user}")]
        public User CreaeteUser([FromBody]User theUser)
        {
            User newUser = new User();
            newUser.Name = theUser.Name;
            newUser.Email = theUser.Email;
            newUser.Password = theUser.Password;
            newUser.Address = theUser.Address;
            newUser.PhoneNumber = theUser.PhoneNumber;

            return newUser;
        }

        [HttpPost("CreateUser/")]
        public User CreaeteUser([FromBody] string name, string email, string password, string address, string phoneNumber)
        {
            User newUser = new User();
            newUser.Name = name;
            newUser.Email = email;
            newUser.Password = password;
            newUser.Address = address;
            newUser.PhoneNumber = phoneNumber;

            return newUser;
        }
    }
}
