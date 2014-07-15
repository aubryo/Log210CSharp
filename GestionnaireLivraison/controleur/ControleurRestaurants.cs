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

        public static List<model.Restaurant> GetRestaurantsSansRestaurateur()
        {
            return model.GestionnaireLivraison.GetRestaurantsSansID();
        }

        public static void DeleteRestaurant(string id)
        {
            model.Restaurant resto = new model.Restaurant() { Id = new ObjectId(id) };
            resto.Delete();
        }
    }
}