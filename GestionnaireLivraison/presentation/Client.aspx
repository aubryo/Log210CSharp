<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="GestionnaireLivraison.presentation.CreationCompte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Créer un compte"></asp:Label>
    <br />
    <asp:Label ID="lblNom" runat="server" Text="Nom : "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNom" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblPrenom" runat="server" Text="Prénom : "></asp:Label>
    <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfPrenom" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblNumeroRue" runat="server" Text="Numéro de rue : "></asp:Label>
    <asp:TextBox ID="txtNumeroRue" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNumeroRue" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblNomRue" runat="server" Text="Rue : "></asp:Label>
    <asp:TextBox ID="txtNomRue" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNomRue" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblCodePostal" runat="server" Text="Code postal : "></asp:Label>
    <asp:TextBox ID="txtCodePostal" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfCodePostal" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblDDN" runat="server" Text="Date de naissance : "></asp:Label>
    <asp:TextBox ID="txtDDN" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfDDN" runat="server" Text=""></asp:Label> &nbsp;YYYY-MM-DD
    <br />
    <asp:Label ID="lblNumeroTel" runat="server" Text="Numéro de téléphone : "></asp:Label>
    <asp:TextBox ID="txtNumeroTel" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNumeroTel" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblCourriel" runat="server" Text="Courriel : "></asp:Label>
    <asp:TextBox ID="txtCourriel" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfCourriel" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="txtMotDePasse" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfMotDePasse" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnCreerCompte" runat="server" Text="Créer compte" OnClick="btnCreerCompte_Click" />
</asp:Content>
