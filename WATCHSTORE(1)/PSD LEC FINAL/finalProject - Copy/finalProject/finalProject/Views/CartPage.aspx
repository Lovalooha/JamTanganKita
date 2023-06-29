<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="finalProject.Views.CartPage1" %>
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

.delete-button {
    border: none;
    outline: none;
    background-color: red;
    padding: 10px;
    border-radius: 10px;
    color: #fff;
    font-size: 16px;
    transition: 0.3s ease;
    text-align :center;
}

</style>


    <div>
            <%--ONLY ACCESSIBLE FOR CUSTOMER--%> 

            <h1> CART PAGE </h1>
            <asp:GridView ID="GridViewCart" CssClass="gridview" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridViewCart_RowDeleting">
                <Columns>

                    <asp:BoundField DataField="WatchDetailID" HeaderText="ID" SortExpression="WatchDetailID" />
                    <asp:ImageField DataImageUrlField="WatchImage" DataImageUrlFormatString="~/Assets/Watches/{0}" HeaderText ="Watch Picture" ControlStyle-CssClass="w-25">
                        <ControlStyle CssClass="object-fit-contain border rounded" Height="200px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="WatchName" HeaderText="Watch Name" SortExpression="WatchName" />
                    <asp:BoundField DataField="Qty" HeaderText="Watch Quantity" SortExpression="Qty" />
                    <asp:BoundField DataField="WatchPrice" HeaderText="Watch Price" SortExpression="WatchPrice" />
       
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True" ShowHeader="True">
                        <ItemStyle CssClass="delete-button" />
                    </asp:CommandField>
       
                </Columns>
            </asp:GridView><br/>

        <asp:Button ID="checkoutBtn" runat="server" Text="Checkout" OnClick="checkoutBtn_Click"/>

        </div>
</asp:Content>
