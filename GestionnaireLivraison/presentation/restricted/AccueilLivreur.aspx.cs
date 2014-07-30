using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison.presentation
{
    public partial class AccueilLivreur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                model.Livreur livreur = new model.Livreur(new model.Compte() { Id = id.ToObjectId() });
                livreur.Select();
                SetLivreurData(livreur);

            }
        }

        private void SetLivreurData(model.Livreur livreur) 
        {
            model.Adresse adresse = new model.Adresse() { Id = livreur.AdresseId };
            adresse.Select();

            lblPrenom.Text = livreur.Prenom;
            lblNom.Text = livreur.Nom;

            lblCodePostal.Text = adresse.CodePostal;
            lblNomRue.Text = adresse.NomRue;
            lblNumeroRue.Text = adresse.NoRue;
        }

    }
}