<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Restaurateur.aspx.cs" Inherits="GestionnaireLivraison.presentation.Restaurateur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {
            
            $(".creerCompte").click(function () {
                var nbchecked = 0;
                $("input[type=checkbox]").each(function () {
                    var sThisVal = (this.checked ? "1" : "0");
                    if (sThisVal == 1) {
                        nbchecked++;
                    }
                });

                if (nbchecked == 0) {
                    alert("Attention, vous n'avez assigné aucun restaurant à votre restaurateur.");

                }
                

            });

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Créer un compte restaurateur"></asp:Label>
    <br />
    <asp:Label ID="lblNom" runat="server" Text="Nom : "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblPrenom" runat="server" Text="Prénom : "></asp:Label>
    <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
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
    <asp:Label ID="lblDDN" runat="server" Text="Date de naissance : "></asp:Label>
    <asp:TextBox ID="txtDDN" runat="server"></asp:TextBox> &nbsp;YYYY-MM-DD
    <br />
    <asp:Label ID="lblNumeroTel" runat="server" Text="Numéro de téléphone : "></asp:Label>
    <asp:TextBox ID="txtNumeroTel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblCourriel" runat="server" Text="Courriel : "></asp:Label>
    <asp:TextBox ID="txtCourriel" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="txtMotDePasse" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblRestaurants" runat="server" Text="Restaurant(s) : "></asp:Label>
    <asp:ObjectDataSource ID="odsRestaurant" runat="server" SelectMethod="GetRestaurantsAffichable" TypeName="GestionnaireLivraison.controleur.ControleurRestaurants">
        <SelectParameters>
            <asp:QueryStringParameter Name="id" QueryStringField="Id" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:CheckBoxList CssClass="chkboxRestaurant" ID="cblRestaurants" runat="server" DataValueField="Id" DataTextField="Nom" DataSourceID="odsRestaurant" OnDataBound="cblRestaurants_DataBound"></asp:CheckBoxList>
    <br />
    <asp:Button ID="btnCreerCompte" CssClass="creerCompte" runat="server" Text="Créer compte" OnClick="btnCreerCompte_Click" />
    <asp:HiddenField ID="hfSelectedResto" runat="server" />
</asp:Content>
