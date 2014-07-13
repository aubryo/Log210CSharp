using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;

namespace GestionnaireLivraison.mongoDB
{
    public class MongoAccess
    {
        private static MongoClient mongoClient;

        private MongoAccess()
        {
        }

        public static MongoDatabase getDB(String database)
        {
            if (mongoClient == null)
            {
                mongoClient = new MongoClient();
            }
            return mongoClient.GetServer().GetDatabase(database);
        }
    }
}