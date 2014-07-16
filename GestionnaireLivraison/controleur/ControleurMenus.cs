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

        public static List<Menu> GetMenus(string id)
        {
            Restaurant resto = new Restaurant() { Id = new ObjectId(id) };
            resto.Select();
            return resto.GetMenus();
        }

        public static List<Plat> GetPlats(string MId)
        {
            if (MId == null) return new List<Plat>();

            Menu menu = new Menu() { Id = new ObjectId(MId) };
            menu.Select();  
            return menu.GetPlats();
        }

        public static void SupprimerPlat(string id)
        {
            Plat plat = new Plat() { Id = new ObjectId(id) };
            plat.Delete();
        }
    }
}