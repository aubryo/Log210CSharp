using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.controleur
{
    public static class ControleurComptesClient
    {
        public static Client ajouterCompte()
        {
            return new Client(new Compte());
        }

        public static void saisirInformationCompte(Client client)
        {
            client.Insert();
        }

        public static void modifierCompte(Client client)
        {
            client.Update();
        }
    }
}