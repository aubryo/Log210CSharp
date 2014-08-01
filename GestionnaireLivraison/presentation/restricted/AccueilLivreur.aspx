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
            <asp:HiddenField runat="server" ID="hiddenLivreurID" Value='' />
        </div>
        <hr />
        <div>
            <h3>Livreur: <asp:Label ID="lblPrenom" Text="" runat="server" /> <asp:Label ID="lblNom" Text="" runat="server" /></h3>
        </div>
        <div>
            <p><strong>Votre adresse: </strong></p>
            <p id="adress-livreur">
                <asp:Label Name="lNumRue" ID="lblNumeroRue" Text="" runat="server" /> <asp:Label Name="lNomRue" ID="lblNomRue" Text="" runat="server" /><br />
                <asp:Label Name="lCodePostal" ID="lblCodePostal" Text="" runat="server" />
            </p>
        </div>
        <br />
        <ul class="nav nav-tabs" role="tablist">
          <li class="active"><a href="#listCommandes" role="tab" data-toggle="tab">Liste des commandes prêtes</a></li>
          <li><a href="#carnetAdresse" role="tab" data-toggle="tab">Carnet d'adresse</a></li>
        </ul>

        <div class="tab-content">
            <div id="listCommandes" class="tab-pane fade in active">
                <div class="col-xs-4">
                    <div>
                        <asp:ObjectDataSource ID="odsCommande" runat="server" SelectMethod="GetCommandesPrete" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                        </asp:ObjectDataSource>
                        <asp:ListView ID="lvCommandes" runat="server" DataSourceID="odsCommande" DataKeyNames="Id">
                                            <EmptyDataTemplate>
                                                <table id="Table1" runat="server" style="">
                                                    <tr>
                                                        <td>Aucune commande pour le moment.</td>
                                                    </tr>
                                                </table>
                                            </EmptyDataTemplate>
                                            <ItemTemplate>
                                                <asp:HiddenField runat="server" ID="hiddenID" Value='<%# Eval("Id") %>' />
                                                <tr style="">
                                                    <td class="hidden">
                                                        <asp:LinkButton ID="btnNoCommande" runat="server" Text='<%# Eval("NoCommande") %>' CommandName="Select"></asp:LinkButton>
                                                    </td>
                                                    <td class="hidden">
                                                        <asp:Label ID="DateCreationLabel" runat="server" Text='<%# Eval("DateCreation") %>' />
                                                    </td>
                                                    <td class="hidden">
                                                        <asp:Label ID="lblPrete" runat="server" Text='<%# Eval("Statut") %>'></asp:Label>
                                                    </td>
                                                    <td class="hidden">
                                                        <asp:Label ID="lblAdresseID" runat="server" Text='<%# Eval("AdresseId") %>'></asp:Label>
                                                    </td>
                                                    <td>
                                                    <asp:ObjectDataSource ID="odsAdresseIT" runat="server" SelectMethod="GetAdresse" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                                                        <SelectParameters>
                                                            <asp:ControlParameter ControlID="hiddenID" Name="Id" PropertyName="" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                        <asp:ListView ID="lvAdresseIT" runat="server" DataSourceID="odsAdresseIT" DataKeyNames="Id">
                                                        <EmptyDataTemplate>
                                                            <span>Aucune adresse pour cette commande.</span>
                                                        </EmptyDataTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label Name="singleAdress" ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), "", Eval("NomRue"), "", Eval("CodePostal")) %>'></asp:Label>
                                                        </ItemTemplate>
                                                        <LayoutTemplate>
                                                            <div id="itemPlaceholderContainer" runat="server" style="">
                                                                <span runat="server" id="itemPlaceholder" />
                                                                <asp:Label Name="singleAdress" ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), "", Eval("NomRue"), "", Eval("CodePostal")) %>'></asp:Label>
                                                            </div>
                                                            <div style="">
                                                            </div>
                                                        </LayoutTemplate>
                                                        <SelectedItemTemplate>
                                                            <asp:Label Name="singleAdress" ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), "", Eval("NomRue"), "", Eval("CodePostal")) %>'></asp:Label>
                                                        </SelectedItemTemplate>
                                                        </asp:ListView>
                                                    </td>
                                                    <td>
                                                        <asp:LinkButton ID="btnSelectionner" runat="server" Text="Sélectionner" CommandName="Select"></asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <LayoutTemplate>
                                                <table id="Table2" runat="server">
                                                    <tr id="Tr1" runat="server">
                                                        <td id="Td1" runat="server">
                                                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                                                <tr id="Tr2" runat="server" style="">
                                                                    <th class="hidden" id="Th1" runat="server">NoCommande</th>
                                                                    <th class="hidden" id="Th2" runat="server">DateCreation</th>
                                                                    <th class="hidden" id="Th3" runat="server">Prete</th>
                                                                    <th id="Th4" runat="server">Adresse</th>
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
                                                    <td class="hidden">
                                                        <asp:Label ID="NoCommandeLabel" runat="server" Text='<%# Eval("NoCommande") %>' />
                                                    </td>
                                                    <td class="hidden">
                                                        <asp:Label ID="DateCreationLabel" runat="server" Text='<%# Eval("DateCreation") %>' />
                                                    </td>
                                                    <td  class="hidden">
                                                        <asp:Label ID="lblPrete" runat="server" Text='<%# Eval("Statut") %>'></asp:Label>
                                                    </td>
                                                    <td class="hidden">
                                                        <asp:Label ID="lblAdresseID" runat="server" Text='<%# Eval("AdresseId") %>'></asp:Label>
                                                    </td>
                                                    <td>
                                                    <asp:ObjectDataSource ID="odsAdresseSI" runat="server" SelectMethod="GetAdresse" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                                                        <SelectParameters>
                                                            <asp:ControlParameter ControlID="lvCommandes" Name="Id" PropertyName="SelectedValue" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                        <asp:ListView ID="lvAdresseSI" runat="server" DataSourceID="odsAdresseSI" DataKeyNames="Id">
                                                        <EmptyDataTemplate>
                                                            <span>Aucune adresse pour cette commande.</span>
                                                        </EmptyDataTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label Name="selectedAdresse" ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), " ", Eval("NomRue"), " ", Eval("CodePostal")) %>'></asp:Label>
                                                        </ItemTemplate>
                                                        <LayoutTemplate>
                                                            <div id="itemPlaceholderContainer" runat="server" style="">
                                                                <span runat="server" id="itemPlaceholder" />
                                                                <asp:Label Name="singleAdress" ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), " ", Eval("NomRue"), " ", Eval("CodePostal")) %>'></asp:Label>
                                                            </div>
                                                            <div style="">
                                                            </div>
                                                        </LayoutTemplate>
                                                        <SelectedItemTemplate>
                                                            <asp:Label Name="singleAdress" ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), " ", Eval("NomRue"), " ", Eval("CodePostal")) %>'></asp:Label>
                                                        </SelectedItemTemplate>
                                                        </asp:ListView>
                                                       <asp:LinkButton ID="lnkConfirmerLivraison" runat="server" OnClick="lnkConfirmerLivraison_Click" CssClass="btn btn-sm btn-success"><span class="glyphicon glyphicon-ok"></span>&nbsp;Confirmer Livraison</asp:LinkButton>
                                                    </td>
                                                </tr>
                                            </SelectedItemTemplate>
                                        </asp:ListView>
                    </div>
                </div>
                <div class="col-xs-8">
                    <h4 class="text-center">Carte des livraisons</h4>
                    <div id="map_canvas"></div>
                </div>
            </div>
            <div id="carnetAdresse" class="tab-pane fade">
                <div class="col-xs-12">
                    <div>
                        <asp:ObjectDataSource ID="odsCommandeCarnet" runat="server" SelectMethod="GetCommandesAcceptee" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                        </asp:ObjectDataSource>
                        <asp:ListView ID="lvCommandesAcceptee" runat="server" DataSourceID="odsCommandeCarnet" DataKeyNames="Id">
                                            <EmptyDataTemplate>
                                                <table id="Table1" runat="server" style="">
                                                    <tr>
                                                        <td>Aucune commande acceptée pour le moment.</td>
                                                    </tr>
                                                </table>
                                            </EmptyDataTemplate>
                                            <ItemTemplate>
                                                <asp:HiddenField runat="server" ID="hiddenID" Value='<%# Eval("Id") %>' />
                                                <tr style="">
                                                    <td>
                                                    <asp:ObjectDataSource ID="odsAdresseITAcceptee" runat="server" SelectMethod="GetAdresse" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                                                        <SelectParameters>
                                                            <asp:ControlParameter ControlID="hiddenID" Name="Id" PropertyName="" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                        <asp:ListView ID="lvAdresseIT" runat="server" DataSourceID="odsAdresseITAcceptee" DataKeyNames="Id">
                                                        <EmptyDataTemplate>
                                                            <span>Aucune adresse pour cette commande.</span>
                                                        </EmptyDataTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), "", Eval("NomRue"), "", Eval("CodePostal")) %>'></asp:Label>
                                                        </ItemTemplate>
                                                        <LayoutTemplate>
                                                            <div id="itemPlaceholderContainer" runat="server" style="">
                                                                <span runat="server" id="itemPlaceholder" />
                                                                <asp:Label ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), "", Eval("NomRue"), "", Eval("CodePostal")) %>'></asp:Label>
                                                            </div>
                                                            <div style="">
                                                            </div>
                                                        </LayoutTemplate>
                                                        <SelectedItemTemplate>
                                                            <asp:Label ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), "", Eval("NomRue"), "", Eval("CodePostal")) %>'></asp:Label>
                                                        </SelectedItemTemplate>
                                                        </asp:ListView>
                                                    </td>
                                                </tr>
                                            </ItemTemplate>
                                            <LayoutTemplate>
                                                <table id="Table2" runat="server">
                                                    <tr id="Tr1" runat="server">
                                                        <td id="Td1" runat="server">
                                                            <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                                                <tr id="Tr2" runat="server" style="">
                                                                    <th id="thAdresseCarnet" runat="server">Adresse</th>
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
                                                    <asp:ObjectDataSource ID="odsAdresseSIAcceptee" runat="server" SelectMethod="GetAdresseAcceptee" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                                                        <SelectParameters>
                                                            <asp:ControlParameter ControlID="lvCommandesAcceptee" Name="Id" PropertyName="SelectedValue" Type="String" />
                                                        </SelectParameters>
                                                    </asp:ObjectDataSource>
                                                        <asp:ListView ID="lvAdresseSI" runat="server" DataSourceID="odsAdresseSIAcceptee" DataKeyNames="Id">
                                                        <EmptyDataTemplate>
                                                            <span>Aucune adresse pour cette commande.</span>
                                                        </EmptyDataTemplate>
                                                        <ItemTemplate>
                                                            <asp:Label Name="selectedAdresse" ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), " ", Eval("NomRue"), " ", Eval("CodePostal")) %>'></asp:Label>
                                                        </ItemTemplate>
                                                        <LayoutTemplate>
                                                            <div id="itemPlaceholderContainer" runat="server" style="">
                                                                <span runat="server" id="itemPlaceholder" />
                                                                <asp:Label ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), " ", Eval("NomRue"), " ", Eval("CodePostal")) %>'></asp:Label>
                                                            </div>
                                                            <div style="">
                                                            </div>
                                                        </LayoutTemplate>
                                                        <SelectedItemTemplate>
                                                            <asp:Label ID="adresseString" runat="server" Text='<%# string.Concat(Eval("NoRue"), " ", Eval("NomRue"), " ", Eval("CodePostal")) %>'></asp:Label>
                                                        </SelectedItemTemplate>
                                                        </asp:ListView>
                                                    </td>
                                                </tr>
                                            </SelectedItemTemplate>
                                        </asp:ListView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</div>
</asp:Content>
