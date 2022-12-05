using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PetMedLibrary
{
    public class Medication
    {
        //class for medication

        private int medID;
        private string medName;
        private string medDescription;
        private string species;
        private int medStock;
        private double medPrice;

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

        //public DataSet GetMedication(string species)
        //{

        //    try
        //    {

        //    }
        //}
    }
}
