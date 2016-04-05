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
    public partial class AddStoreSale : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["SaleID"] != null)
                {
                    BindData();
                }
            }
        }

        protected void btnSaveSale_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["SaleID"] == null) // New Record
            {

            }
            else  // update Record
            {

            }

        }
        public Store_Sale GetStoreSalebySaleID(int SaleID)
        {
            UtilityData utilitydata = new UtilityData();
            return utilitydata.GetSaleInfoBySaleID(SaleID);
           
        }
        public void BindData()
        {
            Store_Sale store_sale = GetStoreSalebySaleID(Convert.ToInt32(Request.QueryString["SaleID"]));
            txtSaleText.Text = store_sale.Sale_Text;
            if (store_sale.Is_Active == true)
                chkIsActive.Checked = true;
            else
                chkIsActive.Checked = false;
        }
    }

}