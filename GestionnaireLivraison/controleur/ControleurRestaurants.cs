using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Bson;

namespace GestionnaireLivraison.controleur
{
    public static class ControleurRestaurants
    {
        public static Restaurant ajouterRestaurant()
        {
            return new Restaurant();
        }

        public static void saisirInformationRestaurant(Restaurant restaurant)
        {
            restaurant.Update();
        }

        public static void supprimerRestaurant(Restaurant restaurant)
        {
            restaurant.Delete();
        }

        public static Restaurant modifierRestaurant(Restaurant restaurant)
        {
            restaurant.Select();
            return restaurant;
        }

        public static List<model.Restaurant> GetRestaurants()
        {
            return model.GestionnaireLivraison.GetRestaurants();
        }

        public static List<model.Restaurant> GetRestaurantsAffichable(string id)
        {
            var restos = model.GestionnaireLivraison.GetRestaurantsSansID();

            if (!String.IsNullOrEmpty(id))
            {
                model.Restaurateur restaurateur = new model.Restaurateur() { Id = new ObjectId(id) };
                restaurateur.Select();
                restos.AddRange(restaurateur.GetRestaurants());
            }

            return restos;
        }

        public static List<model.Restaurant> GetRestaurants(string id)
        {
            model.Restaurateur restaurateur = new model.Restaurateur() { Id = new ObjectId(id) };
            restaurateur.Select();
            return restaurateur.GetRestaurants();
        }

        public static List<model.Restaurant> GetRestaurantsCommandable()
        {
            return model.GestionnaireLivraison.GetRestaurantsAvecRestaurateur();
        }

        public static void DeleteRestaurant(string id)
        {
            model.Restaurant resto = new model.Restaurant() { Id = new ObjectId(id) };
            resto.Delete();
        }
    }
}