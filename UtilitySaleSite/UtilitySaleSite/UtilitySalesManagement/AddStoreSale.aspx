<%@ Page Title="" Language="C#" MasterPageFile="~/UtilitySalesManagement/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddStoreSale.aspx.cs" Inherits="UtilitySaleSite.UtilitySalesManagement.AddStoreSale" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <form runat="server">
       
    <div class="row">
    <div class="col-md-6 ">
   <div class="portlet box red">
						<div class="portlet-title">
							<div class="caption">
								<i class="fa fa-gift"></i> Add / Edit Sale
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
										<label>Sale Text</label>
										<asp:TextBox TextMode="MultiLine" runat="server" ID="txtSaleText"  class="form-control input-lg" placeholder="Sale Information"> </asp:TextBox>
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
                                    <asp:Button  class="btn green" runat="server" ID="btnSaveSale" Text="Save" OnClick="btnSaveSale_Click" />
									
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
