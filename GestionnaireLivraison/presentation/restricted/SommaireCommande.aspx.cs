using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                hlRetourAccueil.NavigateUrl = "~/presentation/restricted/AccueilClient.aspx.cs?Id=" + commande.ClientId;
            }
        }
    }
}