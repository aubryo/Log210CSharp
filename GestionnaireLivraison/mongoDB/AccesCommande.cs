using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

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
            var selectQuery = Query<Commande>.EQ(i => i.RestaurantId, restaurant.Id);
            var commandes = coll.Find(selectQuery).ToList<Commande>();
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