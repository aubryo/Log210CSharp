using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Bson;

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
            menu.Insert();
            foreach (Plat plat in plats)
            {
                plat.MenuId = menu.Id;
                plat.Update();
            }
        }

        public static List<model.Menu> GetMenus(string id)
        {
            model.Restaurant resto = new model.Restaurant() { Id = new ObjectId(id) };
            resto.Select();
            return resto.GetMenus();
        }


    }
}