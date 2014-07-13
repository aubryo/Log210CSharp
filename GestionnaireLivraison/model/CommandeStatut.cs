using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionnaireLivraison.model
{
    public static class CommandeStatut
    {
        public static string EnPreparation()
        {
            return "EnPreparation";
        }
        public static string Passee()
        {
            return "Passee";
        }
        public static string Prete()
        {
            return "Prete";
        }
        public static string Acceptee()
        {
            return "Acceptee";
        }
    }
}