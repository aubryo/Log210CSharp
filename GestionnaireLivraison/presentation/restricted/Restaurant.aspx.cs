using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;

namespace GestionnaireLivraison.presentation
{
    public partial class Restaurant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                if (id != null)
                {
                    model.Restaurant resto = new model.Restaurant() { Id = id.ToObjectId() };
                    resto.Select();
                    SetRestaurantData(resto);
                }
            }
        }

        private void SetRestaurantData(model.Restaurant resto)
        {
            txtNom.Text = resto.Nom;
            txtNumeroTel.Text = resto.NoTelephone;
            txtNumeroRue.Text = resto.NoRue;
            txtNomRue.Text = resto.NomRue;
            txtCodePostal.Text = resto.CodePostal;
            txtDescription.Text = resto.Description;
            txtSiteWeb.Text = resto.Website;
            txtUrlBanniere.Text = resto.Url;

        }

        protected void btnSauvegarder_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            model.Restaurant resto = new model.Restaurant();
            if (id != null)
            {
                resto.Id = id.ToObjectId();
                resto.Select();
            }

            resto.Nom = txtNom.Text;
            resto.NoTelephone = txtNumeroTel.Text;
            resto.NoRue = txtNumeroRue.Text;
            resto.NomRue = txtNomRue.Text;
            resto.CodePostal = txtCodePostal.Text;
            resto.Description = txtDescription.Text;
            resto.Website = txtSiteWeb.Text;
            resto.Url = txtUrlBanniere.Text;

            resto.RestaurateurID = rbRestaurateur.SelectedValue.ToObjectId();

            resto.Update();

            Response.Redirect("~/presentation/restricted/AccueilEntrepreneur.aspx", true);
        }

        protected void rbRestaurateur_DataBound(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            if (id != null)
            {
                model.Restaurant resto = new model.Restaurant() { Id = id.ToObjectId() };
                resto.Select();
                rbRestaurateur.Items.FindByValue(resto.RestaurateurID.ToString()).Selected = true;
            }
        }
    }
}