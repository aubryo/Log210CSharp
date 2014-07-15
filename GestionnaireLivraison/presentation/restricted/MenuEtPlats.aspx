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
        <asp:ObjectDataSource ID="odsPlat" runat="server" DeleteMethod="SupprimerPlat" SelectMethod="GetPlats" TypeName="GestionnaireLivraison.controleur.ControleurMenus">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="String" />
            </DeleteParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="mId" QueryStringField="MId" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ListView ID="lvPlat" runat="server" DataKeyNames="Id" DataSourceID="odsPlat">
            <LayoutTemplate>
                <ul id="itemPlaceholderContainer" runat="server" style="">
                    <li runat="server" id="itemPlaceholder" />
                </ul>
                <div style="">
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <li style="">
                    Nom:
                    <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                    <br />
                    Description:
                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                    <br />
                    Prix:
                    <asp:Label ID="PrixLabel" runat="server" Text='<%# Eval("Prix") %>' />
                    <br />
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                </li>
            </ItemTemplate>
            <ItemSeparatorTemplate>
                <br />
            </ItemSeparatorTemplate>
        </asp:ListView>
        <asp:ObjectDataSource ID="odsUnsavePlat" runat="server" SelectMethod="GetUnsavedPlat" TypeName="GestionnaireLivraison.presentation.MenuEtPlats"></asp:ObjectDataSource>
        <asp:ListView ID="lvUnsavePlats" runat="server" DataKeyNames="Id" DataSourceID="odsUnsavePlat">
            <LayoutTemplate>
                <ul id="itemPlaceholderContainer" runat="server" style="">
                    <li runat="server" id="itemPlaceholder" />
                </ul>
                <div style="">
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <li style="">
                    Nom:
                    <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                    <br />
                    Description:
                    <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                    <br />
                    Prix:
                    <asp:Label ID="PrixLabel" runat="server" Text='<%# Eval("Prix") %>' />
                    <br />
                </li>
            </ItemTemplate>
            <ItemSeparatorTemplate>
                <br />
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
