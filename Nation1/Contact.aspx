<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Nation1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %> Us</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <div class="form-horizontal">
        <h3>Contact Form</h3>
        <hr />

        <div class="container">
            <div class="col-md-8">
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="FirstName" CssClass="col-md-2 control-label">First Name</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="FirstName" CssClass="form-control" TextMode="SingleLine" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstName"
                            CssClass="text-danger" ErrorMessage="The First Name field is required." />
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="LastName" CssClass="col-md-2 control-label">Last Name</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="LastName" CssClass="form-control" TextMode="SingleLine" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="LastName"
                            CssClass="text-danger" ErrorMessage="The Last Name field is required." />
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                            CssClass="text-danger" ErrorMessage="The Email field is required." />
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ContactNumber" CssClass="col-md-2 control-label">Contact Number</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="ContactNumber" CssClass="form-control" TextMode="SingleLine" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="ContactNumber"
                            CssClass="text-danger" ErrorMessage="The Contact Number field is required." />
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Message" CssClass="col-md-2 control-label">Message/Enquiry</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Message" TextMode="MultiLine" Columns="40" Rows="15" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Message"
                            CssClass="text-danger" ErrorMessage="Please tpye a message or enquiry." />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Button runat="server" OnClick="CreateUser_Click" Text="Submit" CssClass="btn btn-default" />
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <address>
                    <strong>KiddiezNation</>(Pty)Ltd</strong><br />
                    Shop 34<br />
                    Long Street<br />
                    Cape Town, 7707<br />
                    South Africa<br />
                    Contact Number:
                    <a href="callto:+27780917232">+ 27-78-091-7232</a>

                </address>
                <address>
                    <strong>Information:</strong>   <a href="mailto:info@KiddiezNation.co.za">info@KiddiezNation.co.za</a><br />
                    <strong>Queries:</strong> <a href="mailto:secretary@KiddiezNation.co.za">secretary@KiddiezNation.co.za</a>
                </address>
            </div>

        </div>
    </div>
</asp:Content>
