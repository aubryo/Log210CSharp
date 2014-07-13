﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Bson;
using GestionnaireLivraison_LOG210.model;

namespace GestionnaireLivraison_LOG210.model
{
    public abstract class Compte : ICompte
    {
        public ObjectId Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public string NoTelephone { get; set; }

        public ObjectId AdresseId { get; set; }

        public string Courriel { get; set; }  //Nom du compte

        public string MotDePasse { get; set; }

        public EnumAccesCompte AccesCompte { get; set; }

        public Compte()
        {
        }

    }
}

