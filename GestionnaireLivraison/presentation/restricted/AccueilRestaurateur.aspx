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
                    <asp:ObjectDataSource ID="odsRestaurant" runat="server" SelectMethod="GetRestaurants" TypeName="GestionnaireLivraison.controleur.ControleurRestaurants">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="id" QueryStringField="Id" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:ListView ID="lvRestaurant" runat="server" DataSourceID="odsRestaurant" DataKeyNames="Id">
                        <LayoutTemplate>
                            <ul id="itemPlaceholderContainer" runat="server" style="">
                                <li runat="server" id="itemPlaceholder" />
                            </ul>
                            <div style="">
                            </div>
                        </LayoutTemplate>
                        <EmptyDataTemplate>
                            No data was returned.
                        </EmptyDataTemplate>
                        <ItemSeparatorTemplate>
                            <br />
                        </ItemSeparatorTemplate>
                        <ItemTemplate>
                            <li style="">
                                <asp:LinkButton ID="btnNom" runat="server" Text='<%# Eval("Nom") %>' CommandName="Select"></asp:LinkButton>
                                <br />
                            </li>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <li style="">Nom:
                                <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                                <br />
                                NoTelephone:
                                <asp:Label ID="NoTelephoneLabel" runat="server" Text='<%# Eval("NoTelephone") %>' />
                                <br />
                                NoRue:
                                <asp:Label ID="NoRueLabel" runat="server" Text='<%# Eval("NoRue") %>' />
                                <br />
                                CodePostal:
                                <asp:Label ID="CodePostalLabel" runat="server" Text='<%# Eval("CodePostal") %>' />
                                <br />
                                NomRue:
                                <asp:Label ID="NomRueLabel" runat="server" Text='<%# Eval("NomRue") %>' />
                                <br />
                                Website:
                                <asp:Label ID="WebsiteLabel" runat="server" Text='<%# Eval("Website") %>' />
                                <br />
                                Url:
                                <asp:Label ID="UrlLabel" runat="server" Text='<%# Eval("Url") %>' />
                                <br />
                                Description:
                                <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                                <br />
                                <br />
                                Liste des menus:
                                <br />
                                <asp:ObjectDataSource ID="odsMenu" runat="server" SelectMethod="GetMenus" TypeName="GestionnaireLivraison.controleur.ControleurMenus">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lvRestaurant" Name="id" PropertyName="SelectedValue" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                <asp:ListView ID="lvMenu" runat="server" DataSourceID="odsMenu" DataKeyNames="Id">
                                    <LayoutTemplate>
                                        <div id="itemPlaceholderContainer" runat="server" style="">
                                            <span runat="server" id="itemPlaceholder" />
                                        </div>
                                        <div style="">
                                        </div>
                                    </LayoutTemplate>
                                    <EmptyDataTemplate>
                                        <span>Vous ne possédez aucun menu. Veuillez en ajouter !</span>
                                            <br />
                                    </EmptyDataTemplate>
                                    <ItemTemplate>
                                        <span style="">
                                            <asp:HyperLink ID="hlModifierMenu" runat="server" Text='<%# Eval("Nom") %>' NavigateUrl='<%#"~/presentation/restricted/MenuEtPlats.aspx?MId="+Eval("Id")%>'></asp:HyperLink>
                                            <br />
                                            <br />
                                        </span>
                                    </ItemTemplate>
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
