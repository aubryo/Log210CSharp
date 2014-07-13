using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using GestionnaireLivraison.mongoDB;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesAdresse
    {
        private MongoDatabase db;

        private const string TableName = "adresses";

        public AccesAdresse(String dataBase)
        {
            db = MongoAccess.getDB(dataBase);
        }

        public Adresse Select(Adresse adresse)
        {
            if (adresse == null) return null;

            var coll = db.GetCollection<Adresse>(TableName);
            var selectQuery = Query<Adresse>.EQ(i => i.Id, adresse.Id);
            return coll.FindOne(selectQuery);
        }

        public List<Adresse> Select(ICompte compte)
        {
            if (compte == null) return null;

            var coll = db.GetCollection<Adresse>(TableName);
            var selectQuery = Query<Adresse>.EQ(i => i.CompteId, compte.Id);
            var adresses = coll.Find(selectQuery).ToList<Adresse>();
            return adresses;
        }

        public bool Insert(Adresse adresse)
        {
            if (adresse == null) return false;
            if (Select(adresse) != null) return false;

            var coll = db.GetCollection<Adresse>(TableName);
            var writeResult = coll.Insert(adresse);
            return writeResult.Ok;
        }

        public bool Update(Adresse adresse)
        {
            if (adresse == null) return false;

            var coll = db.GetCollection<Adresse>(TableName);
            var writeResult = coll.Save(adresse);
            return writeResult.Ok;
        }

        public bool Delete(Adresse adresse)
        {
            if (adresse == null) return false;

            var coll = db.GetCollection<Adresse>(TableName);
            var deleteQuery = Query<Adresse>.EQ(i => i.Id, adresse.Id);
            var writeResult = coll.Remove(deleteQuery);
            return writeResult.Ok;
        }
    }
}