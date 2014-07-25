using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Compte : ICompte
    {
        public ObjectId Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string NoTelephone { get; set; }
        public ObjectId AdresseId { get; set; }
        public string Courriel { get; set; }  //Nom du compte
        public string MotDePasse { get; set; }
        public EnumTypeCompte TypeCompte { get; set; }

        private AccesCompte accesCompte;
        private AccesAdresse accesAdresse;

        public Compte()
        {
            this.accesCompte = new AccesCompte(DataBases.NomDataBase());
            this.accesAdresse = new AccesAdresse(DataBases.NomDataBase());
        }

        protected AccesCompte GetAccesCompte()
        {
            return this.accesCompte;
        }

        public void Select()
        {
            var newdata = accesCompte.Select(this);
            if (newdata != null)
            {
                this.Id = newdata.Id;
                this.Nom = newdata.Nom;
                this.Prenom = newdata.Prenom;
                this.DateNaissance = newdata.DateNaissance;
                this.NoTelephone = newdata.NoTelephone;
                this.AdresseId = newdata.AdresseId;
                this.Courriel = newdata.Courriel;
                this.MotDePasse = newdata.MotDePasse;
                this.TypeCompte = newdata.TypeCompte;
            }

            //Populeur.populer(this, accesCompte.Select(this));
        }

        public void Insert()
        {
            accesCompte.Insert(this);
        }

        public void Update()
        {
            accesCompte.Update(this);
        }

        public void Delete()
        {
            if (this.AdresseId != ObjectId.Empty || this.AdresseId != null)
            {
                Adresse adresse = this.accesAdresse.Select(this);
                adresse.Delete();

            }
            accesCompte.Delete(this);
        }
    }
}

