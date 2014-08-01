<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="GestionnaireLivraison.presentation.Restaurant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">    
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
    <script type="text/javascript">

        $(document).ready(function () {


            $(".btnCreerRestaurant").click(function () {
                var btn = $("[name=aucunRestaurateur] input");
                var rdo = btn.first();
                if (btn.first().is(':checked')) {
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
    <asp:TextBox ID="txtNom" CssClass="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="validEmptyNom" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNom"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblNumeroTel" runat="server" Text="Numéro de téléphone : "></asp:Label>
    <asp:TextBox ID="txtNumeroTel" CssClass="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNumeroTel"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Format invalide (ex: 514-123-3456)" ForeColor="Red"  ControlToValidate="txtNumeroTel" ValidationExpression="^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"></asp:RegularExpressionValidator>    
    <br />
    <asp:Label ID="lblNumeroRue" runat="server" Text="Numéro de rue : "></asp:Label>
    <asp:TextBox ID="txtNumeroRue" CssClass="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="validEmptyNumeroRue" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNumeroRue"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblNomRue" runat="server" Text="Rue : "></asp:Label>
    <asp:TextBox ID="txtNomRue" CssClass="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="validEmptyNomRue" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNomRue"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblCodePostal" runat="server" Text="Code postal : "></asp:Label>
    <asp:TextBox ID="txtCodePostal" CssClass="form-control" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtCodePostal"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="validationCodePostal" runat="server" ErrorMessage="Format invalide (ex: H2J3C4)" ControlToValidate="txtCodePostal" ForeColor="Red"  ValidationExpression="^[a-zA-Z]{1}[0-9]{1}[a-zA-Z]{1}(\-| |){1}[0-9]{1}[a-zA-Z]{1}[0-9]{1}$"></asp:RegularExpressionValidator>   
    <br />
    <asp:ObjectDataSource ID="odsRestaurateur" runat="server" SelectMethod="GetRestaurateurs" TypeName="GestionnaireLivraison.controleur.ControleurRestaurateurs"></asp:ObjectDataSource>
    <asp:Label ID="lblRestaurateur" runat="server" Text="Restaurateur : "></asp:Label>
    <asp:RadioButtonList ID="rbRestaurateur" CssClass="rbRestaurateur" runat="server" DataSourceID="odsRestaurateur" DataTextField="Nom" DataValueField="Id" OnDataBound="rbRestaurateur_DataBound" AppendDataBoundItems="true">
        <asp:ListItem name="aucunRestaurateur" Value="000000000000000000000000" Text="Aucun"></asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:Label ID="lblDescription" runat="server" Text="Description : "></asp:Label>
    <asp:TextBox ID="txtDescription" CssClass="form-control" runat="server"></asp:TextBox>
    <br />    
    <asp:Label ID="lblSiteWeb" runat="server" Text="Site web : "></asp:Label>
    <asp:TextBox ID="txtSiteWeb" CssClass="form-control" runat="server"></asp:TextBox>
    <br />    
    <asp:Label ID="lblUrlBanniere" runat="server" Text="Url Banniere : "></asp:Label>
    <asp:TextBox ID="txtUrlBanniere" CssClass="form-control" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSauvegarder" runat="server" Text="Sauvegarder" CssClass="btnCreerRestaurant" OnClick="btnSauvegarder_Click"/>
</asp:Content>
