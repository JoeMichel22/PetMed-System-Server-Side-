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
        Emailing autoEmail = new Emailing();

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
                Session.Add("Email", user.Email);

                //save login information to a cookie
                if (chkSaveLoginInfo.Checked)
                {
                    Response.Cookies["authUserCookie"]["email"] = user.Email;
                    Response.Cookies["authUserCookie"]["password"] = user.Password;
                }

                Response.Redirect("Home.aspx");
            }
            else
            {
                InputError("Your account has not been found, please make sure you have entered the correct email and password.");
            }
        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {
            if(txtEmail.Value == "")
            {
                InputError("Please enter your email above first.");
            }
            else
            {
                string forgotten = user.GetPassword(txtEmail.Value);

                if(forgotten == "")
                {
                    InputError("The email entered was not found. Please check and try again.");
                }
                else
                {
                    forgotten = "Here is your the password you forgot " + user.GetPassword(txtEmail.Value) + ". Try not to forget it again -__-";

                    autoEmail.Reciever = txtEmail.Value;
                    autoEmail.Message = forgotten;

                    InputError(autoEmail.RecoverPassword());
                }

                
            }
        }

        public void InputError(string error)
        {
           lblError.Text = error;
           lblError.Visible = true;
        }
    }
}