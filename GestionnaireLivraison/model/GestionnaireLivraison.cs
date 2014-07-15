using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using GestionnaireLivraison.mongoDB;

namespace GestionnaireLivraison.model
{
    public static class GestionnaireLivraison
    {
        public static List<Restaurant> GetRestaurants()
        {
            AccesRestaurant accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
            return accesRestaurant.SelectAllRestaurants();
        }


        public static List<Restaurant> GetRestaurantsSansID()
        {
            AccesRestaurant accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
            return accesRestaurant.SelectSansRestaurateurID();
        }

        public static List<Restaurateur> GetRestaurateurs()
        {
            AccesCompte accesCompte = new AccesCompte(DataBases.NomDataBase());
            return accesCompte.SelectAllRestaurateurs();
        }

    }
}