using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionnaireLivraison_LOG210.model
{
    public class Menu
    {
       // public IAccesPlat accesPlat { get; set; }

        public String id { get; set; }
        public String nom { get; set; }
        public String idRestaurant { get; set; }

        public Menu() //throw new UnknownHostException
        {

         //   accesPlat = GestionnaireLivraison.accesPlat;
            this.id = Guid.NewGuid().ToString();

        }
    }
}