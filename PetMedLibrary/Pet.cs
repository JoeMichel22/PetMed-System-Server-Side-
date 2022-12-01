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

        public void AddPet(int userID)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddPet";
            objCommand.Parameters.AddWithValue("@name", name);
            objCommand.Parameters.AddWithValue("@species",species);
            objCommand.Parameters.AddWithValue("@age", age);
            objCommand.Parameters.AddWithValue("@owner", userID);
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
