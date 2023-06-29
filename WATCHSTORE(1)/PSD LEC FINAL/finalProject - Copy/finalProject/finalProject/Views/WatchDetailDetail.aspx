<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Navbar.Master" AutoEventWireup="true" CodeBehind="WatchDetailDetail.aspx.cs" Inherits="finalProject.Views.WatchDetailDetail1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <style>
    .containerWatchDetail {
        margin-top: 150px;
        margin-bottom: 250px;
        display: flex;
        justify-content: center;
        align-items: center;
        height: 100vh;
    }
    </style>


    <div>
            <%--ALL USER--%>
            <%--VALIDATE  CUMA CUSTOME YG BS ADD TO CART--%> 

            <h1> WATCH DETAIL </h1>

            
            
            <%--Validate the button to only appear if the user’s login as Customer.--%>
               <%--FOR CUSTOMER--%>
           <%--    <asp:Label ID="lblQuantity" runat="server" Text="Quantity :"></asp:Label>--%>


            <div class="containerWatchDetail">
                <div class="col-lg-7 mt-5">
                    <div class="card">
                         <div class="card-body "> <%--d-flex flex-column align-items-center--%>
                             <div class="text-center">
                                <asp:Image ID="Image1" runat="server" style="width: 16rem; height: 18rem; object-fit: cover;" />
                            </div>
                            
            
                            <div class="text-center">
                                <asp:Label ID="lblName" CssClass="h2" runat="server" Text=""></asp:Label>
                            </div>

                        <%--<div class="card-body">
                            <asp:Image ID="Image1" runat="server" style="width: 16rem; height: 18rem; object-fit: cover;" />

                            <asp:Label ID="lblName" CssClass=" h2" runat="server" Text=""></asp:Label> --%>
                            
                            
                            <p class="py-2">
                                <asp:Label ID="lblPrice" CssClass="list-inline-item text-dark" runat="server" Text=""></asp:Label>
                                 
                                <i class="fa fa-star text-warning"></i>
                                <i class="fa fa-star text-warning"></i>
                                <i class="fa fa-star text-warning"></i>
                                <i class="fa fa-star text-warning"></i>
                                <i class="fa fa-star text-secondary"></i>
                                <span class="list-inline-item text-dark">Rating 4.8 | 36 Comments</span>
                            </p>
                            <ul class="list-inline">
                                <li class="list-inline-item">
                                    <h6>Brand:</h6>
                                </li>
                                <li class="list-inline-item">
                                    <p class="text-muted"><strong>Easy Wear</strong></p>
                                </li>
                            </ul>
                                    

                            <h6>Description:</h6>
                            <asp:Label ID="lblDescription" runat="server" Text=""></asp:Label> 
                            <ul class="list-inline">
                                <li class="list-inline-item">
                                    <h6>Avaliable Color :</h6>
                                </li>
                                <li class="list-inline-item">
                                    <p class="text-muted"><strong>White / Black</strong></p>
                                </li>
                            </ul>

                            <h6>Specification:</h6>
                            <ul class="list-unstyled pb-3">
                                <li>Lorem ipsum dolor sit</li>
                                <li>Amet, consectetur</li>
                                <li>Adipiscing elit,set</li>
                                <li>Duis aute irure</li>
                                <li>Ut enim ad minim</li>
                                <li>Dolore magna aliqua</li>
                                <li>Excepteur sint</li>
                            </ul>

                            <ul class="list-inline">
                                <li class="list-inline-item">
                                    <h6>Stock :</h6>
                                </li>
                                <li class="list-inline-item">
                                    <asp:Label ID="lblStock" runat="server" Text=""></asp:Label> 
                                </li>
                            </ul>

                                <input type="hidden" name="product-title" value="Activewear">
                                <div class="row">
                                    <div class="col-auto">
                                        <ul class="list-inline pb-3">
                                            <li class="list-inline-item">Size :
                                                <input type="hidden" name="product-size" id="product-size" value="S">
                                            </li>
                                            <li class="list-inline-item"><span class="btn btn-success btn-size">S</span></li>
                                            <li class="list-inline-item"><span class="btn btn-success btn-size">M</span></li>
                                            <li class="list-inline-item"><span class="btn btn-success btn-size">L</span></li>
                                            <li class="list-inline-item"><span class="btn btn-success btn-size">XL</span></li>
                                        </ul>
                                    </div>
                                    <div class="col-auto">
                                        <ul class="list-inline pb-3">
                                            <li class="list-inline-item text-right">
                                                Quantity
                                                <asp:TextBox ID="txtQuantity" value="1" runat="server"></asp:TextBox> <br />
                                            </li>
                                            <li class="list-inline-item">
                                                <button type="button" class="btn btn-success" onclick="decreaseQuantity()">-</button>
                                            </li>
                                            <li class="list-inline-item">
                                                <span class="badge bg-secondary" id="varValue" runat="server">1</span>
                                            </li>
                                            <li class="list-inline-item">
                                                <button type="button" class="btn btn-success" onclick="increaseQuantity()">+</button>
                                            </li>
                                        </ul>
                                    </div>
                                </div>

                                <asp:Label ID="lblError" runat="server" Text=""></asp:Label> <br />

                                <div class="row pb-3">
                                    <div class="col d-grid">
                                        <button type="submit" class="btn btn-success btn-lg" name="submit" value="buy">Buy</button>
                                    </div>
                                    <div class="col d-grid">
                                        <asp:Button ID="btnCart"  class="btn btn-success btn-lg" runat="server" onclick="btnCart_Click" Text="Add to Cart" />
                                        <%--<button type="submit" class="btn btn-success btn-lg" name="submit" value="addtocard">Add To Cart</button>--%>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
                
    <script>
        function decreaseQuantity() {
            let quantity = parseInt(document.getElementById('<%= txtQuantity.ClientID %>').value);
        if (quantity > 1) {
            quantity--;
            document.getElementById('<%= txtQuantity.ClientID %>').value = quantity;
            document.getElementById('varValue').innerText = quantity;
        }
    }

    function increaseQuantity() {
        let quantity = parseInt(document.getElementById('<%= txtQuantity.ClientID %>').value);
        quantity++;
        document.getElementById('<%= txtQuantity.ClientID %>').value = quantity;
            document.getElementById('varValue').innerText = quantity;
        }
    </script>
</asp:Content>
