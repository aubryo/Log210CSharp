using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.controleur
{
    public static class ControleurCommandes
    {
        public static Commande ajouterCommmande(Client client)
        {
            return new Commande() { ClientId = client.Id };
        }

        public static List<Restaurant> getRestaurants()
        {
            return null; //TODO GestionnaireLivraison.getRestaurants();
        }

        public static void ajouterLigneCommande(Commande commande, Plat plat, int qty)
        {
            var lc = new LigneCommande() { CommandeId = commande.Id, PlatId = plat.Id, quantite = qty };
            //lc.Insert();
        }

        public static Commande poursuivreCommande(Commande commande)
        {
            //TODO commande.Insert();
            return commande;
        }

        public static List<Adresse> getAdresses(Commande commande)
        {
            return null; //TODO commande.getClientAdresses();
        }

        public static void ajouterAdresse(Commande commande, Adresse adresse)
        {
            adresse.CompteId = commande.ClientId;
            //TODO adresse.Insert();
        }

        public static Commande confirmerCommande(Commande commande)
        {
            //TODO commande.Update();
            //TODO lorsque la commande update pour la premiere fois un no de commande devrait etre assigne
            return commande;
        }
    }
}