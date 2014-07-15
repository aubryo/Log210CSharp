using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.controleur
{
    public static class ControleurLogin
    {
        public static ICompte ValidateUser(string courriel, string motDePasse)
        {
            var compte = new Compte() { Courriel = courriel };
            compte.Select();
            if (compte.MotDePasse.Equals(motDePasse))
                return compte;
            else
                return null;
        }

        public static string GetAcceuilPage(ICompte compte)
        {
            switch (compte.TypeCompte)
            {
                case EnumTypeCompte.Client:
                    return "~/presentation/restricted/AccueilClient.aspx?id=" + compte.Id.ToString();
                case EnumTypeCompte.Entrepreneur:
                    return "~/presentation/restricted/AccueilEntrepreneur.aspx?id=" + compte.Id.ToString();
                case EnumTypeCompte.Livreur:
                    return "~/presentation/restricted/AccueilLivreur.aspx?id=" + compte.Id.ToString();
                case EnumTypeCompte.Restaurateur:
                    return "~/presentation/restricted/AccueilRestaurateur.aspx?id=" + compte.Id.ToString();
                default:
                    throw new Exception("compte.TypeCompte est indefini");
            }
        }

        internal static string GetLoginPage()
        {
            return "~/presentation/Login.aspx";
        }
    }
}