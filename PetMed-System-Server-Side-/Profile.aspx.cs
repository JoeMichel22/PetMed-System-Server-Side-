﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.IO;                        
using System.Net;
using PetMedLibrary;
using Utilities;

namespace PetMed_System_Server_Side_
{
    public partial class Profile : System.Web.UI.Page
    {

        DataSet ds = new DataSet();
        User user = new User();
        string userID;
        string apiURL = "http://cis-iis2.temple.edu/users/tun69277/TermProjectTest/Home.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Session["userId"].ToString();
            if (!IsPostBack)
            {
                WebRequest request = WebRequest.Create(apiURL + "GetUserProfile/" + userID);
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader dataReader = new StreamReader(dataStream);
                String userData = dataReader.ReadToEnd();
                dataReader.Close();
                response.Close();

                JavaScriptSerializer js = new JavaScriptSerializer();
                user = js.Deserialize<User>(userData);
                txtName.Value = user.Name;
                txtEmail.Value = user.Email;
                txtAddress.Value = user.Address;
                txtPhone.Value = user.PhoneNumber;
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