using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility.BLL.Setup;

namespace UtilitySaleSite.UtilitySalesManagement
{
    public partial class StoreInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindData();
                hdnUtilityID.Value = Request.QueryString["UtilityID"].ToString();

            }

           

        }
        public List<Utility.Data.Store_Info> GetStoreInfo()
        {
            AdminStoreInfo adminstoreinfo = new AdminStoreInfo();
            List<Utility.Data.Store_Info> storeinfo= adminstoreinfo.GetStoreByUtilityID(Convert.ToInt32(Request.QueryString["UtilityID"]));
            return storeinfo;


        }

        public void BindData()
        {
            List<Utility.Data.Store_Info> StoreInfo = GetStoreInfo();
            GridStore.DataSource = StoreInfo;
            GridStore.DataBind();
        }
    }
}