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

        public static void SetEntrepreneurFirstTime()
        {
            /* TODO check compte by type for entrepreneur
             * if count == 0 add a default entrepreneur             * 
             */
        }

        public static bool IsCourrielUnique(string courriel)
        {
            /* TODO faire une methode qui retourne vrai si le courriel n'est pas dans la DB
             * 
             * */
            return false;
        }

    }
}