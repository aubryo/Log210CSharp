﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace GestionnaireLivraison_LOG210.model
{
    public abstract class Compte
    {
        public ObjectId Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public string NoTelephone { get; set; }

        public ObjectId AdresseId { get; set; }

        public string Courriel { get; set; }  //Nom du compte

        public string MotDePasse { get; set; }

        public string TypeAccesCompte { get; set; }

        public Compte()
        {
        }

    }
}

