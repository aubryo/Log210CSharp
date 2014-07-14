using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.controleur
{
    public static class ControleurComptesClient
    {
        public static Client creerCompte()
        {
            return null;
        }

        public static void saisirInformationCompte(Client client)
        {
            client.Insert();
        }
    }
}