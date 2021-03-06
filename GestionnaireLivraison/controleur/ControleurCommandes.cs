﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Bson;

namespace GestionnaireLivraison.controleur
{
    public static class ControleurCommandes
    {
        public static Commande ajouterCommmande(Client client)
        {
            return new Commande() { ClientId = client.Id };
        }

        public static List<Restaurant> GetRestaurants()
        {
            return GestionnaireLivraison.model.GestionnaireLivraison.GetRestaurants();                
        }

        public static void ajouterLigneCommande(Commande commande, Plat plat, int qty)
        {
            var ligneCommande = new LigneCommande() { CommandeId = commande.Id, PlatId = plat.Id, quantite = qty };
            ligneCommande.Insert();
        }

        public static Commande poursuivreCommande(Commande commande)
        {
            commande.Insert();
            return commande;
        }

        public static List<Adresse> GetAdresses(string commandeId)
        {
            Commande commande = new Commande() { Id = new ObjectId(commandeId) };
            commande.Select();
            return commande.GetListClientAdresses();
        }

        public static Adresse GetAdresse(string Id)
        {
            Commande commande = new Commande() { Id = new ObjectId(Id) };
            commande.Select();
            Adresse adress = new Adresse() { Id = commande.AdresseId };
            adress.Select();
            return adress;
        }

        public static List<LigneCommande> GetLigneCommandes(string commandeId)
        {
            Commande commande = new Commande() { Id = new ObjectId(commandeId) };
            commande.Select();
            return commande.GetListLigneCommande();
        }

        public static void ajouterAdresse(Commande commande, Adresse adresse)
        {
            adresse.CompteId = commande.ClientId;
            adresse.Insert();
        }

        public static Commande confirmerCommande(Commande commande)
        {
            commande.Update();
            return commande;
        }

        public static List<Commande> GetCommandes(string restaurantId)
        {
            Restaurant resto = new Restaurant() { Id = new ObjectId(restaurantId) };
            resto.Select();
            return resto.GetCommandes();
        }

        public static List<Commande> GetCommandesPrete()
        {
            return model.GestionnaireLivraison.GetCommandePrete();
        }

        public static List<Commande> GetCommandesAcceptee()
        {
            return model.GestionnaireLivraison.GetCommandeAcceptee();
        }
    }
}