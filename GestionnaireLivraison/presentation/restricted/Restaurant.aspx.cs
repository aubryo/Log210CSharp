using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GestionnaireLivraison.presentation
{
    public partial class Restaurant : System.Web.UI.Page
    {
        private string textbtnCreation = "Créer restaurant";
        private string textbtnModification = "Modifier restaurant";

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                lbRestaurateur.DataSource = model.GestionnaireLivraison.GetRestaurateurs();
                lbRestaurateur.DataValueField = "Id";
                lbRestaurateur.DataTextField = "Nom";
                lbRestaurateur.DataBind();
                if (id != null)
                {
                    model.Restaurant resto = new model.Restaurant() { Id = id.ToObjectId() };
                    resto.Select();
                    SetRestaurantData(resto);
                    etatModification();
                }
                else
                {
                    etatCreation(true);
                }
            }
        }

        private void etatCreation(bool p)
        {
            throw new NotImplementedException();
        }

        private void etatModification()
        {
            throw new NotImplementedException();
        }

        private void SetRestaurantData(model.Restaurant resto)
        {
            throw new NotImplementedException();
        }
    }
}