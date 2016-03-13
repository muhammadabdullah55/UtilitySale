<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/UtilitySalesManagement/UtilitySales.Master" CodeBehind="Home.aspx.cs" Inherits="UtilitySaleSite.UtilitySalesManagement.Home" %>
<%--  --%>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1" >
   
    <form runat="server">
        <asp:HiddenField runat="server" ID="hdnUtilityID" />
    </form>


    <script type="text/javascript">
        

         
        $("#li"+<%=hdnUtilityID.Value%>+"").addClass("start active open");
        $("#span"+<%=hdnUtilityID.Value%>+"").addClass("selected");
       

  
        

    </script>

    <h1 >Muhammad Abdullah</h1>
</asp:Content>