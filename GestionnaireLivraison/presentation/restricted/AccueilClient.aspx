<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilClient.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div>
        <asp:label id="lblBonjour" runat="server" text="Bonjour "></asp:label>
        <asp:label id="lblBonjourPrenom" runat="server" text="empty"></asp:label>
        &nbsp;<asp:label id="lblBonjourNom" runat="server" text="empty"></asp:label>
        <br />
        <asp:label id="lblFaire" runat="server" text="Que voulez-vous faire?"></asp:label>
        <br />
        <asp:button id="btnCommander" runat="server" text="Passer une commande" OnClick="btnCommander_Click" />
        <asp:button id="btnModifier" runat="server" text="Modifier mon profil" OnClick="btnModifier_Click" />

        <div id="ClientInfo">
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
</asp:Content>
