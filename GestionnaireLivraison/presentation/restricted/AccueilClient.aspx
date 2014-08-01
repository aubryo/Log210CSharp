<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilClient.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
<div class="container-fluid">
<div class="row">
    <div class="col-xs-12 col-md-6 col-md-offset-3">
        <asp:label id="lblBonjour" runat="server" text="Bonjour "></asp:label>
        <asp:label id="lblBonjourPrenom" runat="server" text=""></asp:label>
        <asp:label id="lblBonjourNom" runat="server" text=""></asp:label>
        <br />
        <br />
        <strong><asp:label id="lblFaire" runat="server" text="Que voulez-vous faire?"></asp:label></strong>
        <br />
        <asp:LinkButton ID="lnkCommander" CssClass="btn btn-success" runat="server" OnClick="lnkCommander_Click"><span class="glyphicon glyphicon-arrow-right"></span>&nbsp;Passer une commande</asp:LinkButton>
        <asp:LinkButton ID="lnkModifier" CssClass="btn btn-primary" runat="server" OnClick="lnkModifier_Click"><span class="glyphicon glyphicon-pencil"></span>&nbsp;Modifier mon profil</asp:LinkButton>
        <br />
        <div id="ClientInfo">
            <h4>Vos informations</h4>
            <hr />
        <asp:label id="lblNom" runat="server" text="Nom : "></asp:label>
        <asp:label id="lblClientNom" runat="server"></asp:label>
        <br />
        <asp:label id="lblPrenom" runat="server" text="Prénom : "></asp:label>
        <asp:label id="lblClientPrenom" runat="server"></asp:label>
        <br />
        <asp:label id="lblNumeroRue" runat="server" text="Numéro de rue : "></asp:label>
        <asp:label id="lblClientNumeroRue" runat="server"></asp:label>
        <br />
        <asp:label id="lblNomRue" runat="server" text="Rue : "></asp:label>
        <asp:label id="lblClientNomRue" runat="server"></asp:label>
        <br />
        <asp:label id="lblCodePostal" runat="server" text="Code postal : "></asp:label>
        <asp:label id="lblClientCodePostal" runat="server"></asp:label>
        <br />
        <asp:label id="lblDDN" runat="server" text="Date de naissance : "></asp:label>
        <asp:label id="lblClientDDN" runat="server"></asp:label>
        <br />
        <asp:label id="lblNumeroTel" runat="server" text="Numéro de téléphone : "></asp:label>
        <asp:label id="lblClientNumeroTel" runat="server"></asp:label>
        <br />
        <asp:label id="lblCourriel" runat="server" text="Courriel : "></asp:label>
        <asp:label id="lblClientCourriel" runat="server"></asp:label>
    </div>
</div>
</div>
</div>
</asp:Content>
