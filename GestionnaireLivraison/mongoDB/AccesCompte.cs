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

        protected override IMongoQuery SetSelectQuery(Compte item)
        {
            return !String.IsNullOrEmpty(item.Courriel) ? Query<Compte>.EQ(i => i.Courriel, item.Courriel) : Query<Compte>.EQ(i => i.Id, item.Id);
        }
    }
}