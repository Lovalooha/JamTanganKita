<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateWatchDetail.aspx.cs" Inherits="finalProject.Views.UpdateWatchDetail" %>
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
        <div class="form">

            <p class="title"> Update Watch Detail </p>
                <<asp:Image ID="Image1" runat="server" style="width: 16rem; height: 18rem; object-fit: cover;" /> <br />

                <asp:Label ID="LabelName" runat="server" Text=""></asp:Label> <br /> <br />
                <asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label> <br /> <br />
                <asp:Label ID="LabelPrice" runat="server" Text=""></asp:Label> <br /> <br />
                <asp:Label ID="LabelStock" runat="server" Text=""></asp:Label> <br /> <br />
            <label>
            <asp:Label ID="lblName" runat="server" Text="Watch Name :"></asp:Label>
            <asp:TextBox ID="txtName" placeholder="Watch Name" type="text" CssClass="input" runat="server"></asp:TextBox>
            </label> 
            <label>
                <asp:Label ID="lblDescription" runat="server" Text=" Watch Description :"></asp:Label>
                <asp:TextBox ID="txtDescription" placeholder="Description" type="text" CssClass="input" runat="server"></asp:TextBox>
            </label> 
            <label>
                <asp:Label ID="lblAPrice" runat="server" Text="Watch Price :"></asp:Label>
                <asp:TextBox ID="txtPrice" placeholder="Price" type="text" CssClass="input" runat="server"></asp:TextBox>
            </label> 
            <label>
                <asp:Label ID="lblStock" runat="server" Text="Watch Stock :"></asp:Label>
                <asp:TextBox ID="txtStock" placeholder="Stock" CssClass="input" runat="server"></asp:TextBox>
            </label> 
            
            <label>
                <asp:Label ID="lblImage" runat="server" Text="Watch Image :"></asp:Label> <br />
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </label>

            <asp:Label ID="lblError" ForeColor="Red" runat="server" Text=""></asp:Label>
            <asp:Button ID="Button1" runat="server" CssClass="submit" Text="Insert" onclick="Button1_Click" />
        </div>   


            <%--<h1> UPDATE WATCH DETAIL </h1>
             
            <asp:Image ID="Image1" runat="server" style="width: 16rem; height: 18rem; object-fit: cover;" /> <br />

            <asp:Label ID="LabelName" runat="server" Text=""></asp:Label> <br /> <br />
            <asp:Label ID="LabelDescription" runat="server" Text=""></asp:Label> <br /> <br />
            <asp:Label ID="LabelPrice" runat="server" Text=""></asp:Label> <br /> <br />
            <asp:Label ID="LabelStock" runat="server" Text=""></asp:Label> <br /> <br />


            <asp:Label ID="lblName" runat="server" Text="Watch Name :"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblDescription" runat="server" Text="Watch Description :"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblPrice" runat="server" Text="Watch Price :"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblStock" runat="server" Text="Watch Stock :"></asp:Label>
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblImage" runat="server" Text="Watch Image :"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" /> <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" onclick="Button1_Click"/>--%>
        </div>

</asp:Content>
