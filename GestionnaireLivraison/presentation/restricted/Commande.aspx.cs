using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison.presentation
{
    public partial class Commande : System.Web.UI.Page
    {
        private const string unsavedLigneCommande = "unsavedLigneCommande";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session[unsavedLigneCommande] == null) Session[unsavedLigneCommande] = new List<model.LigneCommande>();
            }

        }

        protected void lvPlat_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "AjouterLigneCommande")
            {
                ListViewDataItem item = (ListViewDataItem)e.Item;
                string id = (item.FindControl("hfId") as HiddenField).Value;
                TextBox txtqty = item.FindControl("txtQty") as TextBox;
                int qty = Int32.Parse(txtqty.Text);
                txtqty.Text = "";
                model.LigneCommande ln = new model.LigneCommande() { PlatId = id.ToObjectId(), quantite = qty };
                ((List<model.LigneCommande>)Session[unsavedLigneCommande]).Add(ln);
            }
        }

        protected void lnkPoursuivre_Click(object sender, EventArgs e)
        {
            if (lvRestaurant.SelectedIndex != -1 && ((List<model.LigneCommande>)Session[unsavedLigneCommande]).Count != 0)
            {
                model.Commande commande = new model.Commande() { ClientId = Request.QueryString["Id"].ToObjectId(), DateCreation = DateTime.Now };
                commande.RestaurantId = lvRestaurant.SelectedDataKey.Value.ToString().ToObjectId();
                commande.Insert();

                foreach (model.LigneCommande ln in (List<model.LigneCommande>)Session[unsavedLigneCommande])
                {
                    ln.CommandeId = commande.Id;
                    ln.Insert();
                }

                ((List<model.LigneCommande>)Session[unsavedLigneCommande]).Clear();

                Response.Redirect("~/presentation/restricted/CompleterCommande.aspx?Id=" + commande.Id.ToString(), true);
            }
        }
    }
}