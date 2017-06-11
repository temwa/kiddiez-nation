<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WishlistCart.aspx.cs" Inherits="Nation1.WishlistCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="WishlistCartTitle" runat="server" class="ContentHead">
        <h1>WishList</h1>
    </div>
    <asp:GridView ID="WishList" runat="server" AutoGenerateColumns="False"
        ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="Nation1.Models.WishItem"
        SelectMethod="GetWishlistItems"
        CssClass="table table-striped table-bordered">
        <Columns>
            <asp:BoundField DataField="ProductID" HeaderText="ID"
                SortExpression="ProductID" />
            <asp:BoundField DataField="Product.ProductName" HeaderText="Name" />
            <asp:BoundField DataField="Product.UnitPrice" HeaderText="Price (each)"
                DataFormatString="{0:c}" />
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="PurchaseQuantity" Width="40"
                        runat="server" Text="<%#: Item.Quantity %>"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Item Total">
                <ItemTemplate>
                    <%#: String.Format("{0:c}", 
((Convert.ToDouble(Item.Quantity)) * 
Convert.ToDouble(Item.Product.UnitPrice)))%>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Remove Item">
                <ItemTemplate>
                    <asp:CheckBox ID="Remove" runat="server"></asp:CheckBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cart">
                <ItemTemplate>
                    <a href="/AddToCart.aspx?productID=<%#:Item.ProductId %>">
                        <span class="product-list-item"><b>Add To Cart</b></span>
                    </a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
        <p></p>
        <strong>
            <asp:Label ID="LabelTotalText" runat="server" Text="Order Total: 
"></asp:Label>
            <asp:Label ID="lblTotal" runat="server"
                EnableViewState="false"></asp:Label>
        </strong>
    </div>
    <br />
    <table style="width: 300px;">
        <tr>
            <td>
                <asp:Button ID="UpdateBtn" runat="server" CssClass="btn btn-primary update-btn" Text="Update"
                    OnClick="UpdateBtn_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
