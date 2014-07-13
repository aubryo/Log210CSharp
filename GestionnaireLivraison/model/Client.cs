using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace GestionnaireLivraison_LOG210.model
{
    public class Client : Compte
    {
        public List<Commande> Commandes
        {
            get
            {
                return null;
            }
        }

        public Client()
        {
        }


    }
}