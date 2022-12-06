using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Web.Script.Serialization;
using PetMedLibrary;

namespace PetMed_System_Server_Side_
{
    public partial class Order : System.Web.UI.Page
    {
        string userID;
        Order orderList = new Order();

        protected void Page_Load(object sender, EventArgs e)
        {
            userID = Session["userId"].ToString();
            if (!IsPostBack)
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                orderList = js.Deserialize<Order>(Session["order"].ToString());
                LoadRepeater(orderList);
            }
        }

        private void LoadRepeater(Order theList)
        {
            rptOrder.DataSource = orderList;
            rptOrder.DataBind();

        }
    }
}