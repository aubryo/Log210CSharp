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
                model.Plat plat = (model.Plat)item.DataItem;
                int qty = Int32.Parse((item.FindControl("txtQty") as TextBox).Text);
                model.LigneCommande ln = new model.LigneCommande() { PlatId = plat.Id, quantite = qty };
                ((List<model.LigneCommande>)Session[unsavedLigneCommande]).Add(ln);
            }
        }

        protected void btnPoursuivre_Click(object sender, EventArgs e)
        {
            model.Commande commande = new model.Commande() { ClientId = Request.QueryString["Id"].ToObjectId(), DateCreation = DateTime.Now };
            commande.Insert();

            foreach (model.LigneCommande ln in (List<model.LigneCommande>)Session[unsavedLigneCommande])
            {
                ln.CommandeId = commande.Id;
                ln.Insert();
            }

            ((List<model.LigneCommande>)Session[unsavedLigneCommande]).Clear();

            Response.Redirect("~/presentation/restricted/Commande.aspx?Id=" + commande.Id.ToString(), true);
        }
    }
}