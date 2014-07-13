using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public class Acces<T:IMongoSavableObject>
    {
        private MongoDatabase db;

        private string tableName;

        public Acces(string dataBase, string tableName)
        {
            db = MongoAccess.getDB(dataBase);
            this.tableName = tableName;
        }

        public T Select(T item)
        {
            if (item == null) return null;

            var coll = db.GetCollection<T>(tableName);
            var selectQuery = Query<T>.EQ(i => i.Id, item.Id);
            return coll.FindOne(selectQuery);
        }

        public bool Insert(Menu menu)
        {
            if (menu == null) return false;
            if (Select(menu) != null) return false;

            var coll = db.GetCollection<Menu>(TableName);
            var writeResult = coll.Insert(menu);
            return writeResult.Ok;
        }

        public bool Update(Menu menu)
        {
            if (menu == null) return false;

            var coll = db.GetCollection<Menu>(TableName);
            var writeResult = coll.Save(menu);
            return writeResult.Ok;
        }

        public bool Delete(Menu menu)
        {
            if (menu == null) return false;

            var coll = db.GetCollection<Menu>(TableName);
            var deleteQuery = Query<Menu>.EQ(i => i.Id, menu.Id);
            var writeResult = coll.Remove(deleteQuery);
            return writeResult.Ok;
        }
    }
}