using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.presentation
{
    public partial class CreationCompte : System.Web.UI.Page
    {
        private bool isNouveauCompte;

        private string textbtnCreation = "Créer compte";
        private string textbtnModification = "Modifier compte";
        private string textbtnConfirmation = "Accepter le(s) changement(s)";

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            isNouveauCompte = id == null;
            if (!IsPostBack)
            {
                if (!isNouveauCompte)
                {
                    Client client = new Client(new Compte() { Id = id.ToObjectId() });
                    client.Select();
                    SetClientData(client);
                    etatModification();
                }
                else
                {
                    etatCreation(true);
                }
            }
        }

        private void SetClientData(Client client)
        {
            Adresse adresse = new Adresse() { Id = client.AdresseId };
            adresse.Select();

            txtNom.Text = client.Nom;
            txtPrenom.Text = client.Prenom;
            txtNumeroRue.Text = adresse.NoRue;
            txtNomRue.Text = adresse.NomRue;
            txtCodePostal.Text = adresse.CodePostal;
            txtDDN.Text = client.DateNaissance.ToShortDateString();
            txtNumeroTel.Text = client.NoTelephone;
            txtCourriel.Text = client.Courriel;
            txtMotDePasse.Text = client.MotDePasse;
        }

        private Client SaveClient()
        {
            Client client = new Client(new Compte());
            Adresse adresse = new Adresse();
            if (!isNouveauCompte)
            {
                client.Id = Request.QueryString["Id"].ToObjectId();
                client.Select();
                adresse.Id = client.AdresseId;
            }
            client.Nom = txtNom.Text;
            client.Prenom = txtPrenom.Text;
            client.DateNaissance = DateTime.Parse(txtDDN.Text);
            client.NoTelephone = txtNumeroTel.Text;
            client.Courriel = txtCourriel.Text;
            client.MotDePasse = txtMotDePasse.Text;
            client.Update();

            adresse.CompteId = client.Id;
            adresse.NoRue = txtNumeroRue.Text;
            adresse.NomRue = txtNomRue.Text;
            adresse.CodePostal = txtCodePostal.Text;
            adresse.Update();

            client.AdresseId = adresse.Id;
            client.Update();

            return client;
        }

        protected void btnCreerCompte_Click(object sender, EventArgs e)
        {
            //TODO faire la validation pour le form au complet
            if (model.GestionnaireLivraison.IsCourrielUnique(txtCourriel.Text))
            {
                valCourrielUnique.IsValid = true;
                if (btnCreerCompte.Text.Equals(textbtnCreation) || btnCreerCompte.Text.Equals(textbtnModification))
                {
                    setInfo();
                    etatCreation(false);
                }
                else
                {
                    Client client = SaveClient();
                    Response.Redirect("~/presentation/restricted/AccueilClient.aspx?Id=" + client.Id.ToString(), true);
                }
            }
            else
            {
                valCourrielUnique.IsValid = false;
            }

        }

        private void etatCreation(bool isCreating)
        {
            lblConfNom.Visible = !isCreating;
            lblConfPrenom.Visible = !isCreating;
            lblConfNumeroRue.Visible = !isCreating;
            lblConfNomRue.Visible = !isCreating;
            lblConfCodePostal.Visible = !isCreating;
            lblConfDDN.Visible = !isCreating;
            lblConfNumeroTel.Visible = !isCreating;
            lblConfCourriel.Visible = !isCreating;
            lblConfMotDePasse.Visible = !isCreating;

            txtNom.Visible = isCreating;
            txtPrenom.Visible = isCreating;
            txtNumeroRue.Visible = isCreating;
            txtNomRue.Visible = isCreating;
            txtCodePostal.Visible = isCreating;
            txtDDN.Visible = isCreating;
            txtNumeroTel.Visible = isCreating;
            txtCourriel.Visible = isCreating;
            txtMotDePasse.Visible = isCreating;

            if (isCreating)
            {
                btnCreerCompte.Text = textbtnCreation;
            }
            else
            {
                btnCreerCompte.Text = textbtnConfirmation;
            }
        }

        private void etatModification()
        {
            lblConfNom.Visible = false;
            lblConfPrenom.Visible = false;
            lblConfNumeroRue.Visible = false;
            lblConfNomRue.Visible = false;
            lblConfCodePostal.Visible = false;
            lblConfDDN.Visible = false;
            lblConfNumeroTel.Visible = false;
            lblConfCourriel.Visible = false;
            lblConfMotDePasse.Visible = false;

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

        private void setInfo()
        {
            lblConfNom.Text = txtNom.Text;
            lblConfPrenom.Text = txtPrenom.Text;
            lblConfNumeroRue.Text = txtNumeroRue.Text;
            lblConfNomRue.Text = txtNomRue.Text;
            lblConfCodePostal.Text = txtCodePostal.Text;
            lblConfDDN.Text = txtDDN.Text;
            lblConfNumeroTel.Text = txtNumeroTel.Text;
            lblConfCourriel.Text = txtCourriel.Text;
            lblConfMotDePasse.Text = txtMotDePasse.Text;
        }
    }
}