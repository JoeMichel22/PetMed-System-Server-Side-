using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace PetMedLibrary
{
    public class Pet
    {
        private string name;
        private string species;
        private int age;

        DBConnect db = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        User user = new User();

        public bool AddPet(int userID)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_AddPet";
                objCommand.Parameters.AddWithValue("@name", name);
                objCommand.Parameters.AddWithValue("@species", species);
                objCommand.Parameters.AddWithValue("@age", age);
                objCommand.Parameters.AddWithValue("@owner", userID);

                db.GetDataSetUsingCmdObj(objCommand);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet GetPets(string userID)
        {
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

        public Pet() 
        {
            name = "";
            species = "";
            age = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
