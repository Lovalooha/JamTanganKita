<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="finalProject.Views.TransactionHistory1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
.gridview {
  width: 100%;
  /*this will be the color of the odd row*/
  background-color: #fff;
  margin: 5px 0 10px 0;
  border: solid 1px #525252;
  border-collapse:collapse;
}

/*data elements*/
.gridview td {
  padding: 2px;
  border: solid 1px #c1c1c1;
  color: #717171;
}

/*header elements*/
.gridview th {
  padding: 4px 2px;
  color: #fff;
  background: #424242;
  border-left: solid 1px #525252;
  font-size: 0.9em;
}

</style>

    <div>

            <%--ONLY ACCESSIBLE FOR CUSTOMER--%> 

            <h1> TRANSACTION HISTORY  </h1>	 

            <asp:GridView ID="GridViewHistory" CssClass="gridview" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID"/>
                    <asp:BoundField DataField="TransactionDate" HeaderText="Transacion Date" SortExpression="TransactionDate"/>
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer's name" SortExpression="CustomerName" />

                    <asp:ImageField DataImageUrlField="WatchImage" DataImageUrlFormatString="~/Assets/Watches/{0}" HeaderText ="WatchDetail Picture" ControlStyle-CssClass="w-25">
                        <ControlStyle CssClass="object-fit-contain border rounded" Height="200px" />
                    </asp:ImageField>
 
                    <asp:BoundField DataField="WatchName" HeaderText="Watch name" SortExpression="WatchName" />
                    <asp:BoundField DataField="WatchQty" HeaderText="WatchDetail quantity" SortExpression="WatchQty" />
                    <asp:BoundField DataField="WatchPrice" HeaderText="WatchDetail price " SortExpression="WatchPrice" />
                </Columns>
            </asp:GridView>

        </div>

</asp:Content>
