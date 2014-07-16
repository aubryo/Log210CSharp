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
            AccesCompte accesCompte = new AccesCompte(DataBases.NomDataBase());
            if (!accesCompte.EntrepreneurExiste())
            {
                Compte nouveauEntrepreneur = new Compte();
                nouveauEntrepreneur.MotDePasse = "admin";
                nouveauEntrepreneur.Nom = "Marley";
                nouveauEntrepreneur.NoTelephone = "999-9999";
                nouveauEntrepreneur.Prenom = "Bob";
                nouveauEntrepreneur.TypeCompte = EnumTypeCompte.Entrepreneur;
                nouveauEntrepreneur.Courriel = "entrepreneur@gmail.com";
                nouveauEntrepreneur.DateNaissance = new DateTime(2014,03,02) ;
                accesCompte.Insert(nouveauEntrepreneur);
            }
        }

        public static bool IsCourrielUnique(string courriel)
        {
  
            AccesCompte accesCompte = new AccesCompte(DataBases.NomDataBase());
            return accesCompte.CourrielUnique(courriel);
   
        }
        
        internal static List<Restaurant> GetRestaurantsAvecRestaurateur()
        {
            AccesRestaurant accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
            return accesRestaurant.SelectRestaurantsAvecRestaurateur();
        }
    }
}