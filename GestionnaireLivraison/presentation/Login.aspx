﻿<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GestionnaireLivraison.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblCourriel" runat="server" Text="Courriel : "></asp:Label>
    <asp:TextBox ID="txtCourriel" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtCourriel"></asp:RequiredFieldValidator>
    
    <br />
    <asp:Label ID="lblMotDePasse" runat="server" Text="Mot de passe : "></asp:Label>
    <asp:TextBox ID="txtMotDePasse" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"  ForeColor="Red" ControlToValidate="txtMotDePasse"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    <asp:CustomValidator ID="valCourrielLogin"  runat="server"  ErrorMessage="Le compte et/ou le mot de passe sont invalides" ControlToValidate="txtCourriel" ForeColor="Red"></asp:CustomValidator> 
    <asp:HyperLink ID="hlCreerCompte" runat="server" Text="Créer nouveau compte" NavigateUrl="~/presentation/Client.aspx"></asp:HyperLink>
    
</asp:Content>
