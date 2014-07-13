using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesPlat : Acces<Plat>
    {
        private const string TableName = "plats";

        public AccesPlat(String dataBase):base(dataBase, TableName)
        {
            db = MongoAccess.getDB(dataBase);
        }

        /*
        public Plat Select(Plat plat)
        {
            if (plat == null) return null;

            var coll = db.GetCollection<Plat>(TableName);
            var selectQuery = Query<Plat>.EQ(i => i.Id, plat.Id);
            return coll.FindOne(selectQuery);
        }

        public bool Insert(Plat plat)
        {
            if (plat == null) return false;
            if (Select(plat) != null) return false;

            var coll = db.GetCollection<Plat>(TableName);
            var writeResult = coll.Insert(plat);
            return writeResult.Ok;
        }

        public bool Update(Plat plat)
        {
            if (plat == null) return false;

            var coll = db.GetCollection<Plat>(TableName);
            var writeResult = coll.Save(plat);
            return writeResult.Ok;
        }

        public bool Delete(Plat plat)
        {
            if (plat == null) return false;

            var coll = db.GetCollection<Plat>(TableName);
            var deleteQuery = Query<Plat>.EQ(i => i.Id, plat.Id);
            var writeResult = coll.Remove(deleteQuery);
            return writeResult.Ok;
        }*/

        protected override IMongoQuery SetSelectQuery(Plat item)
        {
            return null;
        }
    }
}