<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="finalProject.Views.Register" %>
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

        <p class="title">Register </p>
        <p class="message">Signup now and get full access to our app. </p>

        <label>
            <asp:TextBox ID="txtName" placeholder="" type="text" CssClass="input" runat="server"></asp:TextBox>
            <span>Full Name</span>
        </label> 
            
        <label>
            <asp:TextBox ID="txtEmail" placeholder="" type="email" CssClass="input" runat="server"></asp:TextBox>
            <span>Email</span>
        </label> 
    
        <label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </label>
    
        <label>
            <asp:TextBox ID="txtAddress" placeholder="" type="text" CssClass="input" runat="server"></asp:TextBox>
            <span>Address</span>
        </label>
    

        <label>
            <asp:TextBox ID="txtPass" placeholder="" CssClass="input" runat="server" TextMode="Password"></asp:TextBox>
            <span>Password</span>
        </label>

        <asp:Label ID="lblError" runat="server" ForeColor="Red" Text=""></asp:Label>
        <asp:Button ID="Button1" class="submit" runat="server" Text="Submit" onclick="Button1_Click"/>
        <p class="signin">Already have an acount ? <a href="#">Login</a> </p>

    </div>
             

</asp:Content>
