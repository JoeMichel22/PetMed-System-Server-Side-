using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using PetMedLibrary;

namespace PetMed_System_Server_Side_
{
    public partial class LogIn : System.Web.UI.Page
    {
        User user = new User();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Value == "")
            {
                InputError("Please enter an email.");
            }
            else if (txtPassword.Value == "")
            {
                InputError("Please enter a password.");
            }
            else
            {
                GetUser();
            }


        }

        private void GetUser()
        {
            user.Email = txtEmail.Value;
            user.Password = txtPassword.Value;

            if (user.GetUser())
            {
                Session.Add("UserID", user.ID);
                Session.Add("Email", txtEmail.Value);
                Response.Redirect("Home.aspx");
            }
            else
            {
                InputError("Your account has not been found, please make sure you have entered the correct email and password.");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountRegistration.aspx");
        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {

        }

        public void InputError(string error)
        {
           lblError.Text = error;
           lblError.Visible = true;
        }
    }
}