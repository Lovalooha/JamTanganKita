<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="finalProject.Views.Home.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>

    .special-box {
      display: flex;
      flex-wrap: wrap;
      gap: 2rem;
      text-align: center;
      flex-basis: 31%;
      transition: all 0.3s ease;
    }

    .special-box img {
      border-radius: 1rem;
    }

    .special-box:hover {
      transform: translateY(-10px);
    }

    .special-box:hover img {
      box-shadow: 0px 5px 10px rgba(0, 0, 0, 0.2);
    }

    .special-box h5 {
      margin-top: 2rem;
    }

    .card-border{
        transition: all 0.3s ease;
    }

    .card-border :hover{
        transform: translateY(-10px);
    }
    </style>


    <div>
    <asp:Button ID="insertBtn" runat="server" onclick="insertBtn_Click" Text="Insert Watches" Visible ="false"/>
    </div>
        <div>

            <section class="container py-5">
                <div class="row text-center pt-3">
                    <div class="col-lg-6 m-auto">
                        <h1 class="h1">Produk Kita</h1>
                        <p>
                            Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia
                            deserunt mollit anim id est laborum.
                        </p>
                    </div>
                </div>

                 <div class="row">
                    <asp:Repeater ID="CardRepeater" runat="server" onitemdatabound="CardRepeater_ItemDataBound">
                        <ItemTemplate>  
                                <div class=" special-box">
                                    <div>
                                        <asp:Button ID="updateBtn" runat="server" Text="Update" onclick="updateBtn_Click" CommandArgument='<%#Eval("WatchID") %>' />
                                        <asp:Button ID="deleteBtn" runat="server" Text="Delete" onclick="deleteBtn_Click" CommandArgument='<%#Eval("WatchID") %>' />
                                    </div>
                                    <asp:LinkButton ID="watchCard" runat="server" CommandArgument='<%#Eval("WatchID") %>' OnClick="watchCard_Click" style="text-decoration: none">   
                                        <img src="../../Assets/Watches/<%# Eval("WatchImage") %>" alt="..." class="rounded-circle img-fluid border"/>
                                        <div>
                                            <h5 class="text-center mt-2 mb-2"><%# Eval("WatchName") %></h5>
                                        </div>
                                    </asp:LinkButton>
                                </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </section>
            <!-- End Categories of The Month -->
            <!-- Start Featured Product -->
            <section class="bg-light">
                <div class="container py-5">
                    <div class="row text-center py-3">
                        <div class="col-lg-6 m-auto">
                            <h1 class="h1">Featured Product</h1>
                            <p>
                                Reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
                                Excepteur sint occaecat cupidatat non proident.
                            </p>
                        </div>
                    </div>

                  <%--   <div class="row">
                    <asp:Repeater ID="CardRepeater1" runat="server" onitemdatabound="CardRepeater1_ItemDataBound">
                        <ItemTemplate>
                            <div class="col-12 col-md-4">
                                    <div>
                                        <asp:Button ID="updateBtn" runat="server" Text="Update" onclick="updateBtn_Click" CommandArgument='<%#Eval("WatchID") %>' />
                                        <asp:Button ID="deleteBtn" runat="server" Text="Delete" onclick="deleteBtn_Click" CommandArgument='<%#Eval("WatchID") %>' />
                                    </div>
                                    <asp:LinkButton ID="watchCard" runat="server" CommandArgument='<%#Eval("WatchID") %>' OnClick="watchCard_Click" style="text-decoration: none">
                                        <img src="../../Assets/Watches/<%# Eval("WatchImage") %>" alt="..." class="rounded-circle img-fluid border" style="width: 16rem; height: 18rem; object-fit: cover;">
                                        <div>
                                            <h5 class="text-center mt-2 mb-2"><%# Eval("WatchName") %></h5>
                                        </div>
                                    </asp:LinkButton>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>--%>

                   <div class="row">
                        <asp:Repeater ID="CardRepeater1" runat="server" onitemdatabound="CardRepeater1_ItemDataBound">
                            <ItemTemplate>
                                <div class="col-12 col-md-4 card-border">
                                    <div class="card">
                                        <div class="card-body">
                                            <div>
                                                <asp:Button ID="updateBtn1" runat="server" Text="Update" onclick="updateBtn_Click" CommandArgument='<%#Eval("WatchID") %>' />
                                                <asp:Button ID="deleteBtn1" runat="server" Text="Delete" onclick="deleteBtn_Click" CommandArgument='<%#Eval("WatchID") %>' />
                                            </div>
                                                <asp:LinkButton ID="watchCard" runat="server" CommandArgument='<%#Eval("WatchID") %>' OnClick="watchCard_Click" style="text-decoration: none">
                                               <img src="../../Assets/Watches/<%# Eval("WatchImage") %>" alt="..." class="img-fluid border" style="width: 16rem; height: 18rem; object-fit: cover;">
                                                <div>
                                                    <h5 class="card-title"><%# Eval("WatchName") %></h5>

                                                    <%--<h6 class="card-subtitle mb-2 text-muted">Rating: <%# Eval("Rating") %></h6>
                                                    <p class="card-text">Harga: <%# Eval("Harga") %></p>
                                                    <p class="card-text">Deskripsi: <%# Eval("Deskripsi") %></p>--%>

                                                </div>
                                            </asp:LinkButton>

                                                        <ul class="list-unstyled d-flex justify-content-between">
                                                    <li>
                                                        <i class="text-warning fa fa-star"></i>
                                                        <i class="text-warning fa fa-star"></i>
                                                        <i class="text-warning fa fa-star"></i>
                                                        <i class="text-muted fa fa-star"></i>
                                                        <i class="text-muted fa fa-star"></i>
                                                    </li>
                                                    <li class="text-muted text-right">Rp 2.500.000</li>
                                                </ul>
                                                <a href="shop-single.html" class="h2 text-decoration-none text-dark">Siuuuut</a>
                                                <p class="card-text">
                                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit. Sunt in culpa qui officia deserunt.
                                                </p>
                                                <p class="text-muted">Reviews (24)</p>

                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>


                </div>
            </section>

        </div>

</asp:Content>