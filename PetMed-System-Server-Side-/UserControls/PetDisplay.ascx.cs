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
            Pet pet = new Pet();
            DataSet ds = new DataSet();
            userId = Session["userId"].ToString();

            ds = pet.GetPets(userId);

            if (ds.Tables[0].Rows.Count != 0)
            {
                lblPetName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                lblPetSpecies.Text = ds.Tables[0].Rows[0]["Species"].ToString();
                lblPetAge.Text = ds.Tables[0].Rows[0]["Age"].ToString();
            }
        }
    }
}