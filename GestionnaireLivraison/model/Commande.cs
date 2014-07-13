using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;


namespace GestionnaireLivraison.model
{
    public class Commande
    {
        public ObjectId Id { get; set; }

        public string NoCommande { get; set; }
        
        public DateTime DateCreation { get; set; }
        
        public string Statut { get; set; }
        
        public DateTime DateLivraison { get; set; }
        
        public string AdresseId { get; set; }
        
        public string ClientId { get; set; }

        private AccesCommande accesCommande;

        public Commande()
        {
            this.accesCommande = new AccesCommande(DataBases.Databases());
   
        }

    }
}