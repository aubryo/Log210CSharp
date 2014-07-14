﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;

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
    }
}