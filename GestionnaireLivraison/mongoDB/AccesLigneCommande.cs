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

        public List<LigneCommande> Select(Commande commande)
        {
            if (commande == null) return new List<LigneCommande>();

            var coll = db.GetCollection<LigneCommande>(TableName);
            var selectQuery = Query<LigneCommande>.EQ(i => i.CommandeId, commande.Id);
            var ligneCommandes = coll.Find(selectQuery).ToList<LigneCommande>();
            return ligneCommandes;
        }

        protected override IMongoQuery SetSelectQuery(LigneCommande item)
        {
            return null;
        }
    }
}