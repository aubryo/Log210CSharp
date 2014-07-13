using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace GestionnaireLivraison_LOG210.model
{
    public class Plat
    {
        public ObjectId Id { get; set; }

        public String Nom { get; set; }

        public String Description { get; set; }

        public double Prix { get; set; }

        public ObjectId MenuId { get; set; }

        public Plat()
        {
            
        }
	
    }
}