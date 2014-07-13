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

        /*
        public Commande Select(Commande commande)
        {
            if (commande == null) return null;

            var coll = db.GetCollection<Commande>(TableName);
            var selectQuery = Query<Compte>.EQ(i => i.Id, commande.Id);
            return coll.FindOne(selectQuery);
        }

        public bool Insert(Commande commande)
        {
            if (commande == null) return false;
            if (Select(commande) != null) return false;

            var coll = db.GetCollection<Commande>(TableName);
            var writeResult = coll.Insert(commande);
            return writeResult.Ok;
        }

        public bool Update(Commande adresse)
        {
            if (adresse == null) return false;

            var coll = db.GetCollection<Commande>(TableName);
            var writeResult = coll.Save(adresse);
            return writeResult.Ok;
        }

        public bool Delete(Commande adresse)
        {
            if (adresse == null) return false;

            var coll = db.GetCollection<Commande>(TableName);
            var deleteQuery = Query<Commande>.EQ(i => i.Id, adresse.Id);
            var writeResult = coll.Remove(deleteQuery);
            return writeResult.Ok;
        }*/

        protected override IMongoQuery SetSelectQuery(Commande item)
        {
            return null;
        }
    }
}