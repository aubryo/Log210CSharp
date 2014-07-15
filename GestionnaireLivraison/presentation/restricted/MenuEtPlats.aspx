<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="MenuEtPlats.aspx.cs" Inherits="GestionnaireLivraison.presentation.MenuEtPlats" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Créer ou modifier un menu"></asp:Label>
    <br />
    <asp:Label ID="lblNomMenu" runat="server" Text="Nom : "></asp:Label>
    <asp:TextBox ID="txtNomMenu" runat="server"></asp:TextBox>
    <br />
    <div id="menuItems">
        <asp:ListView ID="lvPlat" runat="server">
            <LayoutTemplate>
                <ul id="itemPlaceholderContainer" runat="server" style="">
                    <li runat="server" id="itemPlaceholder" />
                </ul>
            </LayoutTemplate>
            <ItemTemplate>
                <li>
                    <asp:Label ID="lblPlatNom" runat="server" Text='<%# Eval("Nom") %>' />
                    <asp:Label ID="lblPlatPrix" runat="server" Text='<%# Eval("Prix") %>' />
                    </ br>
                    <asp:Label ID="lblPlatDescription" runat="server" Text='<%# Eval("Description") %>' />
                </li>
            </ItemTemplate>
            <SelectedItemTemplate>
                <li>
                    <asp:Label ID="lblPlatNom" runat="server" Text='<%# Eval("Nom") %>' />
                    <asp:Label ID="lblPlatPrix" runat="server" Text='<%# Eval("Prix") %>' />
                    </ br>
                    <asp:Label ID="lblPlatDescription" runat="server" Text='<%# Eval("Description") %>' />
                    <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CommandArgument='<%# Eval("Id") %>' />
                </li>
            </SelectedItemTemplate>
            <ItemSeparatorTemplate>
                <li>
                    </ hr>
                </li>
            </ItemSeparatorTemplate>
        </asp:ListView>
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
        <asp:Button ID="btnAjoutPlat" runat="server" Text="Ajouter le plat" OnClick="btnAjoutPlat_Click" />
        <br />
        <asp:Label ID="lblState" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div id="sauvegardeMenu">
        <asp:Button ID="btnSaveAndReturn" runat="server" Text="Sauvegarder et retourner à l'accueil" OnClick="btnSaveAndReturn_Click" /><asp:Button ID="SaveAndNewMenu" runat="server" Text="Sauvegarder et créer un nouveau menu" OnClick="SaveAndNewMenu_Click" />
    </div>
</asp:Content>
