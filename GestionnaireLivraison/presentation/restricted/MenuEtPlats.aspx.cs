using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison.presentation
{
    public partial class MenuEtPlats : System.Web.UI.Page
    {
        private const string unsavedPlat = "unsavedPlat";

        protected void Page_Load(object sender, EventArgs e)
        {
            //string rId = Request.QueryString["RId"]; //nouveau menu
            string mId = Request.QueryString["MId"]; //modification menu            
            if (!IsPostBack)
            {
                if (Session[unsavedPlat] == null) Session[unsavedPlat] = new List<model.Plat>();
                if (mId != null)
                {
                    model.Menu menu = new model.Menu() { Id = mId.ToObjectId() };
                    menu.Select();

                    txtNomMenu.Text = menu.Nom;
                }
            }

        }

        protected void lnkAjoutPlat_Click(object sender, EventArgs e)
        {
            if (txtNomPlat.Text == "" || txtPrix.Text == "")
            {
                lblState.Text = "Pas de prix ou/et de nom entré!";
            }
            else
            {
                if (txtDescription.Text == "")
                {
                    lblState.Text = "Aucune description!";
                }
                else
                {
                    lblState.Text = "";
                }
                if (Request.QueryString["MId"] == null)
                {
                    model.Plat plat = new model.Plat() { Nom = txtNomPlat.Text, Prix = Double.Parse(txtPrix.Text), Description = txtDescription.Text };
                    ((List<model.Plat>)Session[unsavedPlat]).Add(plat);
                    lvUnsavePlats.DataBind();
                }
                else
                {
                    model.Plat plat = new model.Plat() { MenuId = Request.QueryString["MId"].ToObjectId(), Nom = txtNomPlat.Text, Prix = Double.Parse(txtPrix.Text), Description = txtDescription.Text };
                    plat.Insert();
                    lvPlat.DataBind();
                }
            }
        }

        protected void btnSaveAndReturn_Click(object sender, EventArgs e)
        {
            if (txtNomMenu.Text == "")
            {
                lblState.Text = "ATTENTION! Vous avez besoin d'un nom de menu !";
            }
            else
            {
                var resto = SaveMenu();
                Response.Redirect("~/presentation/restricted/AccueilRestaurateur.aspx?Id=" + resto.RestaurateurID.ToString(), true);
            }
        }

        protected void SaveAndNewMenu_Click(object sender, EventArgs e)
        {
            if (txtNomMenu.Text == "")
            {
                lblState.Text = "ATTENTION! Vous avez besoin d'un nom de menu !";
            }
            else
            {
                var resto = SaveMenu();
                Response.Redirect("~/presentation/restricted/MenuEtPlats.aspx?RId=" + resto.Id, true);
            }
        }


        private model.Restaurant SaveMenu()
        {
            string rId = Request.QueryString["RId"]; //nouveau menu
            string mId = Request.QueryString["MId"]; //modification menu
            model.Menu menu = new model.Menu();
            if (mId != null)
            {
                menu.Id = mId.ToObjectId();
                menu.Select();
            }
            else
            {
                menu.RestaurantId = rId.ToObjectId();
            }

            menu.Nom = txtNomMenu.Text;
            menu.Update();

            foreach (var plat in (List<model.Plat>)Session[unsavedPlat])
            {
                plat.MenuId = menu.Id;
                plat.Update();
            }

            ((List<model.Plat>)Session[unsavedPlat]).Clear();

            model.Restaurant resto = new model.Restaurant() { Id = menu.RestaurantId };
            resto.Select();
            return resto;
        }

        public static List<model.Plat> GetUnsavedPlat()
        {
            return (List<model.Plat>)HttpContext.Current.Session[unsavedPlat];
        }
    }
}