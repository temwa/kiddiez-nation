<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Nation1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner">
            <div class="item active">
                <img src="Images/carousel/1.jpg" alt="Slide 1">
            </div>

            <div class="item">
                <img src="Images/carousel/2.jpg" alt="Slide 2">
            </div>

            <div class="item">
                <img src="Images/carousel/3.jpg" alt="Slide 3">
            </div>

            <div class="item">
                <img src="Images/carousel/4.jpg" alt="Slide 4">
            </div>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <br />
    <h2>KiddiezNation is all about caring for toddlers. We sell baby products for mothers, that will ensure that your toddler is healthy and happy  </h2>
    <p class="lead">Baby products can be found on our online store and everything you need to know about caring for your kids. Toys, Bottles, Formula, Rental Books, Baby Books, Nappies and more! </p>
    <div id="learn-more">

        <a href="/About" class="btn btn-primary learn-more-btn">
            <p><b>Learn More About Kiddies Nation</b> </p>
        </a>
    </div>


</asp:Content>
