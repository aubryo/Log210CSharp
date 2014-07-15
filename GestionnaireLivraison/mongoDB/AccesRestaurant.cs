using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesRestaurant : Acces<Restaurant>
    {
        private const string TableName = "restaurants";

        public AccesRestaurant(String dataBase):base(dataBase, TableName)
        {
        }

        public List<Restaurant> Select(Restaurateur restaurateur)
        {
            if (restaurateur == null) return new List<Restaurant>();

            var coll = db.GetCollection<Restaurant>(TableName);
            var selectQuery = Query<Restaurant>.EQ(i => i.RestaurateurID, restaurateur.Id);
            var restaurants = coll.Find(selectQuery).ToList<Restaurant>();
            return restaurants;
        }

        public List<Restaurant> SelectSansRestaurateurID()
        {
            var coll = db.GetCollection<Restaurant>(TableName);
            var selectQuery = Query<Restaurant>.EQ(i => i.RestaurateurID, ObjectId.Empty);
            var restaurants = coll.Find(selectQuery).ToList<Restaurant>();
            return restaurants;
        }

        protected override IMongoQuery SetSelectQuery(Restaurant item)
        {
            return null;
        }

        public List<Restaurant> SelectAllRestaurants()
        {
             var coll = db.GetCollection<Restaurant>(TableName);
            var selectQuery = Query<Restaurant>.NE(i => i.Id, ObjectId.Empty);
            var restaurants = coll.Find(selectQuery).ToList<Restaurant>();
            return restaurants;
         
        }
    }
}