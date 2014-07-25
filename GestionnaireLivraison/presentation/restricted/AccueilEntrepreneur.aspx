<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilEntrepreneur.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilEntrepreneur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
<div class="container-fluid">
<div class="row">
    <div class="col-xs-12 col-md-6 col-md-offset-3">
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
                                No. Telephone:
                                <asp:Label ID="NoTelephoneLabel" runat="server" Text='<%# Eval("NoTelephone") %>' />
                                <br />
                                No. Rue:
                                <asp:Label ID="NoRueLabel" runat="server" Text='<%# Eval("NoRue") %>' />
                                <br />
                                Code Postal:
                                <asp:Label ID="CodePostalLabel" runat="server" Text='<%# Eval("CodePostal") %>' />
                                <br />
                                Nom de la Rue:
                                <asp:Label ID="NomRueLabel" runat="server" Text='<%# Eval("NomRue") %>' />
                                <br />
                                Site Web:
                                <asp:Label ID="WebsiteLabel" runat="server" Text='<%# Eval("Website") %>' />
                                <br />
                                Url:
                                <asp:Label ID="UrlLabel" runat="server" Text='<%# Eval("Url") %>' />
                                <br />
                                Description:
                                <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                                <br />
                                <asp:LinkButton ID="DeleteButton" CssClass="btn btn-danger" runat="server" CommandName="Delete"><span class="glyphicon glyphicon-remove"></span>&nbsp;Supprimer</asp:LinkButton>
                                <asp:HyperLink ID="hlUpdate" runat="server" CssClass="btn btn-primary" NavigateUrl='<%#"~/presentation/restricted/Restaurant.aspx?Id="+Eval("Id")%>'><span class="glyphicon glyphicon-pencil"></span>&nbsp;Modifier</asp:HyperLink>
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                    <asp:HyperLink ID="lbAjoutRestaurant" runat="server" CssClass="btn btn-success" NavigateUrl="~/presentation/restricted/Restaurant.aspx"><span class="glyphicon glyphicon-plus"></span>&nbsp;Ajouter un Restaurant</asp:HyperLink>
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
                            Aucun restaurateur.
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
                                Date de Naissance:
                                <asp:Label ID="DateNaissanceLabel" runat="server" Text='<%# Eval("DateNaissance") %>' />
                                <br />
                                No. Telephone:
                                <asp:Label ID="NoTelephoneLabel" runat="server" Text='<%# Eval("NoTelephone") %>' />
                                <br />
                                AdresseId:
                                <asp:Label ID="AdresseIdLabel" runat="server" Text='<%# Eval("AdresseId") %>' />
                                <br />
                                Courriel:
                                <asp:Label ID="CourrielLabel" runat="server" Text='<%# Eval("Courriel") %>' />
                                <br />
                                <asp:LinkButton ID="DeleteButton" CssClass="btn btn-danger" runat="server" CommandName="Delete"><span class="glyphicon glyphicon-remove"></span>&nbsp;Supprimer</asp:LinkButton>
                                <asp:HyperLink ID="hlUpdate" CssClass="btn btn-primary"  runat="server" NavigateUrl='<%#"~/presentation/restricted/Restaurateur.aspx?Id="+Eval("Id")%>'><span class="glyphicon glyphicon-pencil"></span>&nbsp;Modifier</asp:HyperLink>
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                    <asp:HyperLink ID="hlAjoutRestaurateur" runat="server" CssClass="btn btn-success" NavigateUrl="~/presentation/restricted/Restaurateur.aspx"><span class="glyphicon glyphicon-plus"></span>&nbsp;Ajouter un Restaurateur</asp:HyperLink>
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</div>
</div>
</asp:Content>
