using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesMenu : Acces<Menu>
    {

        private const string TableName = "menus";

        public AccesMenu(String dataBase):base(dataBase, TableName)
        {
        }

        /*
        public Menu Select(Menu menu)
        {
            if (menu == null) return null;

            var coll = db.GetCollection<Menu>(TableName);
            var selectQuery = Query<Menu>.EQ(i => i.Id, menu.Id);
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
        }*/

        protected override IMongoQuery SetSelectQuery(Menu item)
        {
            return null;
        }
    }
}