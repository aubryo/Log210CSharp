<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilRestaurateur.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilRestaurateur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div>
        <div>
            <asp:label id="lblTitre" runat="server" text="Gestionnaire de livraison"></asp:label>
            <br />
            <asp:menu id="menuTabs" runat="server" orientation="Horizontal" onmenuitemclick="menuTabs_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="Gérer les menus" Value="0"></asp:MenuItem>
                </Items>
            </asp:menu>
        </div>
        <div>
            <asp:multiview id="vuesEntrepreneur" runat="server" activeviewindex="0">
                <asp:View id="tabMenu" runat="server">
                    <asp:Label id="lblListRestaurants" runat="server" Text="Vos restaurants"></asp:Label><br />
                    <asp:ListView ID="lvRestaurant" runat="server">
                    </asp:ListView><br />
                </asp:View>
        </asp:multiview>
        </div>
    </div>
</asp:Content>
