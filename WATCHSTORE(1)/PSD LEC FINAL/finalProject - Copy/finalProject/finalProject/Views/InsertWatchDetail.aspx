 <%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="InsertWatchDetail.aspx.cs" Inherits="finalProject.Views.InsertWatchDetail1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <style>
        .form {
            display: flex;
            justify-content: center;
            flex-direction: column;
            gap: 10px;
            max-width: 500px;
            background-color: #fff;
            padding: 20px;
            border-radius: 20px;
            position: relative;
            margin: 80px auto;
            box-shadow: 0 14px 28px rgba(0,0,0,0.25), 
			0 10px 10px rgba(0,0,0,0.22);
        }
    </style>

    <div>
            <%--ADMIN ONLY--%> 
            
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="WatchImage" HeaderText="Watch Image" SortExpression="WatchImage" />
                    <asp:BoundField DataField="WatchName" HeaderText="Watch Name" SortExpression="WatchName" />
                    <asp:BoundField DataField="WatchImage" HeaderText="Watch Image" SortExpression="WatchImage" />
                    <asp:BoundField DataField="WatchName" HeaderText="Watch Name" SortExpression="WatchName" />
                    <asp:BoundField DataField="WatchPrice" HeaderText="Watch Price" SortExpression="WatchPrice" />
                    <asp:BoundField DataField="WatchDescription" HeaderText="Watch Description" SortExpression="WatchDescription" />
                    
                </Columns>
            </asp:GridView>


                <div class="form">

                    <p class="title"> Insert Watch Detail </p>

                    <label>
                        <asp:Label ID="lblName" runat="server" Text="Name :"></asp:Label>
                        <asp:TextBox ID="txtName" placeholder="Wacth Name" type="text" CssClass="input" runat="server"></asp:TextBox>
                    </label> 
                    <label>
                        <asp:Label ID="lblDescription" runat="server" Text="Description :"></asp:Label>
                        <asp:TextBox ID="txtDescription" placeholder="Description" type="text" CssClass="input" runat="server"></asp:TextBox>
                    </label> 
                    <label>
                        <asp:Label ID="lblAPrice" runat="server" Text="Price :"></asp:Label>
                        <asp:TextBox ID="txtPrice" placeholder="Price" type="text" CssClass="input" runat="server"></asp:TextBox>
                    </label> 
                    <label>
                        <asp:Label ID="lblStock" runat="server" Text="Stock :"></asp:Label>
                        <asp:TextBox ID="txtStock" placeholder="Stock" CssClass="input" runat="server"></asp:TextBox>
                    </label> 
            
                    <label>
                        <asp:Label ID="lblImage" runat="server" Text="Image :"></asp:Label> <br />
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </label>

                    <asp:Label ID="lblError" ForeColor="Red" runat="server" Text=""></asp:Label>
                    <asp:Button ID="Button1" runat="server" CssClass="submit" Text="Insert" onclick="Button1_Click" />
                </div>   


<%--            <asp:Label ID="lblName" runat="server" Text="Name :"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblDescription" runat="server" Text="Description :"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblAPrice" runat="server" Text="Price :"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblStock" runat="server" Text="Stock :"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblImage" runat="server" Text="Image :"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" />

            <br />
       
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label> <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />--%>
            <%--REFRESH DATABASE--%>         

        </div>

</asp:Content>
