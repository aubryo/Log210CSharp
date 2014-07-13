using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Adresse
    {

        public ObjectId Id { get; set; }

        public string NoRue { get; set; }

        public string NomRue { get; set; }

        public string CodePostal { get; set; }

        public ObjectId CompteId { get; set; }
        
    }
}