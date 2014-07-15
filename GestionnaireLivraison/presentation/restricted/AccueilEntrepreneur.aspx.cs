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
            }
        }

        protected void menuTabs_MenuItemClick(object sender, MenuEventArgs e)
        {
            vuesEntrepreneur.ActiveViewIndex = Int32.Parse(e.Item.Value);
        }

        protected void lvRestaurant_SelectedIndexChanging(object sender, ListViewSelectEventArgs e)
        {
            lvRestaurant.DataSource = model.GestionnaireLivraison.GetRestaurants();
            lvRestaurant.DataBind();

        }
    }
}