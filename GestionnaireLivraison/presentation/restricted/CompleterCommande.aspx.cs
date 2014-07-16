using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison.presentation
{
    public partial class CompleterCommande : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string commandeId = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                model.Commande commande = new model.Commande() { Id = Request.QueryString["Id"].ToObjectId() };
                commande.Select();

                SetCommandeInfo(commande);
                SetTimeListBox();
            }

        }

        private void SetTimeListBox()
        {
            List<string> heures = new List<string>();
            for (int i = 0; i < 24; i++)
            {
                heures.Add(i.ToString());
            }
            List<string> minutes = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                minutes.Add((i * 15).ToString());
            }
            lbHeure.DataSource = heures;
            lbHeure.DataBind();
            lbMinute.DataSource = minutes;
            lbMinute.DataBind();
        }

        private void SetCommandeInfo(model.Commande commande)
        {
            model.Client client = new model.Client(new model.Compte() {Id = commande.ClientId });
            client.Select();
            model.Adresse adresse = new model.Adresse() {Id = client.AdresseId };
            adresse.Select();
            hfDefaultAddressId.Value = adresse.Id.ToString();
            lblLivraisonNumeroRue.Text = adresse.NoRue;
            lblLivraisonNomRue.Text = adresse.NomRue;
            lblLivraisonCodePostal.Text = adresse.CodePostal;
        }

        protected void cbAdresseDefaut_CheckedChanged(object sender, EventArgs e)
        {
            vueAdresses.ActiveViewIndex = cbAdresseDefaut.Checked ? 0 : 1;
        }

        protected void lvAdresses_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "Unselect")
            {
                lvAdresses.SelectedIndex = -1;
            }
        }

        protected void btnAddAdresse_Click(object sender, EventArgs e)
        {
            model.Commande commande = new model.Commande() { Id = Request.QueryString["Id"].ToObjectId() };
            commande.Select();
            model.Adresse adresse = new model.Adresse() {CompteId = commande.ClientId, NoRue = txtNoRue.Text, NomRue = txtNomRue.Text, CodePostal = txtCodePostal.Text };
            adresse.Insert();
            lvAdresses.DataBind();
        }

        protected void btnTerminer_Click(object sender, EventArgs e)
        {
            model.Commande commande = new model.Commande() { Id = Request.QueryString["Id"].ToObjectId() };
            commande.Select();
            string adresseId = lvAdresses.SelectedIndex > -1 && !cbAdresseDefaut.Checked? lvAdresses.SelectedDataKey.Value.ToString(): hfDefaultAddressId.Value;
            commande.AdresseId = adresseId.ToObjectId();
            DateTime dateLivraison = DateTime.Parse(txtDate.Text + " " + lbHeure.SelectedItem.Text + ":" + lbMinute.SelectedItem.Text);
            commande.DateLivraison = dateLivraison;
            commande.Update();

            Response.Redirect("~/presentation/restricted/SommaireCommande.aspx?Id=" + commande.Id.ToString(), true);
        }
    }
}