using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace UtilitySaleSite.UtilitySalesManagement
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
  
                if (Request.QueryString["Utility"] != null)
                {
                    hdnUtilityID.Value = Request.QueryString["Utility"].ToString();
                }
                else
                    hdnUtilityID.Value = "0";






            }
        }
    }
}