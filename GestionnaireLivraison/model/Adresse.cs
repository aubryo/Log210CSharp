using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Adresse : IMongoSavableObject 
    {

        public ObjectId Id { get; set; }

        public string NoRue { get; set; }

        public string NomRue { get; set; }

        public string CodePostal { get; set; }

        public ObjectId CompteId { get; set; }

        private AccesAdresse accesAdresse;

        public Adresse()
        {
            this.accesAdresse = new AccesAdresse(DataBases.NomDataBase());
        
        }

        public void Select()
        {
           
            Populeur.populer(this, accesAdresse.Select(this));
        }

        public void Insert()
        {
            accesAdresse.Insert(this);
        }

        public void Update()
        {
            accesAdresse.Update(this);
        }


    }
}