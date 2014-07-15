using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.presentation
{
    public partial class AccueilClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                Client client = new Client(new Compte() { Id = id.ToObjectId() });
                client.Select();
                SetClientData(client);
            }

        }

        private void SetClientData(Client client)
        {
            Adresse adresse = new Adresse() { Id = client.AdresseId };
            adresse.Select();

            lblClientNom.Text = client.Nom;
            lblClientPrenom.Text = client.Prenom;
            lblClientNumeroRue.Text = adresse.NoRue;
            lblClientNomRue.Text = adresse.NomRue;
            lblClientCodePostal.Text = adresse.CodePostal;
            lblClientDDN.Text = client.DateNaissance.ToShortDateString();
            lblClientNumeroTel.Text = client.NoTelephone;
            lblClientCourriel.Text = client.Courriel;
        }

        protected void btnCommander_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/presentation/restricted/Commande.aspx?Id=" + Request.QueryString["Id"], true);
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/presentation/Client.aspx?Id=" + Request.QueryString["Id"], true);
        }
    }
}