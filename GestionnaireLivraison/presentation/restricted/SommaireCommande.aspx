<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="SommaireCommande.aspx.cs" Inherits="GestionnaireLivraison.presentation.restricted.SommaireCommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Votre numero de commande est : "></asp:Label><asp:Label ID="lblNoCommande" runat="server" Text=""></asp:Label>
    <br />
    <asp:LinkButton ID="hlRetourAccueil" runat="server" Text="Retour a l'accueil " OnClick="hlRetourAccueil_Click"></asp:LinkButton>
</asp:Content>
