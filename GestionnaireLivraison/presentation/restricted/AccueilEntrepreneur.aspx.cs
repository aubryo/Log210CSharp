using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison.presentation
{
    public partial class AccueilEntrepreneur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lvRestaurant.DataSource = model.GestionnaireLivraison.GetRestaurants();
                lvRestaurant.DataBind();
                lvRestaurateur.DataSource = model.GestionnaireLivraison.GetRestaurateurs();
                lvRestaurateur.DataBind();
            }
        }

        protected void menuTabs_MenuItemClick(object sender, MenuEventArgs e)
        {
            vuesEntrepreneur.ActiveViewIndex = Int32.Parse(e.Item.Value);
        }

        protected void lvRestaurant_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            model.Restaurant restaurant = new model.Restaurant() { Id = e.CommandArgument.ToString().ToObjectId() };
            restaurant.Delete();
        }

        protected void lvRestaurateur_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            model.Restaurateur restaurateur = new model.Restaurateur(new model.Compte() { Id = e.CommandArgument.ToString().ToObjectId() });
            restaurateur.Delete();
        }
    }
}