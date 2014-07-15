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
            return new ObjectId(id);
        }

        public static DataSet ToBindingSource<T>(this List<T> list)
        {
            var properties = typeof(T).GetProperties();
            
            
            return null;
        }
    }
}