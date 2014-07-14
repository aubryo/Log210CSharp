using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;

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
    }
}