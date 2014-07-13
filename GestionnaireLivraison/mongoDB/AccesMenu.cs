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

        public List<Menu> Select(Restaurant restaurant)
        {
            if (restaurant == null) return new List<Menu>();

            var coll = db.GetCollection<Menu>(TableName);
            var selectQuery = Query<Menu>.EQ(i => i.RestaurantId, restaurant.Id);
            var menus = coll.Find(selectQuery).ToList<Menu>();
            return menus;
        }

        protected override IMongoQuery SetSelectQuery(Menu item)
        {
            return null;
        }
    }
}