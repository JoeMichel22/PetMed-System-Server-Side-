﻿using Microsoft.AspNetCore.Http;
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
    [Route("PetMedUser/[controller]")]
    public class PetMedUserController : ControllerBase
    {
        User wanted = new User();

        [HttpGet("GetUser/{email}")]
        public bool GetUser(string email)
        {
            wanted.Email = email;

            if (wanted.GetUser())
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }


        [HttpPost("CreateUser/")]//add in the attribute names
        public User CreateUser([FromBody] string name, string email, string password, string address, string phoneNumber)
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
