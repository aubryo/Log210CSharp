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
        public string _Statut;
        public string Statut
        {
            get
            {
                return _Statut;
            }
            set
            {
                _Statut = value;
                AdviseClient();
            }
        }
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
            this.accesCommande = new AccesCommande(DataBases.NomDataBase());
            this.accesLigneCommande = new AccesLigneCommande(DataBases.NomDataBase());
            this.accesAdresse = new AccesAdresse(DataBases.NomDataBase());
            this.accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
        }

        public List<Adresse> GetListClientAdresses()
        {
            var client = new Client(new Compte() { Id = ClientId });

            var adresses = accesAdresse.Select(client);

            return adresses;
        }

        public List<LigneCommande> GetListLigneCommande()
        {
            return accesLigneCommande.Select(this);
        }

        public void Select()
        {
            Commande newData = this.accesCommande.Select(this);
            this.NoCommande = newData.NoCommande;
            this.DateCreation = newData.DateCreation;
            this.Statut = newData.Statut;
            this.DateLivraison = newData.DateLivraison;
            this.AdresseId = newData.AdresseId;
            this.ClientId = newData.ClientId;
            this.RestaurantId = newData.RestaurantId;
        }

        public void Insert()
        {
            accesCommande.Insert(this);
        }


        public void Update()
        {
            if (String.IsNullOrEmpty(this.NoCommande))
            {
                this.NoCommande = Guid.NewGuid().ToString();
                this.Statut = EnumCommandeStatut.Passee.ToString();
            }

            accesCommande.Update(this);
        }

        public void Delete()
        {
            List<LigneCommande> lignesCommandes = GetListLigneCommande();
            if (lignesCommandes != null || lignesCommandes.Count != 0)
            {
                foreach (LigneCommande ligneCommande in lignesCommandes)
                {
                    ligneCommande.Delete();
                }
            }
            accesCommande.Delete(this);


        }

        private void AdviseClient()
        {
            if (!this.ClientId.Equals(ObjectId.Empty))
            {
                Client client = new Client(new Compte() { Id = this.ClientId });
                client.Select();
                StatutChangeEmail.Advise(client, this);
            }
        }

    }
}