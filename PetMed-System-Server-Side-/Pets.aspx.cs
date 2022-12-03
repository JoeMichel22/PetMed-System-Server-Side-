using PetMedLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace PetMed_System_Server_Side_
{
    public partial class Pets : System.Web.UI.Page
    {
        Pet pet = new Pet();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            string userID = Session["userID"].ToString();
            ds = pet.GetPets(userID);

            int count = ds.Tables[0].Rows.Count;

            for (int recordCount = 0; recordCount < count; recordCount++)
            {
                PetDisplay ctrl = (PetDisplay)LoadControl("PetDisplay.ascx");

                ctrl.DataBind();

                Form.Controls.Add(ctrl);
            }
        }
    }
}