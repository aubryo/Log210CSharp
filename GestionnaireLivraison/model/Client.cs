using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison_LOG210.model;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison_LOG210.model
{
    public class Client : ICompte
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