<%@ Page Title="" Language="C#" MasterPageFile="~/presentation/Site1.Master" AutoEventWireup="true" CodeBehind="CompleterCommande.aspx.cs" Inherits="GestionnaireLivraison.presentation.CompleterCommande" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblTitre" runat="server" Text="Passer une commande"></asp:Label>
    <br />
    <asp:Label ID="lblSommaire" runat="server" Text="Sommaire"></asp:Label><br />
    <asp:ObjectDataSource ID="odsLigneCommandes" runat="server" SelectMethod="GetLigneCommandes" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
        <SelectParameters>
            <asp:QueryStringParameter Name="commandeId" QueryStringField="Id" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <asp:ListView ID="lvLigneCommande" runat="server" DataSourceID="odsLigneCommandes">
        <ItemTemplate>
            <tr style="">
                <td>
                    <asp:Label ID="PlatIdLabel" runat="server" Text='<%# Eval("PlatId") %>' />
                </td>
                <td>
                    <asp:Label ID="quantiteLabel" runat="server" Text='<%# Eval("quantite") %>' />
                </td>
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                            <tr runat="server" style="">
                                <th runat="server">PlatId</th>
                                <th runat="server">quantite</th>
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style=""></td>
                </tr>
            </table>
        </LayoutTemplate>
    </asp:ListView>
    <br />
    <asp:CheckBox ID="cbAdresseDefaut" runat="server" Text="Adresse par défaut" Checked="true" OnCheckedChanged="cbAdresseDefaut_CheckedChanged" AutoPostBack="true" />
    <div id="adresseSelectionner">
        <asp:MultiView ID="vueAdresses" runat="server" ActiveViewIndex="0">
            <asp:View ID="tabDefault" runat="server">
                <asp:HiddenField ID="hfDefaultAddressId" runat="server" />
                <asp:Label ID="lblNumeroRue" runat="server" Text="Numéro de rue : "></asp:Label>
                <asp:Label ID="lblLivraisonNumeroRue" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblNomRue" runat="server" Text="Rue : "></asp:Label>
                <asp:Label ID="lblLivraisonNomRue" runat="server" Text=""></asp:Label>
                <br />
                <asp:Label ID="lblCodePostal" runat="server" Text="Code postal : "></asp:Label>
                <asp:Label ID="lblLivraisonCodePostal" runat="server" Text=""></asp:Label>
                <br />
            </asp:View>
            <asp:View ID="tabSelection" runat="server">
                <asp:ObjectDataSource ID="odsAdresses" runat="server" SelectMethod="GetAdresses" TypeName="GestionnaireLivraison.controleur.ControleurCommandes">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="commandeId" QueryStringField="Id" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:ListView ID="lvAdresses" runat="server" DataKeyNames="Id" DataSourceID="odsAdresses">
                    <EmptyDataTemplate>
                        <table runat="server" style="">
                            <tr>
                                <td>No data was returned.</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <ItemTemplate>
                        <tr style="">
                            <td>
                                <asp:LinkButton runat="server" ID="btnSelection" Text="Selectionner" CommandName="Select" />
                            </td>
                            <td>
                                <asp:Label ID="NoRueLabel" runat="server" Text='<%# Eval("NoRue") %>' />
                            </td>
                            <td>
                                <asp:Label ID="NomRueLabel" runat="server" Text='<%# Eval("NomRue") %>' />
                            </td>
                            <td>
                                <asp:Label ID="CodePostalLabel" runat="server" Text='<%# Eval("CodePostal") %>' />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table runat="server">
                            <tr runat="server">
                                <td runat="server">
                                    <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                                        <tr runat="server" style="">
                                            <th runat="server"></th>
                                            <th runat="server"></th>
                                            <th runat="server"></th>
                                            <th runat="server"></th>
                                        </tr>
                                        <tr id="itemPlaceholder" runat="server">
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr runat="server">
                                <td runat="server" style=""></td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <SelectedItemTemplate>
                        <tr style="">
                            <td>
                                <asp:CheckBox ID="CheckBox1" runat="server" Checked="true" Enabled="false"/>
                            </td>
                            <td>
                                <asp:Label ID="NoRueLabel" runat="server" Text='<%# Eval("NoRue") %>' />
                            </td>
                            <td>
                                <asp:Label ID="NomRueLabel" runat="server" Text='<%# Eval("NomRue") %>' />
                            </td>
                            <td>
                                <asp:Label ID="CodePostalLabel" runat="server" Text='<%# Eval("CodePostal") %>' />
                            </td>
                        </tr>
                    </SelectedItemTemplate>
                </asp:ListView>

                <asp:Label ID="lblNumeroRueAjout" runat="server" Text="Numéro de rue :"></asp:Label><asp:TextBox ID="txtNoRue" runat="server"></asp:TextBox>
                <asp:Label ID="lblNomRueAjout" runat="server" Text="Rue : "></asp:Label><asp:TextBox ID="txtNomRue" runat="server"></asp:TextBox>
                <asp:Label ID="lblCodePostalAjout" runat="server" Text="CP : "></asp:Label><asp:TextBox ID="txtCodePostal" runat="server"></asp:TextBox>
                <asp:Button ID="btnAddAdresse" runat="server" Text="Ajouter l'adresse" OnClick="btnAddAdresse_Click" />
            </asp:View>
        </asp:MultiView>
    </div>
    <asp:Label ID="lblDate" runat="server" Text="Date : "></asp:Label>
    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox> YYYY-MM-DD
    <br />
    <asp:Label ID="lblHeure" runat="server" Text="Heure : "></asp:Label>
    <asp:ListBox ID="lbHeure" runat="server"></asp:ListBox>:<asp:ListBox ID="lbMinute" runat="server"></asp:ListBox>
    <br />
    <asp:Button ID="btnTerminer" runat="server" Text="Terminer la commande et envoyer" OnClick="btnTerminer_Click" />
</asp:Content>
