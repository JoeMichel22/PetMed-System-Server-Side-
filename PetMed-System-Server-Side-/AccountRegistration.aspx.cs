using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetMed_System_Server_Side_
{
    public partial class AccountRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            Validation();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            
            ClearFields(); //clear fields when reset button is clicked
        }

        //validation
        public void Validation()
        {
            if (txtName.Value == "")
            {
                ViewError("Name cannot be blank!");
            }
            else if (txtAddress.Value == "")
            {
                ViewError("Please fill out your address!");
            } else if (txtEmail.Value == "")
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
        }

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