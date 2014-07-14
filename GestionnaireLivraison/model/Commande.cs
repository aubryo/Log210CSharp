﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;


namespace GestionnaireLivraison.model
{
    public class Commande : IMongoSavableObject 
    {
        public ObjectId Id { get; set; }
        public string NoCommande { get; set; }
        public DateTime DateCreation { get; set; }
        public string Statut { get; set; }   
        public DateTime DateLivraison { get; set; }  
        public ObjectId AdresseId { get; set; } 
        public ObjectId ClientId { get; set; }
        public ObjectId RestaurantId { get; set; }

        private AccesCommande accesCommande;
        private AccesLigneCommande accesLigneCommande;
        private AccesAdresse accesAdresse;
        private AccesRestaurant accesRestaurant;
      

        public Commande()
        {
            this.accesCommande = new AccesCommande(DataBases.NomDataBase());
            this.accesLigneCommande = new AccesLigneCommande(DataBases.NomDataBase());
            this.accesAdresse = new AccesAdresse(DataBases.NomDataBase());
            this.accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
        }

        public List<Adresse> GetListClientAdresse()
        {
            var compte = new Compte() {Id = ClientId };
            
            var adresses = accesAdresse.Select(compte);

            return adresses;
        }

        public void Select()
        {
            
            Populeur.populer(this, accesCommande.Select(this));
        }

        public void Insert()
        {
            accesCommande.Insert(this);
        }


        public void Update()
        {

        }

        public void Delete()
        {

        }

    }
}