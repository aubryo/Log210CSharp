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
        protected void Page_Load(object sender, EventArgs e)
        {
            string rId = Request.QueryString["RId"]; //nouveau menu
            string mId = Request.QueryString["MId"]; //modification menu
            if (!IsPostBack)
            {
                if (mId != null)
                {
                    model.Menu menu = new model.Menu() { Id = mId.ToObjectId() };
                    menu.Select();

                    txtNomMenu.Text = menu.Nom;

                    lvPlat.DataSource = menu.GetPlats();
                    lvPlat.DataBind();
                }
            }

        }

        protected void btnAjoutPlat_Click(object sender, EventArgs e)
        {
            int cnt = lvPlat.Items.Count();
            var plat = new ListViewDataItem(cnt, cnt);
            if (txtDescription.Text == ""&&txtNomPlat.Text!=""&&txtPrix.Text!="")
            {
                lblState.Text = "Aucune description!";
                lblState.ForeColor = System.Drawing.Color.Red;
            
            
            plat.DataItem = new model.Plat(){Id = MongoDB.Bson.ObjectId.Empty ,Nom = txtNomPlat.Text, Prix = Double.Parse(txtPrix.Text), Description = txtDescription.Text};
            lvPlat.Items.Add(plat);
            }
            else if(txtNomPlat.Text==""||txtPrix.Text=="")
                {
                    lblState.Text = "Pas de prix ou/et de nom entré!";
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
            if(txtNomMenu.Text=="")
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
            }else{
                menu.RestaurantId = rId.ToObjectId();
            }

            menu.Nom = txtNomMenu.Text;
            menu.Update();

            foreach (var item in lvPlat.Items)
            {
                model.Plat plat = (model.Plat)item.DataItem;
                plat.Update();
            }

            model.Restaurant resto = new model.Restaurant() { Id = menu.RestaurantId };
            resto.Select();
            return resto;
        }
    }
}