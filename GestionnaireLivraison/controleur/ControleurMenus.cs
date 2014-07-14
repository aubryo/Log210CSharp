using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.controleur
{
    public class ControleurMenus
    {
        public static Menu ajouterMenu(Restaurant restaurant)
        {
            return new Menu() { RestaurantId = restaurant.Id };
        }

        public static void enregistrerMenu(Menu menu, List<Plat> plats)
        {
            //TODO menu.Insert();
            foreach (Plat p in plats)
            {
                p.MenuId = menu.Id;
                //TODO p.Update();
            }
        }
    }
}