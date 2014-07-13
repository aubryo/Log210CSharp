<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="CompleterCommande.aspx.cs" Inherits="GestionnaireLivraison_LOG210.presentation.CompleterCommande" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Passer une commande"></asp:Label>
    <br />
    <asp:Label ID="lblSommaire" runat="server" Text="Sommaire"></asp:Label><br />
    <asp:GridView ID="gvLigneCommande" runat="server">
    </asp:GridView>
    <br />
    <asp:CheckBox ID="cbAdresseDefaut" runat="server" text="Adresse par défaut" checked="true"/>
    <div id="adresseDefaut">
    <asp:Label ID="lblNumeroRue" runat="server" Text="Numéro de rue : "></asp:Label>
    <asp:Label ID="lblLivraisonNumeroRue" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblNomRue" runat="server" Text="Rue : "></asp:Label>
    <asp:Label ID="lblLivraisonNomRue" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblCodePostal" runat="server" Text="Code postal : "></asp:Label>
    <asp:Label ID="lblLivraisonCodePostal" runat="server" Text=""></asp:Label>
    <br />
    </div>
    <div id="adresseSelectionner">
        <asp:ListView ID="ListView1" runat="server">

        </asp:ListView>
    </div>
    <asp:Label ID="lblDate" runat="server" Text="Date : "></asp:Label>
    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblHeure" runat="server" Text="Heure : "></asp:Label>
    <asp:ListBox ID="lbHeure" runat="server"></asp:ListBox>:<asp:ListBox ID="lbMinute" runat="server"></asp:ListBox>
    <br />
    <asp:Button ID="btnTerminer" runat="server" Text="Terminer"/>
</asp:Content>
