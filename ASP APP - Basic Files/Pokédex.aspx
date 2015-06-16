<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pokédex.aspx.cs" Inherits="ASP_APP___Basic_Files.Pokédex" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Pokédex</h1>
        <p class="lead">Welcome to the International Pokédex for Pokémon X, Y, Omega Ruby &amp; Alpha Sapphire. This Pokédex provides an in-depth look at all 721 Pokémon in the 6th generation.</p>
    </div>
        <div class="row">
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Kanto</a>
                        <div class="btn-group">
                           <asp:dropdownlist ID="Pokémon151" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Pokémon #1-151"></asp:listitem>
                           </asp:dropdownlist>
                        </div>
                </div>
                <p></p>
            </div>
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Johto</a>
                        <div class="btn-group">
                           <asp:dropdownlist ID="Pokémon251" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Pokémon #152-251"></asp:listitem>
                           </asp:dropdownlist>
                        </div>
                </div>
                <p></p>
            </div>
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Hoenn</a>
                        <div class="btn-group">
                          <asp:dropdownlist ID="Pokémon386" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Pokémon #252-386"></asp:listitem>
                           </asp:dropdownlist>
                        </div>
                </div>
                <p></p>
            </div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Sinnoh</a>
                        <asp:dropdownlist ID="Pokémon468" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Pokémon #387-468"></asp:listitem>
                           </asp:dropdownlist>
                </div>
                <p></p>
            </div>
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Unova</a>
                        <asp:dropdownlist ID="Pokémon649" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Pokémon #469-649"></asp:listitem>
                           </asp:dropdownlist>
                </div>
                <p></p>
            </div>
            <div class="col-md-4">
                <div class="btn-group">
                    <a href="#" class="btn btn-default">Kalos</a>
                        <asp:dropdownlist ID="Pokémon720" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Pokémon #650-720"></asp:listitem>
                           </asp:dropdownlist>
                </div>
                <p></p>
            </div>
        </div>
</asp:Content>
