<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="GestionnaireLivraison.presentation.CreationCompte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Créer un compte"></asp:Label>
    <br />
    <asp:Label ID="lblNom" runat="server" Text="Nom : "></asp:Label>
    <asp:TextBox ID="txtNom" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNom" runat="server" Text=""></asp:Label>
    <asp:RequiredFieldValidator ID="validEmptyNom" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNom"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblPrenom" runat="server" Text="Prénom : "></asp:Label>
    <asp:TextBox ID="txtPrenom" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfPrenom" runat="server" Text=""></asp:Label>
    <asp:RequiredFieldValidator ID="validEmptyPrenom" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtPrenom"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblNumeroRue" runat="server" Text="Numéro de rue : "></asp:Label>
    <asp:TextBox ID="txtNumeroRue" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNumeroRue" runat="server" Text=""></asp:Label>
    <asp:RequiredFieldValidator ID="validEmptyNumeroRue" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNumeroRue"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblNomRue" runat="server" Text="Rue : "></asp:Label>
    <asp:TextBox ID="txtNomRue" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNomRue" runat="server" Text=""></asp:Label>
    <asp:RequiredFieldValidator ID="validEmptyNomRue" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNomRue"></asp:RequiredFieldValidator>
    <br />
    <asp:Label ID="lblCodePostal" runat="server" Text="Code postal : "></asp:Label>
    <asp:TextBox ID="txtCodePostal" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfCodePostal" runat="server" Text=""></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtCodePostal"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="validationCodePostal" runat="server" ErrorMessage="Format invalide (ex: H2J3C4)" ControlToValidate="txtCodePostal" ForeColor="Red"  ValidationExpression="^[a-zA-Z]{1}[0-9]{1}[a-zA-Z]{1}(\-| |){1}[0-9]{1}[a-zA-Z]{1}[0-9]{1}$"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblDDN" runat="server" Text="Date de naissance : "></asp:Label>
    <asp:TextBox ID="txtDDN" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfDDN" runat="server" Text=""></asp:Label> &nbsp;YYYY-MM-DD
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtDDN"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Format invalide" ForeColor="Red"  ControlToValidate="txtDDN" ValidationExpression="^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblNumeroTel" runat="server" Text="Numéro de téléphone : "></asp:Label>
    <asp:TextBox ID="txtNumeroTel" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfNumeroTel" runat="server" Text=""></asp:Label>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtNumeroTel"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Format invalide (ex: 514-123-3456)" ForeColor="Red"  ControlToValidate="txtNumeroTel" ValidationExpression="^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="lblCourriel" runat="server" Text="Courriel : "></asp:Label>
    <asp:TextBox ID="txtCourriel" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfCourriel" runat="server" Text=""></asp:Label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtCourriel"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Format invalide (ex: exemple@exemple.com)" ForeColor="Red"  ControlToValidate="txtCourriel" ValidationExpression="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$"></asp:RegularExpressionValidator>
    <asp:CustomValidator ID="valCourrielUnique" runat="server" ErrorMessage="Un compte est déjà associé à ce courriel" ControlToValidate="txtCourriel" ForeColor="Red"></asp:CustomValidator>
     <br />
    <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="txtMotDePasse" runat="server"></asp:TextBox>
    <asp:Label ID="lblConfMotDePasse" runat="server" Text=""></asp:Label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtMotDePasse"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btnCreerCompte" runat="server" Text="Créer compte" OnClick="btnCreerCompte_Click" />
</asp:Content>
