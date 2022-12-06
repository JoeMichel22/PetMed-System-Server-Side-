using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PetMedLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace PetMed_System_Server_Side_
{
    public partial class Home : System.Web.UI.Page
    {
        User user = new User();
        DataSet dataSet = new DataSet();
        Medication medication = new Medication();
        ArrayList order = new ArrayList();
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
                if (dataSet != null || dataSet.Tables[0].Rows.Count != 0)
                {
                    user.Name = dataSet.Tables[0].Rows[0]["Name"].ToString();

                    lblWelcome.Text = "Welcome " + user.Name;
                }
                else
                {
                    lblWelcome.Text = "Welcome " + email;
                }

                //dynamically add content to the dropdown
                ddlMedicationFilter.DataSource = medication.GetSpecies(userID);
                ddlMedicationFilter.DataTextField = "Species";
                ddlMedicationFilter.DataBind();

                //load the medication
                gvMedication.DataSource = medication.LoadMedication();
                gvMedication.DataBind();
            }
        }

        protected void ddlMedicationFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string species = ddlMedicationFilter.SelectedValue;
            LoadMedication(species);
        }

        protected void btnOrder_Clicked(object sender, EventArgs e)
        {
            //Call the process order method
            if(ProcessOrder())
            {
                Session.Add("order", order);
                Response.Redirect("Order.aspx");
            }
        }

        //load medication depending on value selected in the dropdown
        private void LoadMedication(string species)
        {
            gvMedication.DataSource = medication.GetMedication(species);
            gvMedication.DataBind();
        }

        private bool ProcessOrder()
        {
            CheckBox checkbox;
            TextBox textbox;
            int count = 0;
            try
            {
                for (int row = 0; row < gvMedication.Rows.Count; row++)
                {
                    Medication med = new Medication();
                    checkbox = (CheckBox)gvMedication.Rows[row].FindControl("chkSelectMedication");
                    textbox = (TextBox)gvMedication.Rows[row].FindControl("txtQuantity");
                    int errorHandler = 0;

                    if (checkbox.Checked)
                    {
                        if (textbox.Text == "" || int.TryParse(textbox.Text, out errorHandler) == false)
                        {
                            lblError.Visible = true;
                            lblError.Text = "Please enter a valid Quantity";
                            break;
                        }
                        else
                        {
                            med.MedName = gvMedication.Rows[row].Cells[1].Text;
                            med.MedDescription = gvMedication.Rows[row].Cells[2].Text;
                            med.Disease = gvMedication.Rows[row].Cells[3].Text;
                            med.Species = gvMedication.Rows[row].Cells[4].Text;
                            med.MedPrice = double.Parse(gvMedication.Rows[row].Cells[6].Text);
                            med.MedQuantity = int.Parse(gvMedication.Rows[row].Cells[7].Text);

                            order.Add(med);

                            count += 1;
                        }

                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}