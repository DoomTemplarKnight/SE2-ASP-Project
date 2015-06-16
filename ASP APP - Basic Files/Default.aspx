<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_APP___Basic_Files._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Pokémon</h1>
        <p class="lead">This site documents almost everything from the GBA,DS &amp; 3DS Pokémon games.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Pokéarth</h2>
            <p>
                For an overview of the Pokémon world please click the link below.
            </p>
            <p>
                <a class="btn btn-default" href="~/Pokédex">Pokéarth &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Pokédex</h2>
            <p>
                For an detailed overview of the pokémon in the pokédex, click the button below.
            </p>
            <p>
                <a class="btn btn-default" href="Pokédex.aspx">Pokédex &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Attackdex</h2>
            <p>
                Want to know everything about your favourite move, or do you want to know when a pokémon learns a certain move? The attackdex is your place to be.</p>
            <p>
                <a class="btn btn-default" href="#">Attackdex »</a>
            </p>
        </div>
    </div>

</asp:Content>
