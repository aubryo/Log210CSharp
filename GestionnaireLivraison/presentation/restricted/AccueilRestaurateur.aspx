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
                    <asp:ObjectDataSource ID="odsMenu" runat="server" SelectMethod="GetMenus" TypeName="GestionnaireLivraison.controleur.ControleurMenus">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="lvRestaurant" Name="id" PropertyName="SelectedValue" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <asp:ListView ID="lvRestaurant" runat="server" DataSourceID="odsRestaurant">
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
                                <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
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
                            </li>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <asp:ListView ID="lvMenu" runat="server" DataSourceID="odsMenu">
                        <LayoutTemplate>
                            <div id="itemPlaceholderContainer" runat="server" style="">
                                <span runat="server" id="itemPlaceholder" />
                            </div>
                            <div style="">
                            </div>
                        </LayoutTemplate>
                        <AlternatingItemTemplate>
                            <span style="">Id:
                            <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                            <br />
                            Nom:
                            <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                            <br />
                            RestaurantId:
                            <asp:Label ID="RestaurantIdLabel" runat="server" Text='<%# Eval("RestaurantId") %>' />
                            <br />
                            <br />
                            </span>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <span style="">Id:
                            <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                            <br />
                            Nom:
                            <asp:TextBox ID="NomTextBox" runat="server" Text='<%# Bind("Nom") %>' />
                            <br />
                            RestaurantId:
                            <asp:TextBox ID="RestaurantIdTextBox" runat="server" Text='<%# Bind("RestaurantId") %>' />
                            <br />
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                            <br />
                            <br />
                            </span>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <span>No data was returned.</span>
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <span style="">Id:
                            <asp:TextBox ID="IdTextBox" runat="server" Text='<%# Bind("Id") %>' />
                            <br />
                            Nom:
                            <asp:TextBox ID="NomTextBox" runat="server" Text='<%# Bind("Nom") %>' />
                            <br />
                            RestaurantId:
                            <asp:TextBox ID="RestaurantIdTextBox" runat="server" Text='<%# Bind("RestaurantId") %>' />
                            <br />
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                            <br />
                            <br />
                            </span>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <span style="">Id:
                            <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                            <br />
                            Nom:
                            <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                            <br />
                            RestaurantId:
                            <asp:Label ID="RestaurantIdLabel" runat="server" Text='<%# Eval("RestaurantId") %>' />
                            <br />
                            <br />
                            </span>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <span style="">Id:
                            <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                            <br />
                            Nom:
                            <asp:Label ID="NomLabel" runat="server" Text='<%# Eval("Nom") %>' />
                            <br />
                            RestaurantId:
                            <asp:Label ID="RestaurantIdLabel" runat="server" Text='<%# Eval("RestaurantId") %>' />
                            <br />
                            <br />
                            </span>
                        </SelectedItemTemplate>
                    </asp:ListView>
                    <br />
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</asp:Content>
