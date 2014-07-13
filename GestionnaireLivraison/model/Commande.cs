using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;


namespace GestionnaireLivraison_LOG210.model
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

        public Commande()
        {                    
        }

    }
}