using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.controleur;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.presentation.restricted
{
    public partial class SommaireCommande : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string commandeId = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                model.Commande commande = new model.Commande() { Id = Request.QueryString["Id"].ToObjectId() };
                commande.Select();

                lblNoCommande.Text = commande.NoCommande;
            }
        }

        protected void hlRetourAccueil_Click(object sender, EventArgs e)
        {
                model.Commande commande = new model.Commande() { Id = Request.QueryString["Id"].ToObjectId() };
                commande.Select();
                var compte = new Compte() { Id = commande.ClientId };
                compte.Select();
                Response.Redirect(ControleurLogin.GetAcceuilPage(compte), true);
        }
    }
}