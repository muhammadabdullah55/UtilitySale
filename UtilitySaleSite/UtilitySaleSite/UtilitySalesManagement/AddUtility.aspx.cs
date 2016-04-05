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
    public partial class AddUtility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCity();
                if (Request.QueryString["UtilityID"] != null)
                {
                    BindData();
                }
              
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["UtilityID"] == null) // New Record
            {
                AdminUtilityData adminutilitydata = new AdminUtilityData();
               
               
            }
            else  // update Record
            {

            }

        }
        public void BindCity()
        {
            List<City> Cities = GetAllCities();
            ddlCity.DataSource = Cities;
            ddlCity.DataBind();
        }

        public List<City> GetAllCities()
        {

            UtilityData utilitydata = new UtilityData();

            return utilitydata.GetAllCities();
        }

        public Utility.Data.Utility GetUtilityByID(int UtilityID)
        {
            UtilityData utilitydata = new UtilityData();

            return utilitydata.GetUtilityByID(UtilityID);
        }

        public void BindData()
        {
            int UtilityID = Convert.ToInt32(Request.QueryString["UtilityID"]);
            Utility.Data.Utility utility = GetUtilityByID(UtilityID);
            txtUtilityName.Text = utility.Utility_Name;

            ddlCity.Items.FindByValue(utility.City_ID.ToString()).Selected = true;
           
            if (utility.Is_Active == true)
                chkIsActive.Checked = true;
            else
                chkIsActive.Checked = false;
           

        }

    }
}