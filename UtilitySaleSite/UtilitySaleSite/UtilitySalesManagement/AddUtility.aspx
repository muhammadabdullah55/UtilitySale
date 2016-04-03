<%@ Page Title="" AutoEventWireup="true" Language="C#" MasterPageFile="~/UtilitySalesManagement/AdminMaster.Master" EnableEventValidation="false" CodeBehind="AddUtility.aspx.cs" Inherits="UtilitySaleSite.UtilitySalesManagement.AddUtility" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
       
    <div class="row">
     
    <div class="col-md-6 ">
   <div class="portlet box red">
						<div class="portlet-title">
							<div class="caption">
								<i class="fa fa-gift"></i> Add / Edit Utility
							</div>
							<div class="tools">
								<a href="" class="collapse" data-original-title="" title="">
								</a>
								<a href="#portlet-config" data-toggle="modal" class="config" data-original-title="" title="">
								</a>
								<a href="" class="reload" data-original-title="" title="">
								</a>
								<a href="" class="remove" data-original-title="" title="">
								</a>
							</div>
						</div>
						<div class="portlet-body form">
							<form role="form">
								<div class="form-body">
									<div class="form-group">
										<label>Utility Name</label>
										<asp:TextBox runat="server" ID="txtUtilityName"  class="form-control input-lg" placeholder="Utility Name"> </asp:TextBox>
									</div>
									<div class="form-group">
											<label>City</label>
                                        <asp:DropDownList DataTextField="City_Name" DataValueField="City_ID" class="form-control input-lg" runat="server" ID="ddlCity"></asp:DropDownList>
										
									</div>
                                     <div class="row">
                   
                             <label class="control-label col-md-4">Activate</label>
                            <div class="checkbox-list">
                                <label class="checkbox-inline">
                                    <asp:CheckBox ID="chkIsActive" runat="server" />
                                    Is Active
                                </label>
                               
                            </div>
                        </div>
                                    </div>

								
								<div class="form-actions right">
									<button type="button" class="btn default">Cancel</button>
                                    <asp:Button  class="btn green" runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click" />
									
								</div>
							</form>
						</div>
					</div>
        </div>
       
        </div>
       </form>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

</asp:Content>
