<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GestionnaireLivraison_LOG210.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblCourriel" runat="server" Text="Courriel : "></asp:Label>
    <asp:TextBox ID="txtCourriel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="txtMotDePasse" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" />
    <asp:Button ID="btnCreerCompte" runat="server" Text="Créer nouveau compte" />
</asp:Content>
