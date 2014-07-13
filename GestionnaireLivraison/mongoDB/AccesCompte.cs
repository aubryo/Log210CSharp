using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesCompte
    {
        private MongoDatabase db;

        private const string TableName = "comptes";
        private const string CourrielPropertyName = "Courriel";

        public AccesCompte(String dataBase)
        {
            db = MongoAccess.getDB(dataBase);
        }

        public Compte Select(Compte compte)
        {
            if (compte == null || String.IsNullOrEmpty(compte.Courriel)) return null;

            var coll = db.GetCollection<Compte>(TableName);
            var selectQuery = Query<Compte>.EQ(c => c.Courriel, compte.Courriel);            
            return coll.FindOne(selectQuery);
        }

        public bool Insert(Compte compte)
        {
            if (compte == null || String.IsNullOrEmpty(compte.Courriel)) return false;
            if (Select(compte) != null) return false;

            var coll = db.GetCollection<Compte>(TableName);
            var writeResult = coll.Insert(compte);
            return writeResult.Ok;
        }

        public bool Update(Compte compte)
        {
            if (compte == null || String.IsNullOrEmpty(compte.Courriel)) return false;

            var coll = db.GetCollection<Compte>(TableName);
            var writeResult = coll.Save(compte);
            return writeResult.Ok;
        }

        public bool Delete(Compte compte)
        {
            if (compte == null || String.IsNullOrEmpty(compte.Courriel)) return false;

            var coll = db.GetCollection<Compte>(TableName);
            var deleteQuery = Query<Compte>.EQ(c => c.Id, compte.Id);
            var writeResult = coll.Remove(deleteQuery);
            return writeResult.Ok;
        }
    }
}