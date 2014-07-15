using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace GestionnaireLivraison.presentation
{
    public static class UIHelper
    {
        public static ObjectId ToObjectId(this string id)
        {
            return String.IsNullOrEmpty(id)? ObjectId.Empty: new ObjectId(id);
        }
    }
}