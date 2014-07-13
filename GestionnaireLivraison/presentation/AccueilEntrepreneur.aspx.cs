using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison_LOG210.presentation
{
    public partial class AccueilEntrepreneur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void menuTabs_MenuItemClick(object sender, MenuEventArgs e)
        {
            vuesEntrepreneur.ActiveViewIndex = Int32.Parse(e.Item.Value);
        }
    }
}