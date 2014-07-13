using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public interface IMongoSavableObject
    {
        ObjectId Id { get; set; }
    }
}
