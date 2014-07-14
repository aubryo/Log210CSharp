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

        public Compte()
        {
            this.accesCompte = new AccesCompte(DataBases.NomDataBase());

        }

        protected AccesCompte GetAccesCompte()
        {
            return this.accesCompte;
        }
        
        public void Select()
        {
           Populeur.populer(this, accesCompte.Select(this));
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
            
            accesCompte.Delete(this);
        }

        
    }
}

