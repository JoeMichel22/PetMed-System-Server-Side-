using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using PetMedLibrary;
using System.Data;

namespace PetMed_System_Server_Side_
{
    public partial class PetDisplay : System.Web.UI.UserControl
    {
        //Custom user control for displaying pets
        
        string userId;
        string petID;
        string petName;
        string species;
        string petAge;

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //define the properties for the customer use control for the pets
        [Category("Misc")]
        public string PetID
        {
            get { return petID; }
            set { petID = value; }
        }

        [Category("Misc")]
        public String PetName
        {
            get { return petName; }

            set { petName = value; }
        }

        [Category("Misc")]
        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        [Category("Misc")]
        public string PetAge
        {
            get { return petAge; }
            set { petAge = value; }
        }

        //method that is called to the Pet page to bind the control upon page load
        public override void DataBind()
        {
            //asing the appropriate values
            lblPetName.Text = petName;
            lblPetSpecies.Text = species;
            lblPetAge.Text = petAge;
        }

        protected void btnDeletePet_Click(object sender, EventArgs e)
        {

        }
    }
}