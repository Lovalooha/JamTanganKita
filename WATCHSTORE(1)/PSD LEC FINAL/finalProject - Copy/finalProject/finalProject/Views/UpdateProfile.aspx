<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="finalProject.Views.UpdateProfile1" %>
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

        <p class="title"> Update Profile </p>

        <label>
            <asp:Label ID="lblName" runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="txtName" CssClass="input" placeholder="Your Full Name" type="text" runat="server" Text=""></asp:TextBox>
        </label> 
            
        <label>
            <asp:Label ID="lblEmail" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="txtEmail" CssClass="input" placeholder="Your Email Address" type="email" runat="server" Text=""></asp:TextBox>
        </label> 

        <label>
            <asp:Label ID="lblGender" runat="server" Text="Gender :"></asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Value="Male">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </label>
        
        <label>
            <asp:Label ID="lblAddress" runat="server" Text="Address :"></asp:Label>
            <asp:TextBox ID="txtAddress" CssClass="input" PlaceHolder="Your Address" type="text" runat="server" Text=""></asp:TextBox> 
        </label> 
    
        <label>
            <asp:Label ID="lblPassword" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="txtPass" CssClass="input" PlaceHolder="Your Email Password" runat="server" TextMode="Password"></asp:TextBox>
        </label>

        <asp:Label ID="lblError" ForeColor="Red" runat="server" Text=""></asp:Label>
        <asp:Button ID="Button1" class="submit" runat="server" Text="Update" onclick ="Button1_Click"/>
        

    </div>  

</asp:Content>
