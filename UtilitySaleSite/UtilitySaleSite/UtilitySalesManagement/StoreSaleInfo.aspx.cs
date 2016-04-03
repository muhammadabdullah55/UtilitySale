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
    public partial class StoreSaleInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                hdnStoreInfoID.Value = Request.QueryString["StoreInfoID"].ToString();
                BindData();
            
            }

        }

        public List<Store_Sale> GetStoreSaleData()
        {
            UtilityData UtilityData = new UtilityData();
            List<Store_Sale> storesale = UtilityData.GetStoreSaleInfo(Convert.ToInt32(hdnStoreInfoID.Value));
            return storesale;


        }

        public void BindData()
        {
          List<Store_Sale> storesale =  GetStoreSaleData();
          GridSaleInfo.DataSource = storesale;
          GridSaleInfo.DataBind();
        }


    }
}