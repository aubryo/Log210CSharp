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
        public string Nom { get; set; }
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
            Menu newData = this.accesMenu.Select(this);
            this.Nom = newData.Nom;
            this.RestaurantId = newData.RestaurantId;
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