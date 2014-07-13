using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public interface ICompte : IMongoSavableObject 
    {

        string Nom { get; set; }

        string Prenom { get; set; }

        DateTime DateNaissance { get; set; }

        string NoTelephone { get; set; }

        ObjectId AdresseId { get; set; }

        string Courriel { get; set; }  //Nom du compte

        string MotDePasse { get; set; }

        EnumTypeCompte TypeCompte { get; set; }


    }
}
