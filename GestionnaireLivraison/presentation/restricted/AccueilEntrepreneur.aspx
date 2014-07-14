﻿<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilEntrepreneur.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilEntrepreneur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div>
        <div>
            <asp:Label ID="lblTitre" runat="server" Text="Gestionnaire de livraison"></asp:Label>
            <br />
            <asp:Menu ID="menuTabs" runat="server" Orientation="Horizontal" OnMenuItemClick="menuTabs_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="Gérer les restaurants" Value="0"></asp:MenuItem>
                    <asp:MenuItem Text="Gérer les restaurateurs" Value="1"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
        <div>
            <asp:MultiView ID="vuesEntrepreneur" runat="server" ActiveViewIndex="0">
                <asp:View ID="tabRestaurant" runat="server">
                    <asp:Label ID="lblListRestaurants" runat="server" Text="List des restaurants"></asp:Label><br />
                    <asp:ListView ID="lsRestaurant" runat="server" DataKeyNames="Id" OnItemCommand="lsRestaurant_ItemCommand">
                        <LayoutTemplate>
                            <ul id="itemPlaceholderContainer" runat="server" style="">
                                <li runat="server" id="itemPlaceholder" />
                            </ul>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li>
                                <asp:Label ID="lblRestaurantNom" runat="server" Text='<%# Eval("Nom") %>' />
                            </li>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <li>
                                <asp:Label ID="lblRestaurantNom" runat="server" Text='<%# Eval("Nom") %>' />
                                <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CommandArgument='<%# Eval("Id") %>' />
                                <asp:HyperLink ID="hlUpdate" runat="server" Text="Modifier" PostBackUrl='<%#"~/presentation/restricted/Restaurant.aspx?Id="+Eval("Id")%>'></asp:HyperLink>
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                    <asp:Button ID="btnAjoutRestaurant" runat="server" Text="Ajouter un restaurant" OnClick="btnAjoutRestaurant_Click"></asp:Button>
                </asp:View>
                <asp:View ID="tabRestaurateur" runat="server">
                    <asp:Label ID="lblListRestaurateurs" runat="server" Text="List des restaurants"></asp:Label><br />
                    <asp:ListView ID="lsRestaurateur" runat="server" DataKeyNames="Id" OnItemCommand="lsRestaurateur_ItemCommand">
                        <LayoutTemplate>
                            <ul id="itemPlaceholderContainer" runat="server" style="">
                                <li runat="server" id="itemPlaceholder" />
                            </ul>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li>
                                <asp:Label ID="lblRestaurateurNom" runat="server" Text='<%# Eval("Nom") %>' />
                            </li>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <li>
                                <asp:Label ID="lblRestaurateurNom2" runat="server" Text='<%# Eval("Nom") %>' />
                                <asp:Button ID="btnDelete" runat="server" Text="Supprimer" CommandArgument='<%# Eval("Id") %>' />
                                <asp:HyperLink ID="hlUpdate" runat="server" Text="Modifier" PostBackUrl='<%#"~/presentation/restricted/Restaurateur.aspx?Id="+Eval("Id")%>'></asp:HyperLink>
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                    <asp:Button ID="btnAjoutRestorateur" runat="server" Text="Ajouter un restaurateur" OnClick="btnAjoutRestorateur_Click"></asp:Button>
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</asp:Content>