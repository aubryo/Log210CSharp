using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public abstract class Acces<T> where T : IMongoSavableObject
    {
        protected MongoDatabase db{get;set;}

        private string tableName;

        public Acces(string dataBase, string tableName)
        {
            db = MongoAccess.getDB(dataBase);
            this.tableName = tableName;
        }

        public T Select(T item)
        {
            if (item == null) return default(T);

            var coll = db.GetCollection<T>(tableName);
            var selectQuery = SetSelectQuery(item) ?? Query<T>.EQ(i => i.Id, item.Id);
            return coll.FindOne(selectQuery);
        }

        protected abstract IMongoQuery SetSelectQuery(T item);

        public bool Insert(T item)
        {
            if (item == null) return false;
            if (Select(item) != null) return false;

            var coll = db.GetCollection<T>(tableName);
            var writeResult = coll.Insert(item);
            return writeResult.Ok;
        }

        public bool Update(T item)
        {
            if (item == null) return false;

            var coll = db.GetCollection<T>(tableName);
            var writeResult = coll.Save(item);
            return writeResult.Ok;
        }

        public bool Delete(T item)
        {
            if (item == null) return false;

            var coll = db.GetCollection<T>(tableName);
            var deleteQuery = Query<T>.EQ(i => i.Id, item.Id);
            var writeResult = coll.Remove(deleteQuery);
            return writeResult.Ok;
        }
    }
}