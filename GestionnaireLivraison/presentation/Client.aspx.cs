using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison_LOG210.presentation
{
    public partial class CreationCompte : System.Web.UI.Page
    {
        private bool isNouveauCompte;

        private string textbtnCreation = "Créer compte";
        private string textbtnModification = "Modifier compte";
        private string textbtnConfirmation = "Accepter le(s) changement(s)";

        protected void Page_Load(object sender, EventArgs e)
        {
            //TODO
            //Creer un nouveau compte
            //set isNouveauCompte selon authentifier
            //non authetifier == creation de compte
            //authentifier == modification de comte
            //loader l'info
        }

        protected void btnCreerCompte_Click(object sender, EventArgs e)
        {
            if (btnCreerCompte.Text.Equals(textbtnCreation) || btnCreerCompte.Text.Equals(textbtnModification))
            {
                etatCreation(false);
            }
            else
            {
                //TODO compte insert ou update
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
            //TODO ecrire l'info du compte dans les textbox et les labelConf
        }
    }
}