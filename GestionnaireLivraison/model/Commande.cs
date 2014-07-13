using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;


namespace GestionnaireLivraison_LOG210.model
{
    public class Commande
    {
        private ObjectId Id { get; set; }

        private string NoCommande { get; set; }

        private DateTime DateCreation { get; set; }

        private string Statut { get; set; }

        private DateTime DateLivraison { get; set; }

        private string AdresseId { get; set; }

        private string ClientId { get; set; }

        public Commande()
        {                    
        }

    }
}