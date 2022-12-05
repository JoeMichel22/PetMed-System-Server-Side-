using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetMedLibrary;

namespace PetMed_System_Server_Side_
{
    public partial class Home : System.Web.UI.Page
    {
        User user = new User();
        DataSet dataSet = new DataSet();    
        string userID;
        string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Session["userID"].ToString();
            if (!IsPostBack)
            {
                email = Session["email"].ToString();

                dataSet = user.GetUser(userID);

                //checks to see if the dataset is null
                //sets the welcome message to the email if dataset is null
                if(dataSet != null || dataSet.Tables[0].Rows.Count != 0)
                {
                    user.Name = dataSet.Tables[0].Rows[0]["Name"].ToString();

                    lblWelcome.Text = "Welcome " + user.Name;
                } else
                {
                    lblWelcome.Text = "Welcome " + email;
                }
            }
        }

        protected void ddlMedicationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}