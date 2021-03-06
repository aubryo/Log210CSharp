﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GestionnaireLivraison.model
{
    public class Client : ICompte
    {
        private Compte compte;
        public List<Commande> Commandes
        {
            get
            {
                return null;
            }
        }

        public Client(Compte compte)
        {
            this.compte = compte;
            compte.TypeCompte = EnumTypeCompte.Client;
        }

        public void Select()
        {
            compte.Select();
        }

        public void Insert()
        {
            compte.Insert();
        } 
        
        public void Update()
        {
            compte.Update();
        }


      

  

        #region ICompte Members

        public MongoDB.Bson.ObjectId Id
        {
            get
            {
                return compte.Id;
            }
            set
            {
                compte.Id = value;
            }
        }

        public string Nom
        {
            get
            {
                return compte.Nom;
            }
            set
            {
                compte.Nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return compte.Prenom;
            }
            set
            {
                compte.Prenom = value;
            }
        }

        public DateTime DateNaissance
        {
            get
            {
                return compte.DateNaissance;
            }
            set
            {
                compte.DateNaissance = value;
            }
        }

        public string NoTelephone
        {
            get
            {
                return  compte.NoTelephone;
            }
            set
            {
                compte.NoTelephone = value;
            }
        }

        public MongoDB.Bson.ObjectId AdresseId
        {
            get
            {
                return compte.AdresseId;
            }
            set
            {
                compte.AdresseId = value;
            }
        }

        public string Courriel
        {
            get
            {
                return compte.Courriel;
            }
            set
            {
                compte.Courriel = value;
            }
        }

        public string MotDePasse
        {
            get
            {
                return compte.MotDePasse;
            }
            set
            {
                compte.MotDePasse = value;
            }
        }

        public EnumTypeCompte TypeCompte
        {
            get
            {
                return compte.TypeCompte;
            }
            set
            {
                compte.TypeCompte = value;
            }
        }

        #endregion
    }
}