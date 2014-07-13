﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using MongoDB.Bson;
using GestionnaireLivraison.mongoDB;

namespace GestionnaireLivraison.model
{
    public class LigneCommande
    {
        public ObjectId Id { get; set;  }
        public ObjectId commandeId { get; set; }
        public ObjectId platId { get; set; }
        public int quantite { get; set; }

        private AccesLigneCommande accesLigneCommande;

        public LigneCommande()
        {
            this.accesLigneCommande = new AccesLigneCommande(DataBases.Databases());

        }

       
    }
}