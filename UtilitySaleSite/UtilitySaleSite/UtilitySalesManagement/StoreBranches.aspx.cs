using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility.BLL.Setup;
using Utility.Data;

namespace UtilitySaleSite.UtilitySalesManagement
{
    public partial class StoreBranches : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hdnStoreInfoID.Value = Request.QueryString["StoreInfoID"].ToString();
                BindData();
            }
        }


        public List<Store_Branches> GetBranchByStoreID(int Store_Info_ID)
        {
            UtilityData utilitydata = new UtilityData();
            List<Store_Branches> Branches = utilitydata.GetBranchByStoreID(Store_Info_ID);
            return Branches;
        }

        public void BindData()
        {
            List<Store_Branches> Branches = GetBranchByStoreID(Convert.ToInt32(Request.QueryString["StoreInfoID"]));
            GridBranches.DataSource = Branches;
            GridBranches.DataBind();
        }

    }
}