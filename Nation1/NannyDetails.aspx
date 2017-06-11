<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NannyDetails.aspx.cs" Inherits="Nation1.NannyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="nannyDetail" runat="server" ItemType="Nation1.Models.Nanny" SelectMethod="GetNanny" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.NannyName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td style="vertical-align: top; text-align:left;">
                        <span><b>Age:</b>&nbsp;<%#:Item.Age %></span>
                        <br />
                        <span><b>Years of Experience:</b>&nbsp;<%#:Item.ExperienceYears %></span>
                        <br />
                        <span><b>Part or Full Time:</b><br /><%#:Item.PartorFull %></span>
                        <br />
                        <span><b>Areas:</b><br /><%#:Item.Areas %></span>
                        <br />
                        <span><b>Contact Number:</b><br /><%#:Item.Phone %></span>
                        <br />
                        <span><b>Email:</b><br /><%#:Item.Email %></span>
                        <br />
                        <span><b>Extra Info:</b><br /><%#:Item.Extra %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
