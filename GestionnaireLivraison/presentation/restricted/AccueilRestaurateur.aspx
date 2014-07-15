<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilRestaurateur.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilRestaurateur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div>
        <div>
            <asp:Label ID="lblTitre" runat="server" Text="Gestionnaire de livraison"></asp:Label>
            <br />
            <asp:Menu ID="menuTabs" runat="server" Orientation="Horizontal" OnMenuItemClick="menuTabs_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="Gérer les menus" Value="0"></asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
        <div>
            <asp:MultiView ID="vuesEntrepreneur" runat="server" ActiveViewIndex="0">
                <asp:View ID="tabMenu" runat="server">
                    <asp:Label ID="lblListRestaurants" runat="server" Text="Vos restaurants"></asp:Label><br />
                    <asp:ListView ID="lvRestaurant" runat="server" DataKeyNames="Id">
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
                                <asp:ListView ID="lvMenu" runat="server" DataKeyNames="Id">
                                    <LayoutTemplate>
                                        <ul id="itemPlaceholderContainer" runat="server" style="">
                                            <li runat="server" id="itemPlaceholder" />
                                        </ul>
                                    </LayoutTemplate>
                                    <ItemTemplate>
                                        <li>
                                            <asp:Label ID="lblMenuNom" runat="server" Text='<%# Eval("Nom") %>' />
                                        </li>
                                    </ItemTemplate>
                                    <SelectedItemTemplate>
                                        <li>
                                            <asp:Label ID="lblMenuNom" runat="server" Text='<%# Eval("Nom") %>' />
                                            <asp:HyperLink ID="hlModifierMenu" runat="server" Text="Modifier la menu" NavigateUrl='<%#"~/presentation/restricted/MenuEtPlats.aspx?MId="+Eval("Id")%>'></asp:HyperLink>
                                        </li>
                                    </SelectedItemTemplate>
                                </asp:ListView>
                                <asp:HyperLink ID="hlAjouterMenu" runat="server" Text="Ajouter un menu" NavigateUrl='<%#"~/presentation/restricted/MenuEtPlats.aspx?RId="+Eval("Id")%>'></asp:HyperLink>
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</asp:Content>
