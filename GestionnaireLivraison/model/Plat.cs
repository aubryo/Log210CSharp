﻿using System;
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
            this.accesPlat = new AccesPlat(DataBases.Databases()); 

        }

        internal void Load()
        {
            Plat nouveauCompte = new Plat();
            Populeur.populer(this, accesPlat.Select(this));
        }
	
    }
}