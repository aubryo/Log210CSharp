<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Restaurateur.aspx.cs" Inherits="GestionnaireLivraison_LOG210.presentation.Restaurateur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Créer un compte restaurateur"></asp:Label>
    <br />
    <asp:Label ID="lblNom" runat="server" Text="Nom : "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblPrenom" runat="server" Text="Prénom : "></asp:Label>
    <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNumeroRue" runat="server" Text="Numéro de rue : "></asp:Label>
    <asp:TextBox ID="txtNumeroRue" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNomRue" runat="server" Text="Rue : "></asp:Label>
    <asp:TextBox ID="txtNomRue" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCodePostal" runat="server" Text="Code postal : "></asp:Label>
    <asp:TextBox ID="txtCodePostal" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDDN" runat="server" Text="Date de naissance : "></asp:Label>
    <asp:TextBox ID="txtDDN" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNumeroTel" runat="server" Text="Numéro de téléphone : "></asp:Label>
    <asp:TextBox ID="txtNumeroTel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCourriel" runat="server" Text="Courriel : "></asp:Label>
    <asp:TextBox ID="txtCourriel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="txtMotDePasse" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblRestaurants" runat="server" Text="Restaurant(s) : "></asp:Label>
    <asp:CheckBoxList ID="cblRestaurants" runat="server"></asp:CheckBoxList>
    <br />
    <asp:Button ID="btnCreerCompte" runat="server" Text="Créer compte" OnClick="btnCreerCompte_Click" />
</asp:Content>
