using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesRestaurant
    {
        private MongoDatabase db;

        private const string TableName = "comptes";
        private const string CourrielPropertyName = "Courriel";
/*
        public AccesCompte(String dataBase)
        {
            db = MongoAccess.getDB(dataBase);
            return null;
        }

        public Compte Select(Compte compte)
        {
            return null;
        }

        public bool Insert(Compte compte)
        {
            return false;
        }

        public bool Update(Compte compte)
        {
            return false;
        }

        public bool Delete(Compte compte)
        {
            return false;
        }*/
    }
}