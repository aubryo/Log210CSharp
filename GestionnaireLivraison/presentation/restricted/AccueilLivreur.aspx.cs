using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.model;
using MongoDB.Bson;

namespace GestionnaireLivraison.presentation
{
    public partial class AccueilLivreur : System.Web.UI.Page
    {
        private string livreurID;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string id = Request.QueryString["Id"];
            livreurID = id;
            hiddenLivreurID.Value = livreurID;
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

        protected void lnkConfirmerLivraison_Click(object sender, EventArgs e)
        {
            model.Commande commande = new model.Commande() { Id = lvCommandes.SelectedValue.ToString().ToObjectId()  };
            commande.Select();
            commande.Statut = EnumCommandeStatut.Acceptee.ToString();
            commande.LivreurId = livreurID.ToObjectId();
            commande.Update();
            lvCommandes.DataBind();
            lvCommandesAcceptee.DataBind();
        }

    }
}