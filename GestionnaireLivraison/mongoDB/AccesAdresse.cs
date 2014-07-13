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
    public class AccesAdresse : Acces<Adresse>
    {
        private const string TableName = "adresses";

        public AccesAdresse(String dataBase):base(dataBase, TableName)
        {
            db = MongoAccess.getDB(dataBase);
        }

        public List<Adresse> Select(Client client)
        {
            if (client == null) return new List<Adresse>();

            var coll = db.GetCollection<Adresse>(TableName);
            var selectQuery = Query<Adresse>.EQ(i => i.CompteId, client.Id);
            var adresses = coll.Find(selectQuery).ToList<Adresse>();
            return adresses;
        }

        protected override IMongoQuery SetSelectQuery(Adresse item)
        {
            return null;
        }
    }
}