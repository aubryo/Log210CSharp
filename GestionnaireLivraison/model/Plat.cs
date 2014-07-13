using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionnaireLivraison_LOG210.model
{
    public class Plat
    {
        public String id { get; set; }

        public String nom { get; set; }

        public String description { get; set; }

        public double prix { get; set; }

        public String idMenu { get; set; }

        public Plat()
        {
            id = Guid.NewGuid().ToString();
        }
	
    }
}