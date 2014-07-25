using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MongoDB.Bson;
using GestionnaireLivraison.mongoDB;

namespace GestionnaireLivraison.model
{
    public class LigneCommande :IMongoSavableObject 
    {
        public ObjectId Id { get; set;  }
        public ObjectId CommandeId { get; set; }
        public ObjectId PlatId { get; set; }
        public int quantite { get; set; }

        private AccesLigneCommande accesLigneCommande;

        public LigneCommande()
        {
            this.accesLigneCommande = new AccesLigneCommande(DataBases.NomDataBase());

        }

        public void Select()
        {
            LigneCommande newData = accesLigneCommande.Select(this);
            this.CommandeId = newData.CommandeId;
            this.PlatId = newData.PlatId;
            this.quantite = newData.quantite;
        }

        public void Insert()
        {
            accesLigneCommande.Insert(this);
        }


        public void Update()
        {
            accesLigneCommande.Update(this);
        }

        public void Delete()
        {
            accesLigneCommande.Delete(this);

        }
       
    }
}