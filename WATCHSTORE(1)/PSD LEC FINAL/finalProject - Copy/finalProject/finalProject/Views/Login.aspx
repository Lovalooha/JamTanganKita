<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="finalProject.Views.Login1" %>
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


    <div class="form">

        <p class="title"> Login </p>

        <label>
            <asp:TextBox ID="txtEmail" placeholder="Your Email Address" CssClass="input" type ="email" runat="server"></asp:TextBox>
        </label> 
            
        <label>
            <asp:TextBox ID="txtPassword" CssClass="input" placeholder="Your Email Password" TextMode="Password" runat="server"></asp:TextBox>
        </label> 
    
        <label>
            <asp:Label ID="remember" runat="server" Text="Remember me"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" />
        </label>

        <asp:Label ID="lblError" ForeColor="Red" runat="server" Text=""></asp:Label>
        <asp:Button ID="Button1" class="submit" runat="server" Text="Sign In" OnClick="Button1_Click"/>
        <p class="signin">No account ? <a href="#">Register</a> </p>
    </div>   

</asp:Content>
