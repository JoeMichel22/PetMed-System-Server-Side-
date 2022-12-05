using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetMedLibrary;
using Utilities;

namespace PetMed_System_Server_Side_
{
    public partial class Profile : System.Web.UI.Page
    {

        DataSet ds = new DataSet();
        User user = new User();
        string userID;

        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Session["userId"].ToString();
            if (!IsPostBack)
            {
                ds = user.GetUser(userID);

                txtName.Value = ds.Tables[0].Rows[0]["Name"].ToString();
                txtEmail.Value = ds.Tables[0].Rows[0]["Email"].ToString();
                txtAddress.Value = ds.Tables[0].Rows[0]["Address"].ToString();
                txtPhone.Value = ds.Tables[0].Rows[0]["Phone"].ToString();
            }
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {
            user.Name = txtName.Value;
            user.Email = txtEmail.Value;
            user.Address = txtAddress.Value;
            user.PhoneNumber = txtPhone.Value;

            if(user.UpdateUser(userID))
            {
                lblSuccessMessage.Visible = true;
                lblSuccessMessage.Text = "Updated Successfully";
            } else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "An error occured. Please make sure all values are valid";
            }
        }
    }
}