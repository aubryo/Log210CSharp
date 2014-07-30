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

        public static void SetLivreurFirstTime() 
        {
            AccesCompte accesCompte = new AccesCompte(DataBases.NomDataBase());
            AccesAdresse accesAdresse = new AccesAdresse(DataBases.NomDataBase());

            if (!accesCompte.LivreurExiste())
            {
                Compte nouveauLivreur1 = new Compte();
                nouveauLivreur1.MotDePasse = "livreur1";
                nouveauLivreur1.Nom = "Ford";
                nouveauLivreur1.NoTelephone = "999-1234";
                nouveauLivreur1.Prenom = "Rob";
                nouveauLivreur1.TypeCompte = EnumTypeCompte.Livreur;
                nouveauLivreur1.Courriel = "livreur1@gmail.com";
                nouveauLivreur1.DateNaissance = new DateTime(1999,03,03);
                accesCompte.Insert(nouveauLivreur1);

                Compte nouveauLivreur2 = new Compte();
                nouveauLivreur2.MotDePasse = "livreur2";
                nouveauLivreur2.Nom = "Chan";
                nouveauLivreur2.NoTelephone = "999-1234";
                nouveauLivreur2.Prenom = "Jackie";
                nouveauLivreur2.TypeCompte = EnumTypeCompte.Livreur;
                nouveauLivreur2.Courriel = "livreur2@gmail.com";
                nouveauLivreur2.DateNaissance = new DateTime(1999, 03, 03);
                accesCompte.Insert(nouveauLivreur2);

                Adresse adresseLivreur1 = new Adresse();
                adresseLivreur1.CodePostal = "H3C 1K3";
                adresseLivreur1.NomRue = "Rue Notre-Dame Ouest, Montréal, QC";
                adresseLivreur1.NoRue = "1100";
                accesAdresse.Insert(adresseLivreur1);
                nouveauLivreur1.AdresseId = adresseLivreur1.Id;
                adresseLivreur1.CompteId = nouveauLivreur1.Id;
                accesCompte.Update(nouveauLivreur1);
                accesAdresse.Update(adresseLivreur1);

                Adresse adresseLivreur2 = new Adresse();
                adresseLivreur2.CodePostal = "H3T 1J9";
                adresseLivreur2.NomRue = "Boulevard Edouard-Montpetit‎, Montréal, QC";
                adresseLivreur2.NoRue = "3141";
                accesAdresse.Insert(adresseLivreur2);
                nouveauLivreur2.AdresseId = adresseLivreur2.Id;
                adresseLivreur2.CompteId = nouveauLivreur2.Id;
                accesCompte.Update(nouveauLivreur2);
                accesAdresse.Update(adresseLivreur2);

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