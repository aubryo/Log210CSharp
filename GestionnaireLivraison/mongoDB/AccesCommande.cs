﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesCommande : Acces<Commande>
    {
        private const string TableName = "commandes";

        public AccesCommande(String dataBase):base(dataBase, TableName)
        {
        }

        public List<Commande> Select(Restaurant restaurant)
        {
            if (restaurant == null) return new List<Commande>();

            var coll = db.GetCollection<Commande>(TableName);
            var commandes = (from commande in coll.AsQueryable<Commande>()
                              where commande.RestaurantId == restaurant.Id && commande.NoCommande != null && !commande.NoCommande.Equals("") && commande.Statut != EnumCommandeStatut.Acceptee.ToString()
                              select commande).ToList<Commande>();

            return commandes;
        }

        public List<Commande> SelectCommandePrete()
        {
            var coll = db.GetCollection<Commande>(TableName);
            var commandes = (from commande in coll.AsQueryable<Commande>()
                             where commande.NoCommande != null && !commande.NoCommande.Equals("") && commande.Statut == EnumCommandeStatut.Prete.ToString()
                             select commande).ToList<Commande>();

            return commandes;
        }

        public List<Commande> SelectCommandeAcceptee()
        {
            var coll = db.GetCollection<Commande>(TableName);
            var commandes = (from commande in coll.AsQueryable<Commande>()
                             where commande.NoCommande != null && !commande.NoCommande.Equals("") && commande.Statut == EnumCommandeStatut.Acceptee.ToString()
                             select commande).ToList<Commande>();
            return commandes;
        }

        public List<Commande> Select(Client client)
        {
            if (client == null) return new List<Commande>();

            var coll = db.GetCollection<Commande>(TableName);
            var selectQuery = Query<Commande>.EQ(i => i.ClientId, client.Id);
            var commandes = coll.Find(selectQuery).ToList<Commande>();
            return commandes;
        }
           

        protected override IMongoQuery SetSelectQuery(Commande item)
        {
            return null;
        }
    }
}