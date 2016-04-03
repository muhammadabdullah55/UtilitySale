<%@ Page Title="" Language="C#" MasterPageFile="~/UtilitySalesManagement/AdminMaster.Master" AutoEventWireup="true" CodeBehind="StoreSaleInfo.aspx.cs" Inherits="UtilitySaleSite.UtilitySalesManagement.StoreSaleInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <form runat="server">

                    <div class="row">
                       <div class="col-md-6">
                  	  <button type="button" onclick="location.href='AddStoreBranches.aspx?StoreID=<%=hdnStoreInfoID.Value %>'" class="btn green">Add New Sale</button>
                      </div>
                    </div>

                    <div class="row">
                    <div class="col-md-6">
					<!-- BEGIN SAMPLE TABLE PORTLET-->
					<div class="portlet box red">
						<div class="portlet-title">
							<div class="caption">
								<i class="fa fa-cogs"></i>Store Sale
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
                                <asp:GridView AutoGenerateColumns="false" class="table table-striped table-bordered table-hover" runat="server" ID="GridSaleInfo" >

                                   <Columns>

                                       <asp:BoundField DataField="Sale_Text"  HeaderText="Sale Text"  />

                                       <asp:BoundField DataField="Created_On"  HeaderText="Created On" />

                                       <asp:HyperLinkField HeaderText="Action" DataNavigateUrlFields="Store_Sale_ID" DataNavigateUrlFormatString="AddStoreSale.aspx?SaleID={0}"  Text="Edit" />

                                   </Columns>

                                </asp:GridView>
							     
							</div>
						</div>
					</div>
					<!-- END SAMPLE TABLE PORTLET-->
				</div>
                    </div>





                            <!-- BEGIN CONDENSED TABLE PORTLET-->
                      <asp:HiddenField runat="server" ID="hdnStoreInfoID" />
                              
                       </form>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
