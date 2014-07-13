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

        public List<Plat> Select(Menu menu)
        {
            if (menu == null) return new List<Plat>();

            var coll = db.GetCollection<Plat>(TableName);
            var selectQuery = Query<Plat>.EQ(i => i.MenuId, menu.Id);
            var plats = coll.Find(selectQuery).ToList<Plat>();
            return plats;
        }

        public Plat Select(LigneCommande ligneCommande)
        {
            if (ligneCommande == null) return null;

            var coll = db.GetCollection<Plat>(TableName);
            var selectQuery = Query<Plat>.EQ(i => i.Id, ligneCommande.PlatId);
            return coll.FindOne(selectQuery);
        }

        protected override IMongoQuery SetSelectQuery(Plat item)
        {
            return null;
        }
    }
}