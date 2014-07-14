<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Commande.aspx.cs" Inherits="GestionnaireLivraison.presentation.Commande" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Passer une commande"></asp:Label>
    <br />
    <asp:Label ID="lblListRestaurants" runat="server" Text="List des restaurants"></asp:Label><br />
    <asp:ListView ID="lvRestaurant" runat="server">
    </asp:ListView>
    <br />
    <asp:Button ID="btnPoursuivre" runat="server" Text="Poursuivre" />
</asp:Content>
