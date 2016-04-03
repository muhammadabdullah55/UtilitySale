<%@ Page Title="" Language="C#" MasterPageFile="~/UtilitySalesManagement/AdminMaster.Master" AutoEventWireup="true" CodeBehind="StoreBranches.aspx.cs" Inherits="UtilitySaleSite.UtilitySalesManagement.StoreBranches" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <form runat="server">

                    <div class="row">
                       <div class="col-md-6">
                  	  <button type="button" onclick="location.href='AddStoreBranches.aspx?StoreID=<%=hdnStoreInfoID.Value %>'" class="btn green">Add New Branch</button>
                      </div>
                    </div>

                    <div class="row">
                    <div class="col-md-6">
					<!-- BEGIN SAMPLE TABLE PORTLET-->
					<div class="portlet box red">
						<div class="portlet-title">
							<div class="caption">
								<i class="fa fa-cogs"></i>Branches
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
                                <asp:GridView AutoGenerateColumns="false" class="table table-striped table-bordered table-hover" runat="server" ID="GridBranches" >

                                   <Columns>

                                       <asp:BoundField DataField="Branch_Name"  HeaderText="Name"  />

                                       <asp:BoundField DataField="Branch_Address"  HeaderText="Address"  />

                                       <asp:BoundField DataField="Created_On"  HeaderText="Created On" />

                                       <asp:HyperLinkField HeaderText="Action" DataNavigateUrlFields="Store_Branch_ID" DataNavigateUrlFormatString="AddStoreBranches.aspx?BranchID={0}"  Text="Edit" />

                                   </Columns>

                                </asp:GridView>
							     
							</div>
						</div>
					</div>
					<!-- END SAMPLE TABLE PORTLET-->
				</div>
                    </div>


                  <asp:HiddenField runat="server" ID="hdnStoreInfoID" />


                            <!-- BEGIN CONDENSED TABLE PORTLET-->
                      
                              
                       </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
