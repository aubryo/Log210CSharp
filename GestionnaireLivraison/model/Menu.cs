using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Menu : IMongoSavableObject 
    {
        public ObjectId Id { get; set; }
        public string nom { get; set; }
        public ObjectId RestaurantId { get; set; }

        private AccesPlat accesPlat;
        private AccesMenu accesMenu;

        public Menu() 
        {
            this.accesPlat = new AccesPlat(DataBases.NomDataBase());
            this.accesMenu = new AccesMenu(DataBases.NomDataBase());

        }

        public void Select()
        {
            
            Populeur.populer(this, accesMenu.Select(this));
        }

        

        public void Insert()
        {
            accesMenu.Insert(this);
        }

        public List<Plat> GetPlats()
        {
            return accesPlat.Select(this);
        }

       

        public void Update()
        {
            accesMenu.Update(this);
        }

        public void Delete()
        {
            List<Plat> plats = GetPlats();
            if (plats != null || plats.Count != 0)
            {
                foreach (Plat plat in plats)
                {
                    plat.Delete();
                }
            }
            accesMenu.Delete(this);
            
        }
    }
}