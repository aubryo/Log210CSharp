using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using GestionnaireLivraison.model;
using GestionnaireLivraison.mongoDB;
using MongoDB.Driver;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesAdresse
    {
        private MongoDatabase db;

        private const string TableName = "adresses";
        private const string CompteIdPropertyName = "CompteId";

        public AccesAdresse(String dataBase)
        {
            db = MongoAccess.getDB(dataBase);
        }

        public Adresse Select(Adresse adresse)
        {
            return null;
        }

        public Adresse Select(Compte compte)
        {
            return null;
        }

        public bool Insert(Adresse adresse)
        {
            return false;
        }

        public bool Update(Adresse adresse)
        {
            return false;
        }

        public bool Delete(Adresse adresse)
        {
            return false;
        }
    }
}