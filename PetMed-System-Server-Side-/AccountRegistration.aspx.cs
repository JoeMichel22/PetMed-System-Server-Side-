using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using PetMedLibrary;

namespace PetMed_System_Server_Side_
{
    public partial class AccountRegistration : System.Web.UI.Page
    {
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtName.Value == "")
            {
                ViewError("Name cannot be blank!");
            }
            else if (txtAddress.Value == "")
            {
                ViewError("Please fill out your address!");
            }
            else if (txtEmail.Value == "")
            {
                ViewError("Email cannot be blank!");
            }
            else if (txtPhoneNumber.Value == "")
            {
                ViewError("Please fill out your phone number");
            }
            else if (txtPassword.Value == "" || txtConfirmPassword.Value == "" || txtPassword.Value != txtConfirmPassword.Value)
            {
                ViewError("Please create password or match passwords");
            }
            else
            {
                CreateAccount();
            }
            
        }

        //method to create a user account
        private void CreateAccount()
        {
            user.Name = txtName.Value;
            user.Email = txtEmail.Value;
            user.Address = txtAddress.Value;
            user.PhoneNumber = txtPhoneNumber.Value;
            user.Password = txtPassword.Value;

            try
            {
                //user.CreateUser() returns a boolean value and adds user to database if no error was encountered
                if (user.CreateUser())
                {
                    ViewError("Account Added successfully!");
                    Session["email"] = user.Email;

                    //save login information to a cookie
                    if (chkSaveLoginInfo.Checked)
                    {
                        Response.Cookies["authUserCookie"]["email"] = user.Email;
                        Response.Cookies["authUserCookie"]["password"] = user.Password;
                    }

                    ClearFields();
                    Response.Redirect("~/Home.aspx");

                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        //validation

        //Method to clear all the fields
        public void ClearFields()
        {
            txtName.Value = "";
            txtAddress.Value = "";
            txtEmail.Value = "";
            txtPhoneNumber.Value = "";
            txtPassword.Value = "";
            txtConfirmPassword.Value = "";
        }

        public void ViewError(string error)
        {
            lblError.Text = error;
            lblError.Visible = true;
        }
    }
}