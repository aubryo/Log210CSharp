<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="AccueilLivreur.aspx.cs" Inherits="GestionnaireLivraison.presentation.AccueilLivreur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
<style type="text/css">
    #map_canvas { 
        height: 500px;
        width: 100%;
    }
</style>
<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?en&amp;key=AIzaSyAW7-cqoAPUg_cMrhHlPayjhGAe3p9lRZA&amp;sensor=false"></script>
<script src="../../../Scripts/google-map.js" language="javascript" type="text/javascript"></script>
<div class="container-fluid">
<div class="row">
    <div class="col-xs-12 col-md-6 col-md-offset-3">
        <div>
            <h1>Livraison des commandes</h1>
        </div>
        <hr />
        <div>
            <h3>Livreur: <asp:Label ID="lblPrenom" Text="" runat="server" /> <asp:Label ID="lblNom" Text="" runat="server" /></h3>
        </div>
        <div>
            <p><strong>Votre adresse: </strong></p>
            <p id="adress-livreur">
                <asp:Label ID="lblNumeroRue" Text="" runat="server" /> <asp:Label ID="lblNomRue" Text="" runat="server" /><br />
                <asp:Label ID="lblCodePostal" Text="" runat="server" />
            </p>
        </div>
        <br />
        <div class="col-xs-4">
            <h4>Liste des commandes prêtes</h4>
        </div>
        <div class="col-xs-8">
            <h4 class="text-center">Carte des livraisons</h4>
            <div id="map_canvas"></div>
        </div>
    </div>
</div>
</div>
</asp:Content>
