<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilEntrepreneur.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilEntrepreneur" %>

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
                    <asp:Label ID="lblListRestaurants" runat="server" Text="Liste des restaurants"></asp:Label><br />
                    <asp:ObjectDataSource ID="odsRestaurant" runat="server" DeleteMethod="DeleteRestaurant" SelectMethod="GetRestaurants" TypeName="GestionnaireLivraison.controleur.ControleurRestaurants">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="String" />
                        </DeleteParameters>
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
                            <li style="">
                                Nom:
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
                                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Supprimer" />
                                <asp:HyperLink ID="hlUpdate" runat="server" Text="Modifier" NavigateUrl='<%#"~/presentation/restricted/Restaurant.aspx?Id="+Eval("Id")%>'></asp:HyperLink>
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                    <asp:HyperLink ID="hlAjoutRestaurant" runat="server" Text="Ajouter un restaurant" NavigateUrl="~/presentation/restricted/Restaurant.aspx"/>
                </asp:View>
                <asp:View ID="tabRestaurateur" runat="server">
                    <asp:Label ID="lblListRestaurateurs" runat="server" Text="Liste des restaurateurs"></asp:Label><br />
                    <asp:ObjectDataSource ID="odsRestaurateur" runat="server" DeleteMethod="DeleteRestaurateur" SelectMethod="GetRestaurateurs" TypeName="GestionnaireLivraison.controleur.ControleurRestaurateurs">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="String" />
                        </DeleteParameters>
                    </asp:ObjectDataSource>
                    <asp:ListView ID="lvRestaurateur" runat="server" DataSourceID="odsRestaurateur"  DataKeyNames="Id">
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
                                Prenom:
                                <asp:Label ID="PrenomLabel" runat="server" Text='<%# Eval("Prenom") %>' />
                                <br />
                                DateNaissance:
                                <asp:Label ID="DateNaissanceLabel" runat="server" Text='<%# Eval("DateNaissance") %>' />
                                <br />
                                NoTelephone:
                                <asp:Label ID="NoTelephoneLabel" runat="server" Text='<%# Eval("NoTelephone") %>' />
                                <br />
                                AdresseId:
                                <asp:Label ID="AdresseIdLabel" runat="server" Text='<%# Eval("AdresseId") %>' />
                                <br />
                                Courriel:
                                <asp:Label ID="CourrielLabel" runat="server" Text='<%# Eval("Courriel") %>' />
                                <br />
                                <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Supprimer" />
                                <asp:HyperLink ID="hlUpdate" runat="server" Text="Modifier" NavigateUrl='<%#"~/presentation/restricted/Restaurateur.aspx?Id="+Eval("Id")%>'></asp:HyperLink>
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                    <asp:HyperLink ID="hlAjoutRestaurateur" runat="server" Text="Ajouter un restaurateur" NavigateUrl="~/presentation/restricted/Restaurateur.aspx"/>
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</asp:Content>
