using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;
using MongoDB.Driver;

namespace GestionnaireLivraison.mongoDB
{
    public class AccesRestaurant : Acces<Restaurant>
    {

        private const string TableName = "restaurants";

        public AccesRestaurant(String dataBase):base(dataBase, TableName)
        {
        }
    }
}