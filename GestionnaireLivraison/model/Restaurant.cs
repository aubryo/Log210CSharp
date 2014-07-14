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
            this.accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
            this.accesMenu = new AccesMenu(DataBases.NomDataBase());
        }

        public void Select()
        {
           Populeur.populer(this, accesRestaurant.Select(this));
        }

        public void Insert()
        {
            accesRestaurant.Insert(this);
        }

        public void Update()
        {
            accesRestaurant.Update(this);
        }

        public List<Menu> getMenu()
        {
            return accesMenu.Select(this);
        }


        public void Delete()
        {
            
            accesRestaurant.Delete(this);
            
        }

    }

}