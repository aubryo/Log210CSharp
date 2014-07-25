﻿<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GestionnaireLivraison.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
<div class="container-fluid">
    <div class="row">
        <div class="col-xs-12 col-md-4 col-md-offset-4">
        <asp:Label ID="lblCourriel" runat="server" Text="Courriel : "></asp:Label>
        <asp:TextBox ID="txtCourriel" CssClass="form-control" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
        <asp:TextBox ID="txtMotDePasse" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" CssClass="btn btn-primary" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <asp:HyperLink ID="hlCreerCompte" runat="server" Text="Créer nouveau compte" NavigateUrl="~/presentation/Client.aspx"></asp:HyperLink>
        </div>
    </div>
</div>
</asp:Content>
