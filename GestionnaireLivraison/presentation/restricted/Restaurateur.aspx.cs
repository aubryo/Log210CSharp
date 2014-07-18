using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.controleur;
using MongoDB.Bson;

namespace GestionnaireLivraison.presentation
{
    public partial class Restaurateur : System.Web.UI.Page
    {
        private string textbtnCreation = "Créer compte";
        private string textbtnModification = "Modifier compte";

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                if (id != null)
                {
                    model.Restaurateur restaurateur = new model.Restaurateur(new model.Compte() { Id = id.ToObjectId() });
                    restaurateur.Select();
                    SetClientData(restaurateur);
                    etatModification();
                }
                else
                {
                    etatCreation();
                }
            }
        }

        private void etatCreation()
        {
            txtNom.Visible = true;
            txtPrenom.Visible = true;
            txtNumeroRue.Visible = true;
            txtNomRue.Visible = true;
            txtCodePostal.Visible = true;
            txtDDN.Visible = true;
            txtNumeroTel.Visible = true;
            txtCourriel.Visible = true;
            txtMotDePasse.Visible = true;

            btnCreerCompte.Text = textbtnCreation;
        }

        private void etatModification()
        {
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtNumeroRue.Visible = true;
            txtNomRue.Visible = true;
            txtCodePostal.Visible = true;
            txtDDN.Enabled = false;
            txtNumeroTel.Visible = true;
            txtCourriel.Enabled = false;
            txtMotDePasse.Visible = true;

            btnCreerCompte.Text = textbtnModification;
        }

        private void SetClientData(model.Restaurateur restaurateur)
        {
            model.Adresse adresse = new model.Adresse() { Id = restaurateur.AdresseId };
            adresse.Select();

            txtNom.Text = restaurateur.Nom;
            txtPrenom.Text = restaurateur.Prenom;
            txtNumeroRue.Text = adresse.NoRue;
            txtNomRue.Text = adresse.NomRue;
            txtCodePostal.Text = adresse.CodePostal;
            txtDDN.Text = restaurateur.DateNaissance.ToShortDateString();
            txtNumeroTel.Text = restaurateur.NoTelephone;
            txtCourriel.Text = restaurateur.Courriel;
            txtMotDePasse.Text = restaurateur.MotDePasse;
            
            hfSelectedResto.Value = "";
            foreach (var resto in restaurateur.GetRestaurants())
            {
                hfSelectedResto.Value += resto.Id.ToString() + ",";
            }
        }

        protected void btnCreerCompte_Click(object sender, EventArgs e)
        {
            //TODO faire la validation pour le form au complet
            if (model.GestionnaireLivraison.IsCourrielUnique(txtCourriel.Text))
            {
                valCourrielUnique.IsValid = true;
                model.Restaurateur restaurateur = ControleurRestaurateurs.ajouterRestaurateur();
                model.Adresse adresse = new model.Adresse();
                string id = Request.QueryString["Id"];
                if (id != null)
                {
                    restaurateur.Id = id.ToObjectId();
                    restaurateur.Select();
                    adresse.Id = restaurateur.AdresseId;
                }
                restaurateur.Nom = txtNom.Text;
                restaurateur.Prenom = txtPrenom.Text;
                restaurateur.DateNaissance = DateTime.Parse(txtDDN.Text);
                restaurateur.NoTelephone = txtNumeroTel.Text;
                restaurateur.Courriel = txtCourriel.Text;
                restaurateur.MotDePasse = txtMotDePasse.Text;
                restaurateur.Update();

                adresse.CompteId = restaurateur.Id;
                adresse.NoRue = txtNumeroRue.Text;
                adresse.NomRue = txtNomRue.Text;
                adresse.CodePostal = txtCodePostal.Text;
                adresse.Update();

                restaurateur.AdresseId = adresse.Id;
                restaurateur.Update();

                foreach (var resto in restaurateur.GetRestaurants())
                {
                    resto.RestaurateurID = ObjectId.Empty;
                    resto.Update();
                }

                foreach (ListItem item in cblRestaurants.Items)
                {
                    if (item.Selected)
                    {
                        model.Restaurant resto = new model.Restaurant() { Id = item.Value.ToObjectId() };
                        resto.Select();
                        resto.RestaurateurID = restaurateur.Id;
                        resto.Update();
                    }
                }

                Response.Redirect("~/presentation/restricted/AccueilEntrepreneur.aspx", true);
            }
            else
            {
                valCourrielUnique.IsValid = false;
            }
        }

        protected void cblRestaurants_DataBound(object sender, EventArgs e)
        {
            string[] restoIds = hfSelectedResto.Value.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var id in restoIds)
            {
                var item = cblRestaurants.Items.FindByValue(id);
                if (item != null) item.Selected = true;
            }
        }
    }
}