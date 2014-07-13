using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace GestionnaireLivraison_LOG210.model
{
    public class LigneCommande
    {

        public String id { get; set;  }

        public Commande commande { get; set; }

        public Plat plat { get; set; }

        public int quantite { get; set; }

        public LigneCommande()
        { }

        public LigneCommande(Commande commande, Plat plat)
        {
            this.commande = commande;
            this.plat = plat;
            this.id = Guid.NewGuid().ToString();
            
        }
    }
}