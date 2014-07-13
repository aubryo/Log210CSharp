using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesLigneCommande: Acces<LigneCommande>
    {
        private const string TableName = "ligneCommandes";

        public AccesLigneCommande(String dataBase):base(dataBase, TableName)
        {
        }

        /*
        public LigneCommande Select(LigneCommande ligneCommande)
        {
            if (ligneCommande == null) return null;

            var coll = db.GetCollection<LigneCommande>(TableName);
            var selectQuery = Query<LigneCommande>.EQ(i => i.Id, ligneCommande.Id);
            return coll.FindOne(selectQuery);
        }

        public bool Insert(LigneCommande plat)
        {
            if (plat == null) return false;
            if (Select(plat) != null) return false;

            var coll = db.GetCollection<LigneCommande>(TableName);
            var writeResult = coll.Insert(plat);
            return writeResult.Ok;
        }

        public bool Update(LigneCommande plat)
        {
            if (plat == null) return false;

            var coll = db.GetCollection<LigneCommande>(TableName);
            var writeResult = coll.Save(plat);
            return writeResult.Ok;
        }

        public bool Delete(LigneCommande plat)
        {
            if (plat == null) return false;

            var coll = db.GetCollection<LigneCommande>(TableName);
            var deleteQuery = Query<LigneCommande>.EQ(i => i.Id, plat.Id);
            var writeResult = coll.Remove(deleteQuery);
            return writeResult.Ok;
        }*/

        protected override IMongoQuery SetSelectQuery(LigneCommande item)
        {
            return null;
        }
    }
}