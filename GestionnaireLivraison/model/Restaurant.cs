using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Restaurant
    {

        public ObjectId Id { get; set; }

        public String Nom { get; set; }

        public String NoTelephone { get; set; }

        public String NoRue { get; set; }

        public String CodePostal { get; set; }

        public String NomRue { get; set; }

        public String Website { get; set; }

        public String Url { get; set; }

        public String Description { get; set; }

        public ObjectId RestaurateurID { get; set; }

        public Restaurant()
        {

        }
    }

}