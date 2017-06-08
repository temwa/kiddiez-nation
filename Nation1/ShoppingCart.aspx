<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs"
    Inherits="Nation1.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="ShoppingCartTitle" runat="server" class="ContentHead">
        <h1>Shopping 
Cart</h1>
    </div>
    <asp:GridView ID="CartList" runat="server" AutoGenerateColumns="False"
        ShowFooter="True" GridLines="Vertical" CellPadding="4"
        ItemType="Nation1.Models.CartItem"
        SelectMethod="GetShoppingCartItems"
        CssClass="table table-striped table-bordered" OnSelectedIndexChanged="CartList_SelectedIndexChanged">
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
            <asp:TemplateField HeaderText="Repeat Order">
                <ItemTemplate>
                    <asp:DropDownList ID="RepeatOrder" runat="server" AutoPostBack="True" EnableViewState="true">
                        <asp:ListItem Value="0" Text="No Repeat" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="1" Text="Weekly"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Bi-Weekly"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Monthly"></asp:ListItem>
                    </asp:DropDownList>
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
            <td>
                <asp:ImageButton ID="CheckoutImageBtn" runat="server"
                    ImageUrl="https://www.paypal.com/en_US/i/btn/btn_xpressCheckout.gif"
                    Width="145" AlternateText="Check out with PayPal"
                    OnClick="CheckoutBtn_Click"
                    BackColor="Transparent" BorderWidth="0" />
            </td>
        </tr>
    </table>
</asp:Content>
