<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbilityDex.aspx.cs" Inherits="ASP_APP___Basic_Files.AbilityDex" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>AbilityDex</h1>
        <p class="lead">Welcome to the International Ability for Pokémon X, Y, Omega Ruby &amp; Alpha Sapphire. This AbilityDex provides an in-depth look at all PokémonAbilities up till the 6th generation.</p>
    </div>
        <div class="row">
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Kanto</a>
                        <div class="btn-group">
                           <asp:dropdownlist ID="AbilityAL" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Abilities A-L"></asp:listitem>
                           </asp:dropdownlist>
                        </div>
                </div>
                <p></p>
            </div>
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Johto</a>
                        <div class="btn-group">
                           <asp:dropdownlist ID="AbilityMZ" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Abilities M-Z"></asp:listitem>
                           </asp:dropdownlist>
                        </div>
                </div>
                <p></p>
            </div>
        </div>
</asp:Content>
