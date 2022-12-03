using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetMed_System_Server_Side_
{
    public partial class Home : System.Web.UI.Page
    {
        int userID;
        string email;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                userID = int.Parse(Session["userID"].ToString());
                email = Session["email"].ToString(); 

                lblWelcome.Text = "Welcome" + email;
            }
        }
    }
}