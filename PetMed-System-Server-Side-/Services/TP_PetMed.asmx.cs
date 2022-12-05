using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using Utilities;

namespace PetMed_System_Server_Side_.Services
{
    /// <summary>
    /// Summary description for TP_PetMed
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class TP_PetMed : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        //public string GetPets(string userID)
        //{
        //    SqlCommand objCommand = new SqlCommand();
        //    DBConnect db = new DBConnect();
        //    string petName;
        //    try
        //    {
        //        objCommand.CommandType = CommandType.StoredProcedure;
        //        objCommand.CommandText = "TP_GetPet";
        //        objCommand.Parameters.AddWithValue("@userID", userID);

        //        return  petName = db.GetDataSetUsingCmdObj(objCommand).Tables[0].Rows[0]["Name"].ToString();
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        public DataSet GetPets(string userID)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect db = new DBConnect();
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetPet";
                objCommand.Parameters.AddWithValue("@userID", userID);

                return db.GetDataSetUsingCmdObj(objCommand);
            }
            catch
            {
                return null;
            }
        }
    }
}
