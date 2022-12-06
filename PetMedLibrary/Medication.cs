using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace PetMedLibrary
{
    public class Medication
    {
        //class for medication

        private int medID;
        private string medName;
        private string medDescription;
        private string disease;
        private string species;
        private int medStock;
        private double medPrice;
        private int medQuantity;

        DBConnect db = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet dataset = new DataSet();

        public int MedID
        {
            get { return medID; } 
            set { medID = value; }
        }

        public string MedName 
        { 
            get { return medName; }
            set { medName = value; }
        }

        public string MedDescription
        {
            get { return medDescription; }
            set
            {
                medDescription = value;
            }
        }

        public string Disease
        {
            get { return disease; }
            set { disease = value; }
        }

        public string Species
        {
            get { return species; }
            set
            {
                species = value;
            }
        }

        public int MedStock
        {
            get { return medStock; }
            set { medStock = value; }
        }

        public double MedPrice
        {
            get { return medPrice; }
            set { medPrice = value; }   
        }

        public int MedQuantity 
        { 
            get { return medQuantity; }
            set { medQuantity = value; }
        }

        public DataSet GetMedication(string species)
        {

            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetMedication";
                objCommand.Parameters.AddWithValue("species", species);

                return db.GetDataSetUsingCmdObj(objCommand);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataSet LoadMedication()
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadMedication";

                return db.GetDataSetUsingCmdObj(objCommand);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataSet GetSpecies(string userID)
        {
            try
            {
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_LoadSpecies";
                objCommand.Parameters.AddWithValue("userID", userID);

                return db.GetDataSetUsingCmdObj(objCommand);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
