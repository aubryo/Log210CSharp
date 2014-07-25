using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Bson;

namespace GestionnaireLivraison.controleur
{
    public static class ControleurRestaurateurs
    {
        public static Restaurateur ajouterRestaurateur()
        {
            return new Restaurateur(new Compte());
        }

        public static void saisirInformationRestaurateur(Restaurateur restaurateur)
        {
            restaurateur.Update();
        }

        public static void supprimerRestaurateur(Restaurateur restaurateur)
        {
            restaurateur.Delete();
        }

        public static void modifierRestaurateur(Restaurateur restaurateur)
        {
            restaurateur.Update();
        }

        public static List<model.Restaurateur> GetRestaurateurs()
        {
            return model.GestionnaireLivraison.GetRestaurateurs();
        }

        public static void DeleteRestaurateur(string id)
        {
            model.Restaurateur resto = new model.Restaurateur(new Compte() { Id = new ObjectId(id) });
            resto.Select();
            resto.Delete();
        }
    }
}