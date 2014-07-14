<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="MenuEtPlats.aspx.cs" Inherits="GestionnaireLivraison.presentation.MenuEtPlats" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
    <script type="text/javascript">
        /* Cas d'utilisation F5 3a.
         * Si txtDescription.Text == "" avertire que le menu est sauvegarder sans description
         */

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Créer ou modifier un menu"></asp:Label>
    <br />
    <asp:Label ID="lblNomMenu" runat="server" Text="Nom : "></asp:Label>
    <asp:TextBox ID="txtNomMenu" runat="server"></asp:TextBox>
    <br />
    <div id="menuItems">
        <asp:GridView ID="gvPlat" runat="server">
        </asp:GridView>
    </div>
    <div id="newPlat">
        <asp:Label ID="lblPlatTitre" runat="server" Text="Nouveau plat"></asp:Label>
        <br />
        <asp:Label ID="lblNomPlat" runat="server" Text="Nom : "></asp:Label>
        <asp:TextBox ID="txtNomPlat" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDescription" runat="server" Text="Description : "></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrix" runat="server" Text="Prix : "></asp:Label>
        <asp:TextBox ID="txtPrix" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAjoutPlat" runat="server" Text="Ajouter le plat" />
    </div>
    <div id="sauvegardeMenu">
        <asp:Button ID="btnSaveAndReturn" runat="server" Text="Sauvegarder et retourner à l'accueil" /><asp:Button ID="SaveAndNewMenu" runat="server" Text="Sauvegarder et créer un nouveau menu" />
    </div>
</asp:Content>
