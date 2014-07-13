using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Restaurant : IMongoSavableObject
    {

        public ObjectId Id { get; set; }
        public string Nom { get; set; }
        public string NoTelephone { get; set; }
        public string NoRue { get; set; }
        public string CodePostal { get; set; }
        public string NomRue { get; set; }
        public string Website { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public ObjectId RestaurateurID { get; set; }

        private AccesRestaurant accesRestaurant;
        private AccesMenu accesMenu;

        public Restaurant()
        {
            this.accesRestaurant = new AccesRestaurant(DataBases.Databases());
            this.accesMenu = new AccesMenu(DataBases.Databases());
        }

        internal void Load()
        {
            Restaurant nouveauRestaurant = new Restaurant();
            Populeur.populer(this, accesRestaurant.Select(this));
        }
    }

}