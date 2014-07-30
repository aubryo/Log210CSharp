using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.presentation
{
    public partial class AccueilRestaurateur : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        //protected List<model.Menu> GetMenus(object id)
        //{
        //    model.Restaurant resto = new model.Restaurant() { Id = id.ToString().ToObjectId() };
        //    resto.Select();
        //    return resto.GetMenus();
        //}

        protected void menuTabs_MenuItemClick(object sender, MenuEventArgs e)
        {
            vuesEntrepreneur.ActiveViewIndex = Int32.Parse(e.Item.Value);
        }

        protected void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;
            if (radio.Checked)
            {
                model.Commande commande = new model.Commande() {Id = radio.GroupName.ToObjectId() };
                commande.Select();
                switch (radio.ID)
                {
                    case "radPassee":
                        commande.Statut = EnumCommandeStatut.Passee.ToString();
                        break;
                    case "radEnPreparation":
                        commande.Statut = EnumCommandeStatut.EnPreparation.ToString();
                        break;
                    case "radPrete":
                        commande.Statut = EnumCommandeStatut.Prete.ToString();
                        break;
                }
                commande.Update();
            }
        }
    }
}