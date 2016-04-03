using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Utility.BLL.Setup;
using Utility.Data;

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
                    UtilityData Data = new UtilityData();
                    List<Store_Info> StoreInformation = Data.GetStoreInfoByUtilityID(Convert.ToInt32(hdnUtilityID.Value));
                    StringBuilder UtilityInformation = new StringBuilder();
                    StringBuilder BranchesAddress = new StringBuilder();
                    int i = 0;

                    foreach (var item in StoreInformation)
                    {
                        UtilityInformation.Append("<div class=\"row\">\n" +
                        "\n" +
                        " <div class=\"col-md-6\">\n" +
                        " <div class=\"portlet box red\">\n" +
                        " <div class=\"portlet-title\">\n" +
                        " <div class=\"caption\">\n" +
                        " <i class=\"fa fa-gift\"></i>" + item.Store_Name + " </div>\n" +
                        " <ul class=\"nav nav-tabs\">\n" + " <li class=\"active\">\n");

                        BranchesAddress.Clear();

                        BranchesAddress.Append("<div class=\"portlet-body\">\n" +
                        " <div class=\"tab-content\">\n");

                        foreach (var Branches in item.Store_Branches)
                        {
                            if (item.Store_Branches.First() == Branches)
                            {
                                UtilityInformation.Append("<li class=\"active\"> <a href=\"#portlet_tab_" + i + "\" data-toggle=\"tab\" aria-expanded=\"true\"> " + Branches.Branch_Name + " </a>\n </li>\n");
                                BranchesAddress.Append(" <div class=\"tab-pane active\" id=\"portlet_tab_" + i + "\">\n" +
" <p> " + Branches.Branch_Address + " </p>\n" +
" </div>\n");
                            }
                            else
                            {
                                UtilityInformation.Append("<li class=\"\">\n" +
                                " <a href=\"#portlet_tab_" + i + "\" data-toggle=\"tab\" aria-expanded=\"false\"> " + Branches.Branch_Name + " </a>\n" +
                                " </li>\n");
                                BranchesAddress.Append(" <div class=\"tab-pane\" id=\"portlet_tab_" + i + "\">\n" +
" <p> " + Branches.Branch_Address + " </p>\n" +
" </div>\n");

                            }
                            i++;


                        }
                        UtilityInformation.Append(" </ul>\n" +
" </div>\n");

                        UtilityInformation.Append(BranchesAddress);
                        UtilityInformation.Append(" </div>\n" +
" </div>\n" +
" </div>\n" +
" </div>\n" +
" \n" +
" </div>");
                    }





                    literalUtilityInformation.Text = UtilityInformation.ToString();
                }
                else
                {
                    hdnUtilityID.Value = "0";

                    lblText.Text = "HOME PAGE....THINK";

                }






            }
            

        }
    }
}