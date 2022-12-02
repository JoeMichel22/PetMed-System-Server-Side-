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
        DBConnect connect = new DBConnect();
        SqlCommand sqlCommand = new SqlCommand();
        DataSet userData = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userId;

            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "TP_GetUser";
            sqlCommand.Parameters.AddWithValue("theEmail", txtEmail);
            sqlCommand.Parameters.AddWithValue("thePassword", txtPassword);
            userData = connect.GetDataSet(sqlCommand);

            userId = userData.Tables[0].Rows[0]["UserId"].ToString();

            if (userId != "")
            {
                Session.Add("UserId", userId);
                Session.Add("Email", txtEmail);
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblError.Text = "Your account has not been found, please make sure you have entered the corect email and password.";
                lblError.Visible = true;
            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountRegistration.aspx");
        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {

        }
    }
}