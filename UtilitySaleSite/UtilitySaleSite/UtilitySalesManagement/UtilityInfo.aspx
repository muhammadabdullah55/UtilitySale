<%@ Page Title="" Language="C#" MasterPageFile="~/UtilitySalesManagement/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UtilityInfo.aspx.cs" Inherits="UtilitySaleSite.UtilitySalesManagement.UtilityInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
                <form runat="server">
                    <div class="row">
                        <div class="col-md-6">
                  	  <button type="button" onclick="location.href='AddUtility.aspx'" class="btn green">Add New Utility</button>
                      </div>
                    </div>
                    <br />
                    <div class="row">
                      
                       <div class="col-md-6">
					<!-- BEGIN SAMPLE TABLE PORTLET-->
					<div class="portlet box red">
						<div class="portlet-title">
							<div class="caption">
								<i class="fa fa-cogs"></i>Utility
							</div>
							<div class="tools">
								<a href="javascript:;" class="collapse" data-original-title="" title="">
								</a>
								<a href="#portlet-config" data-toggle="modal" class="config" data-original-title="" title="">
								</a>
								<a href="javascript:;" class="reload" data-original-title="" title="">
								</a>
								<a href="javascript:;" class="remove" data-original-title="" title="">
								</a>
							</div>
						</div>
						<div class="portlet-body" style="display: block;">
							<div class="table-scrollable">
                                <asp:GridView AutoGenerateColumns="false" class="table table-striped table-bordered table-hover" runat="server" ID="GridUtility" >

                                   <Columns>

                                       <asp:BoundField DataField="Utility_Name"  HeaderText="Name"  />

                                                <asp:TemplateField HeaderText="City">
                                                    <ItemTemplate >

                                                        <asp:Label   runat="server" ID="lblCity" ><%# Eval("City_ID").ToString() == "1" ? "Karachi" : "Lahore" %> </asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                                   <asp:BoundField DataField="Created_On"  HeaderText="Created On" />
                                                
                                                  <asp:HyperLinkField HeaderText="Store Info" DataNavigateUrlFields="Utility_ID,Utility_Name" DataNavigateUrlFormatString="StoreInfo.aspx?UtilityID={0}&UtilityName={1}"  Text="Store Info" />

                                                  <asp:HyperLinkField HeaderText="Action" DataNavigateUrlFields="Utility_ID" DataNavigateUrlFormatString="AddUtility.aspx?UtilityID={0}"  Text="Edit" />

                                   </Columns>

                                </asp:GridView>
							     
							</div>
						</div>
					</div>
					<!-- END SAMPLE TABLE PORTLET-->
				</div>
                    </div>





                            <!-- BEGIN CONDENSED TABLE PORTLET-->
                      
                              
                       </form>
                                       
                                       
                                   
      
          
    


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
