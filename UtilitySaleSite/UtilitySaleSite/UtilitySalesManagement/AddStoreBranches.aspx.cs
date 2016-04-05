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
    public partial class AddStoreBranches : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["BranchID"] != null)
                {
                    BindData();
                }
            }
        }

        protected void btnSaveBranch_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["BranchID"] == null) // New Record
            {

            }
            else  // update Record
            {

            }
        }

        public Store_Branches GetBranchByID(int BranchID)
        {
            UtilityData utilitydata = new UtilityData();
            return utilitydata.GetBranchByBranchID(BranchID);
        }

        public void BindData()
        {
            Store_Branches branches = GetBranchByID(Convert.ToInt32(Request.QueryString["BranchID"]));
            txtBranchAddress.Text = branches.Branch_Address;
            txtBranchName.Text = branches.Branch_Name;
            if (branches.Is_Active == true)
                chkIsActive.Checked = true;
            else
                chkIsActive.Checked = false;


        }
    }
}