using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility.BLL.Setup;

namespace UtilitySaleSite.UtilitySalesManagement
{
    public partial class UtilityInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();

            }


            


        }
        public List<Utility.Data.Utility> GetAllUtilities()
        {
            AdminUtilityData adminUtilitydata = new AdminUtilityData();
            return  adminUtilitydata.GetAllUtilities();
           
        }


        public void BindData()
        {
        
            List<Utility.Data.Utility>  Utility = new List<Utility.Data.Utility>();
            Utility = GetAllUtilities();
            GridUtility.DataSource = Utility;
            GridUtility.DataBind();


        }
        


    }
}