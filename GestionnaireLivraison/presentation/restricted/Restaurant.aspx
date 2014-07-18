<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="GestionnaireLivraison.presentation.Restaurant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {


            $(".btnCreerRestaurant").click(function () {
                var test = $(".rbRestaurateur").attr("selectedIndex");
                if ($('.rbRestaurateur :selected').text() == '') {
                    alert("Attention, vous n'avez assigné aucun restaurateur à votre restaurant.");
                }
            });

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Créer un restaurant"></asp:Label>
    <br />
    <asp:Label ID="lblNom" runat="server" Text="Nom : "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNumeroTel" runat="server" Text="Numéro de téléphone : "></asp:Label>
    <asp:TextBox ID="txtNumeroTel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNumeroRue" runat="server" Text="Numéro de rue : "></asp:Label>
    <asp:TextBox ID="txtNumeroRue" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblNomRue" runat="server" Text="Rue : "></asp:Label>
    <asp:TextBox ID="txtNomRue" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCodePostal" runat="server" Text="Code postal : "></asp:Label>
    <asp:TextBox ID="txtCodePostal" runat="server"></asp:TextBox>
    <br />
    <asp:ObjectDataSource ID="odsRestaurateur" runat="server" SelectMethod="GetRestaurateurs" TypeName="GestionnaireLivraison.controleur.ControleurRestaurateurs"></asp:ObjectDataSource>
    <asp:Label ID="lblRestaurateur" runat="server" Text="Restaurateur : "></asp:Label>
    <asp:RadioButtonList ID="rbRestaurateur" CssClass="rbRestaurateur" runat="server" DataSourceID="odsRestaurateur" DataTextField="Nom" DataValueField="Id" OnDataBound="rbRestaurateur_DataBound" AppendDataBoundItems="true">
        <asp:ListItem Value="000000000000000000000000" Text="Aucun"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="lblDescription" runat="server" Text="Description : "></asp:Label>
    <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
    <br />    
    <asp:Label ID="lblSiteWeb" runat="server" Text="Site web : "></asp:Label>
    <asp:TextBox ID="txtSiteWeb" runat="server"></asp:TextBox>
    <br />    
    <asp:Label ID="lblUrlBanniere" runat="server" Text="Url Banniere : "></asp:Label>
    <asp:TextBox ID="txtUrlBanniere" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSauvegarder" runat="server" Text="Sauvegarder" CssClass="btnCreerRestaurant" OnClick="btnSauvegarder_Click"/>
</asp:Content>
