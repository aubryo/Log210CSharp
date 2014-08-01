<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Commande.aspx.cs" Inherits="GestionnaireLivraison.presentation.Commande" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
<div class="container-fluid">
<div class="row">
    <div class="col-xs-12 col-md-6 col-md-offset-3">
        <h1>Passer une commande</h1>
        <hr />
    <br />

        <h3>Liste des restaurants</h3>
        <br />
    <asp:ObjectDataSource ID="odsRestaurants" runat="server" SelectMethod="GetRestaurantsCommandable" TypeName="GestionnaireLivraison.controleur.ControleurRestaurants"></asp:ObjectDataSource>
    <asp:ListView ID="lvRestaurant" runat="server" DataKeyNames="Id" DataSourceID="odsRestaurants">
        <EmptyDataTemplate>
            Aucun restaurant.
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
        <LayoutTemplate>
            <ul id="itemPlaceholderContainer" runat="server" style="">
                <li runat="server" id="itemPlaceholder" />
            </ul>
            <div style="">
            </div>
            <asp:LinkButton ID="lnkPoursuivre" CssClass="btn btn-success" runat="server" OnClick="lnkPoursuivre_Click"><span class="glyphicon glyphicon-arrow-right"></span>&nbsp;Poursuivre ma commande</asp:LinkButton>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <li style="">
                <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                <br />
                <asp:ObjectDataSource ID="odsMenus" runat="server" SelectMethod="GetMenus" TypeName="GestionnaireLivraison.controleur.ControleurMenus">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="lvRestaurant" Name="Id" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ListView ID="lvMenu" runat="server" DataSourceID="odsMenus" DataKeyNames="Id">
                    <EmptyDataTemplate>
                        <span>Aucun menu disponible pour le moment.</span>
                    </EmptyDataTemplate>
                    <ItemTemplate>
                        <span style="">
                            <asp:LinkButton ID="btnNom" runat="server" Text='<%# Eval("Nom") %>' CommandName="Select"></asp:LinkButton>
                            <br />
                        </span>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <div id="itemPlaceholderContainer" runat="server" style="">
                            <span runat="server" id="itemPlaceholder" />
                        </div>
                        <div style="">
                        </div>
                    </LayoutTemplate>
                    <SelectedItemTemplate>
                        <span style="">
                            <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                            <br />
                            <asp:ObjectDataSource ID="odsPlats" runat="server" SelectMethod="GetPlats" TypeName="GestionnaireLivraison.controleur.ControleurMenus">
                                <SelectParameters>
                                    <asp:ControlParameter ControlID="lvMenu" Name="mId" PropertyName="SelectedValue" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                            <asp:ListView ID="lvPlat" runat="server" DataSourceID="odsPlats" DataKeyNames="Id" OnItemCommand="lvPlat_ItemCommand">
                                <EmptyDataTemplate>
                                    <table id="Table1" runat="server" style="">
                                        <tr>
                                            <td>Aucun plat pour le moment.</td>
                                        </tr>
                                    </table>
                                </EmptyDataTemplate>
                                <ItemTemplate>
                                    <tr style="">
                                        <td>
                                            <asp:HiddenField ID="hfId" runat="server" Value='<%# Eval("Id") %>' />
                                            <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Eval("Description") %>' />
                                        </td>
                                        <td>
                                            <asp:Label ID="PrixLabel" runat="server" Text='<%# Eval("Prix") %>' />
                                        </td>
                                        <td>
                                            <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAjouter" runat="server" Text="Ajouter au panier" CommandName="AjouterLigneCommande" />
                                        </td>
                                    </tr>
                                </ItemTemplate>
                                <LayoutTemplate>
                                    <table id="Table2" runat="server">
                                        <tr id="Tr1" runat="server">
                                            <td id="Td1" runat="server">
                                                <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                                    <tr id="Tr2" runat="server" style="">
                                                        <th id="Th1" runat="server">Nom</th>
                                                        <th id="Th2" runat="server">Description</th>
                                                        <th id="Th3" runat="server">Prix</th>
                                                        <th id="Th4" runat="server">Quantité</th>
                                                        <th id="Th5" runat="server"></th>
                                                    </tr>
                                                    <tr id="itemPlaceholder" runat="server">
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr id="Tr3" runat="server">
                                            <td id="Td2" runat="server" style=""></td>
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                            </asp:ListView>
                        </span>
                    </SelectedItemTemplate>
                </asp:ListView>
            </li>
        </SelectedItemTemplate>
    </asp:ListView>
    <br />
    </div>
</div>
</div>

</asp:Content>
