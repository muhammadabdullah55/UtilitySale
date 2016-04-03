using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility.BLL.Setup;

namespace UtilitySaleSite.UtilitySalesManagement
{
    public partial class UtilitySales : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Menus = "";
                DateTime dt = DateTime.Now;
                UtilityData UtilityDataClass = new UtilityData();
                List<Utility.Data.Utility> Utility = UtilityDataClass.GetAllUtilities();
                foreach (var item in Utility)
                {
                    Menus += "<li  id=\"li"+item.Utility_ID+"\"  ><a href=\"Home.aspx?Utility="+ item.Utility_ID +"\";\"><i ></i><span class=\"title\">"+item.Utility_Name+"</span><span  id=\"span"+item.Utility_ID+"\"></span></a></li>";
                    
                }

                Literal_MenuItems.Text = Menus;
            }
      

        }
    }
}  