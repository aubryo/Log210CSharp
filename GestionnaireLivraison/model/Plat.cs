using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Plat : IMongoSavableObject
    {
        public ObjectId Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public double Prix { get; set; }
        public ObjectId MenuId { get; set; }

        private AccesPlat accesPlat;

        public Plat()
        {
            this.accesPlat = new AccesPlat(DataBases.NomDataBase());

        }

        public void Select()
        {
            Plat newData = this.accesPlat.Select(this);
            this.Nom = newData.Nom;
            this.Description = newData.Description;
            this.Prix = newData.Prix;
            this.MenuId = newData.MenuId;
        }

        public void Insert()
        {
            accesPlat.Insert(this);
        }


        public void Update()
        {
            accesPlat.Update(this);
        }

        public void Delete()
        {
            accesPlat.Delete(this);
        }
    }
}