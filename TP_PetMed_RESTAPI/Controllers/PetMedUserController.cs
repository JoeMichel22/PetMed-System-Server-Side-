using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP_PetMed_RESTAPI.Controllers
{
    [Route("PetMed/[controller]")]
    [ApiController]
    public class PetMedUserController : ControllerBase
    {
        //
        [HttpGet]
        public bool GetUser()
        {
            

            return false;
        }
    }
}
