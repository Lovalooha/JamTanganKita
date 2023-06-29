<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateWatch.aspx.cs" Inherits="finalProject.Views.UpdateWatch1" %>
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
        

        <div class="form">

                    <p class="title"> Update Watch </p>
                       <asp:Image ID="Image1" runat="server" style="width: 16rem; height: 18rem; object-fit: cover;" /> <br />
                       <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    <label>
                        <asp:Label ID="lblName" runat="server" Text="Watch Name :"></asp:Label>
                        <asp:TextBox ID="txtName" placeholder="Watch Name" type="text" CssClass="input" runat="server"></asp:TextBox>
                    </label> 
            
                    <label>
                        <asp:Label ID="lblImage" runat="server" Text="Watch Image :"></asp:Label>
                        <asp:FileUpload ID="FileUpload1" runat="server" /> 
                    </label>

                    <asp:Label ID="lblError" ForeColor="Red" runat="server" Text=""></asp:Label>
                    <asp:Button ID="Button1" runat="server" CssClass="submit" Text="Insert" onclick="Button1_Click" />
                </div>   


<%--            <asp:Image ID="Image1" runat="server" style="width: 16rem; height: 18rem; object-fit: cover;" /> <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label> <br /> <br />
            <asp:Label ID="lblName" runat="server" Text="Watch Name :"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox> <br />

            <asp:Label ID="lblImage" runat="server" Text="Watch Image :"></asp:Label>
            <asp:FileUpload ID="FileUpload1" runat="server" /> <br />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click"/> --%>       
        </div>

</asp:Content>
