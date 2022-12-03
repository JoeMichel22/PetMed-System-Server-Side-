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

        User user = new User();
        Pet pet = new Pet();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //[Category('Misc')]
        //public String ProductID

        //{
        //    get { return petID; }

        //    set { petID = value; }
        //}

        public override void DataBind()
        {
           DataSet ds = new DataSet();
            ds = pet.GetPets(user.UserID);

            lblPetName.Text = ds.Tables[0].Rows[0]["PetName"].ToString();
            lblPetSpecies.Text = ds.Tables[0].Rows[0]["PetSpecies"].ToString();
            lblPetAge.Text = ds.Tables[0].Rows[0]["PetAge"].ToString();
        }
    }
}