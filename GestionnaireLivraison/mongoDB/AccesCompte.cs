using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesCompte : Acces<Compte>
    {
        private const string TableName = "comptes";
        private const string CourrielPropertyName = "Courriel";

        public AccesCompte(String dataBase): base(dataBase, TableName)
        {
            db = MongoAccess.getDB(dataBase);
        }

        public Compte Select(Restaurant restaurant)
        {
            if (restaurant == null) return null;

            var coll = db.GetCollection<Compte>(TableName);
            var selectQuery = Query<Compte>.EQ(i => i.Id, restaurant.RestaurateurID);
            return coll.FindOne(selectQuery);
        }

        public bool CourrielUnique(string courriel)
        {
            var coll = db.GetCollection<Compte>(TableName);
            var selectQuery = Query<Compte>.EQ(i => i.Courriel, courriel);
            var compte = new Compte();
            compte = coll.FindOne(selectQuery);
            if (compte == null) return true;
            return false;
        }

        public bool EntrepreneurExiste()
        {
            var coll = db.GetCollection<Entrepreneur>(TableName);
            var selectQuery = Query<Entrepreneur>.EQ(i => i.TypeCompte, EnumTypeCompte.Entrepreneur);
            var entrepreneur = coll.Find(selectQuery).ToList<Entrepreneur>();
            if (entrepreneur.Count == 0) return false;
            return true;
        }

        public List<Restaurateur> SelectAllRestaurateurs()
        {
            var coll = db.GetCollection<Restaurateur>(TableName);
            var selectQuery = Query<Restaurateur>.EQ(i => i.TypeCompte, EnumTypeCompte.Restaurateur);
            var restaurateurs = coll.Find(selectQuery).ToList<Restaurateur>();
            return restaurateurs;
        }

        protected override IMongoQuery SetSelectQuery(Compte item)
        {
            return !String.IsNullOrEmpty(item.Courriel) ? Query<Compte>.EQ(i => i.Courriel, item.Courriel) : Query<Compte>.EQ(i => i.Id, item.Id);
        }
    }
}