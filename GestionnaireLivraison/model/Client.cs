using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GestionnaireLivraison.model
{
    public class Client : ICompte
    {
        public List<Commande> Commandes
        {
            get
            {
                return null;
            }
        }

        public Client(Compte compte)
        {

        }



        #region ICompte Members

        public MongoDB.Bson.ObjectId Id
        {
            get
            {
               return 
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Nom
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Prenom
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DateNaissance
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string NoTelephone
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public MongoDB.Bson.ObjectId AdresseId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Courriel
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string MotDePasse
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public EnumAccesCompte AccesCompte
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}