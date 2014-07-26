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
                <Items>
                    <asp:MenuItem Text="Gérer les commandes" Value="1" />
                </Items>
            </asp:Menu>
        </div>
        <div>
            <asp:ObjectDataSource ID="odsRestaurant" runat="server" SelectMethod="GetRestaurants" TypeName="GestionnaireLivraison.controleur.ControleurRestaurants">
                <SelectParameters>
                    <asp:QueryStringParameter Name="id" QueryStringField="Id" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:MultiView ID="vuesEntrepreneur" runat="server" ActiveViewIndex="0">
                <asp:View ID="tabMenu" runat="server">
                    <asp:Label ID="lblListRestaurants" runat="server" Text="Vos restaurants"></asp:Label><br />
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
                <asp:View ID="tabCommande" runat="server">
                    <asp:Label ID="lblCommandes" runat="server" Text="Vos commandes"></asp:Label><br />
                    <asp:ListView ID="lvRestaurantWithCommandes" runat="server" DataSourceID="odsRestaurant" DataKeyNames="Id">
                        <EmptyDataTemplate>
                            <span>Vous ne possédez aucun menu. Veuillez en ajouter !</span>
                            <br />
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
                                <asp:Label ID="lblNom" runat="server" Text='<%# Eval("Nom") %>'></asp:Label>
                                <br />
                                <asp:ObjectDataSource ID="odsCommande" runat="server" SelectMethod="GetCommandes" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                                    <SelectParameters>
                                        <asp:ControlParameter ControlID="lvRestaurantWithCommandes" Name="restaurantId" PropertyName="SelectedValue" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                                <asp:ListView ID="lvCommandes" runat="server" DataSourceID="odsCommande" DataKeyNames="Id">
                                    <EmptyDataTemplate>
                                        <table id="Table1" runat="server" style="">
                                            <tr>
                                                <td>No data was returned.</td>
                                            </tr>
                                        </table>
                                    </EmptyDataTemplate>
                                    <ItemTemplate>
                                        <tr style="">
                                            <td>
                                                <asp:LinkButton ID="btnNoCommande" runat="server" Text='<%# Eval("NoCommande") %>' CommandName="Select"></asp:LinkButton>
                                            </td>
                                            <td>
                                                <asp:Label ID="DateCreationLabel" runat="server" Text='<%# Eval("DateCreation") %>' />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="radPassee" runat="server" Checked='<%# String.Equals(Eval("Statut"), "Passee") %>' AutoPostBack="true" OnCheckedChanged="radioButton_CheckedChanged" GroupName='<%# Eval("Id") %>' />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="radEnPreparation" runat="server" Checked='<%# String.Equals(Eval("Statut"), "EnPreparation") %>' AutoPostBack="true" OnCheckedChanged="radioButton_CheckedChanged" GroupName='<%# Eval("Id") %>' />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="radPrete" runat="server" Checked='<%# String.Equals(Eval("Statut"), "Prete") %>' AutoPostBack="true" OnCheckedChanged="radioButton_CheckedChanged" GroupName='<%# Eval("Id") %>' />
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                    <LayoutTemplate>
                                        <table id="Table2" runat="server">
                                            <tr id="Tr1" runat="server">
                                                <td id="Td1" runat="server">
                                                    <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                                        <tr id="Tr2" runat="server" style="">
                                                            <th id="Th1" runat="server">NoCommande</th>
                                                            <th id="Th2" runat="server">DateCreation</th>
                                                            <th id="Th3" runat="server">Passee</th>
                                                            <th id="Th4" runat="server">En Preparation</th>
                                                            <th id="Th5" runat="server">Prete</th>
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
                                    <SelectedItemTemplate>
                                        <tr style="">
                                            <td>
                                                <asp:Label ID="NoCommandeLabel" runat="server" Text='<%# Eval("NoCommande") %>' />
                                            </td>
                                            <td>
                                                <asp:Label ID="DateCreationLabel" runat="server" Text='<%# Eval("DateCreation") %>' />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="radPassee" runat="server" Checked='<%# String.Equals(Eval("Statut"), "Passee") %>' AutoPostBack="true" OnCheckedChanged="radioButton_CheckedChanged" GroupName='<%# Eval("Id") %>' />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="radEnPreparation" runat="server" Checked='<%# String.Equals(Eval("Statut"), "EnPreparation") %>' AutoPostBack="true" OnCheckedChanged="radioButton_CheckedChanged" GroupName='<%# Eval("Id") %>' />
                                            </td>
                                            <td>
                                                <asp:RadioButton ID="radPrete" runat="server" Checked='<%# String.Equals(Eval("Statut"), "Prete") %>' AutoPostBack="true" OnCheckedChanged="radioButton_CheckedChanged" GroupName='<%# Eval("Id") %>' />
                                            </td>
                                        </tr>
                                        <tr>
                                            <asp:ObjectDataSource ID="odsLigneCommande" runat="server" SelectMethod="GetLigneCommandes" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                                                <SelectParameters>
                                                    <asp:ControlParameter ControlID="lvCommandes" Name="commandeId" PropertyName="SelectedValue" Type="String" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>
                                            <asp:ListView ID="lvLigneCommande" runat="server" DataKeyNames="Id" DataSourceID="odsLigneCommande">
                                                <EmptyDataTemplate>
                                                    <table id="Table1" runat="server" style="">
                                                        <tr>
                                                            <td>No data was returned.</td>
                                                        </tr>
                                                    </table>
                                                </EmptyDataTemplate>
                                                <ItemTemplate>
                                                    <tr style="">
                                                        <td>
                                                            <asp:Label ID="PlatIdLabel" runat="server" Text='<%# Eval("PlatId") %>' />
                                                        </td>
                                                        <td>
                                                            <asp:Label ID="quantiteLabel" runat="server" Text='<%# Eval("quantite") %>' />
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                                <LayoutTemplate>
                                                    <table id="Table2" runat="server">
                                                        <tr id="Tr1" runat="server">
                                                            <td id="Td1" runat="server">
                                                                <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                                                    <tr id="Tr2" runat="server" style="">
                                                                        <th id="Th1" runat="server">PlatId</th>
                                                                        <th id="Th2" runat="server">quantite</th>
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
                                        </tr>
                                    </SelectedItemTemplate>
                                </asp:ListView>
                            </li>
                        </SelectedItemTemplate>
                        <LayoutTemplate>
                            <ul id="itemPlaceholderContainer" runat="server" style="">
                                <li runat="server" id="itemPlaceholder" />
                            </ul>
                            <div style="">
                            </div>
                        </LayoutTemplate>

                    </asp:ListView>
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</asp:Content>
