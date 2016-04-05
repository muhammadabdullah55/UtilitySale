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
    public partial class AddUtilityStore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["StoreInfoID"] != null)
                {
                    BindData();
                }
            }
        }

        protected void btnSaveStore_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["StoreInfoID"] == null) // New Record
            {

            }
            else  // update Record
            {

            }

        }
        public void BindData()
        {
            UtilityData utilitydata = new UtilityData();
            Store_Info store_info =  utilitydata.GetStoreInfoByStoreInfoID(Convert.ToInt32(Request.QueryString["StoreInfoID"]));
            txtStoreName.Text = store_info.Store_Name;
            if (store_info.Is_Active == true)
                chkIsActive.Checked = true;
            else
                chkIsActive.Checked = false;


        }
    }
}