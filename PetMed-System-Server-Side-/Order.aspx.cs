using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using PetMedLibrary;

namespace PetMed_System_Server_Side_
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //LoadRepeater(arraylist variable??);
            }
        }

        private void LoadRepeater(ArrayList orderList)
        {
            rptOrder.DataSource = orderList;
            rptOrder.DataBind();

        }
    }
}