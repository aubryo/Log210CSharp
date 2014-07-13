<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilEntrepreneur.aspx.cs" Inherits="GestionnaireLivraison_LOG210.presentation.AccueilEntrepreneur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <div>
        <div>
            <asp:label id="lblTitre" runat="server" text="Gestionnaire de livraison"></asp:label>
            <br />
            <asp:menu id="menuTabs" runat="server" orientation="Horizontal" onmenuitemclick="menuTabs_MenuItemClick">
                <Items>
                    <asp:MenuItem Text="Gérer les restaurants" Value="0"></asp:MenuItem>
                    <asp:MenuItem Text="Gérer les restaurateurs" Value="1"></asp:MenuItem>
                </Items>
            </asp:menu>
        </div>
        <div>
            <asp:multiview id="vuesEntrepreneur" runat="server" activeviewindex="0">
                <asp:View id="tabRestaurant" runat="server">
                    <asp:Label id="lblListRestaurants" runat="server" Text="List des restaurants"></asp:Label><br />
                    <asp:GridView ID="gvRestaurant" runat="server">
                    </asp:GridView><br />
                    <asp:Button id="btnAjoutRestorant" runat="server" Text="Ajouter un restaurant"></asp:Button>
                </asp:View>
                <asp:View id="tabRestaurateur" runat="server">
                    <asp:Label id="lblListRestaurateurs" runat="server" Text="List des restaurants"></asp:Label><br />
                    <asp:GridView ID="gvRestaurateur" runat="server">
                    </asp:GridView><br />
                    <asp:Button id="btnAjoutRestorateur" runat="server" Text="Ajouter un restaurant"></asp:Button>
                </asp:View>
        </asp:multiview>
        </div>
    </div>
</asp:Content>
