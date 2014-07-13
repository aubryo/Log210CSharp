using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Menu
    {
       // public IAccesPlat accesPlat { get; set; }

        public ObjectId Id { get; set; }
   
        public String nom { get; set; }
        public String idRestaurant { get; set; }

        public Menu() 
        {

       

        }
    }
}