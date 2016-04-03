<%@ Page Title="" Language="C#" MasterPageFile="~/UtilitySalesManagement/AdminMaster.Master" AutoEventWireup="true" CodeBehind="StoreInfo.aspx.cs" Inherits="UtilitySaleSite.UtilitySalesManagement.StoreInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

             <form runat="server">

                  <div class="row">
                       <div class="col-md-6">
                  	  <button type="button" onclick="location.href='AddUtilityStore.aspx?UtilityID=<%=hdnUtilityID.Value %>'" class="btn green">Add New Store</button>
                      </div>
                    </div>

                    <div class="row">
                    <div class="col-md-6">
					<!-- BEGIN SAMPLE TABLE PORTLET-->
					<div class="portlet box red">
						<div class="portlet-title">
							<div class="caption">
								<i class="fa fa-cogs"></i>Stores
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
                                <asp:GridView AutoGenerateColumns="false" class="table table-striped table-bordered table-hover" runat="server" ID="GridStore" >

                                   <Columns>

                                       <asp:BoundField DataField="Store_Name"  HeaderText="Name"  />

                                       <asp:BoundField DataField="Created_On"  HeaderText="Created On" />

                                       <asp:HyperLinkField HeaderText="Branches" DataNavigateUrlFields="Store_Info_ID" DataNavigateUrlFormatString="StoreBranches.aspx?StoreInfoID={0}"  Text="Branches" />

                                       <asp:HyperLinkField HeaderText="Sale Info" DataNavigateUrlFields="Store_Info_ID" DataNavigateUrlFormatString="StoreSaleInfo.aspx?StoreInfoID={0}"  Text="Sale Info" />

                                       <asp:HyperLinkField HeaderText="Action" DataNavigateUrlFields="Store_Info_ID" DataNavigateUrlFormatString="AddUtilityStore.aspx?StoreInfoID={0}"  Text="Edit" />

                                   </Columns>

                                </asp:GridView>
							     
							</div>
						</div>
					</div>
					<!-- END SAMPLE TABLE PORTLET-->
				</div>
                    </div>


                 <asp:HiddenField runat="server" ID="hdnUtilityID"  />


                            <!-- BEGIN CONDENSED TABLE PORTLET-->
                      
                              
                       </form>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
