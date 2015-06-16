<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminPriviliges.aspx.cs" Inherits="ASP_APP___Basic_Files.AdminPriviliges" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Succesfully logged&nbsp; <asp:Label ID="UserNameLabel" runat="server" Text=""></asp:Label>In!</h1>
        <p class="lead">On this page users can insert, update or delete database records:</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Insert</h2>
            <p>
                Here you can insert new record into the database. 
                </p>
            <p>
                Please Select an enitity from the menu.</p>
            <p>
                Entity
                <asp:dropdownlist ID="Dropdownlist3" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Entity Name"></asp:listitem>
                </asp:dropdownlist>
            </p>
            <p>
                Items:
                <asp:dropdownlist ID="Dropdownlist4" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Item Name"></asp:listitem>
                </asp:dropdownlist>
            </p>
            <p>
                <a class="btn btn-default" ID="InsertButton">Insert &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Update</h2>
                <div class="col-md-3">
                    For an detailed overview of the pokémon in the pokédex, click the button below.
                    <br />
                    Enity:
                    <asp:dropdownlist ID="Dropdownlist1" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                                   <asp:listitem TEXT="Entity Name"></asp:listitem>
                    </asp:dropdownlist>
                    <br />
                    Items: <asp:dropdownlist ID="Dropdownlist2" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                                   <asp:listitem TEXT="Item Name"></asp:listitem>
                    </asp:dropdownlist>
                </div>
            <p>
                <a class="btn btn-default" ID="UpdateButton">Update &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Delete</h2>
            <p>
                Below you can Delete Below you can Delete the selected records from the Database</p>
            <p>
                Enitity:
                <asp:dropdownlist ID="DeleteDropDownEntity" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Entity Name"></asp:listitem>
                </asp:dropdownlist>
            </p>
            <p>
                Items:
                <asp:dropdownlist ID="DeleteDropDownItem" runat="server" AppendDataBoundItems="true" class="btn btn-default dropdown-toggle" aria-expanded="false">
                               <asp:listitem TEXT="Item Name"></asp:listitem>
                </asp:dropdownlist>
            </p>
            <p>
                <a class="btn btn-default" ID="DeleButton">Delete &raquo;</a>
        </div>
    </div>

</asp:Content>
