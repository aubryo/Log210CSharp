using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Menu
    {
        public ObjectId Id { get; set; }
        public String nom { get; set; }
        public String idRestaurant { get; set; }

        private AccesPlat accesPlat;

        public Menu() 
        {
            this.accesPlat = new AccesPlat(DataBases.Databases());
       

        }
    }
}