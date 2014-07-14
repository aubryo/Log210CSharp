using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;


namespace GestionnaireLivraison.model
{
    public class Commande : IMongoSavableObject 
    {
        public ObjectId Id { get; set; }
        public string NoCommande { get; set; }
        public DateTime DateCreation { get; set; }
        public string Statut { get; set; }   
        public DateTime DateLivraison { get; set; }  
        public ObjectId AdresseId { get; set; } 
        public ObjectId ClientId { get; set; }
        public ObjectId RestaurantId { get; set; }

        private AccesCommande accesCommande;
        private AccesLigneCommande accesLigneCommande;
        private AccesAdresse accesAdresse;
        private AccesRestaurant accesRestaurant;
      

        public Commande()
        {
            this.accesCommande = new AccesCommande(DataBases.Databases());
            this.accesLigneCommande = new AccesLigneCommande(DataBases.Databases());
            this.accesAdresse = new AccesAdresse(DataBases.Databases());
            this.accesRestaurant = new AccesRestaurant(DataBases.Databases());
        }

        public List<Adresse> GetListClientAdresse()
        {
            var client = new Client(new Compte() {Id = ClientId });
            var adresses = accesAdresse.Select(client);
            return adresses;
        }

    }
}