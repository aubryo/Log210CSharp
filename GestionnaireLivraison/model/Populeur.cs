using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionnaireLivraison.model
{
    public static class Populeur
    {

        public static void populer(Object orignal, Object newData)
        {
            if (!orignal.GetType().Equals(newData.GetType())) throw new Exception("Les objects sont différent");

            foreach (var p in orignal.GetType().GetProperties())
            {
                p.SetValue(orignal, p.GetValue(newData));
            }
        }


    }
}