using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GestionnaireLivraison.mongoDB;
using MongoDB.Bson;

namespace GestionnaireLivraison.model
{
    public class Restaurant : IMongoSavableObject
    {

        public ObjectId Id { get; set; }
        public string Nom { get; set; }
        public string NoTelephone { get; set; }
        public string NoRue { get; set; }
        public string CodePostal { get; set; }
        public string NomRue { get; set; }
        public string Website { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public ObjectId RestaurateurID { get; set; }

        private AccesRestaurant accesRestaurant;
        private AccesMenu accesMenu;
        private AccesCommande accesCommande;

        public Restaurant()
        {
            this.accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
            this.accesMenu = new AccesMenu(DataBases.NomDataBase());
            this.accesCommande = new AccesCommande(DataBases.NomDataBase());
        }

        public void Select()
        {
            Restaurant newData = this.accesRestaurant.Select(this);
            if (newData != null)
            {
                this.Nom = newData.Nom;
                this.NoTelephone = newData.NoTelephone;
                this.NoRue = newData.NoRue;
                this.CodePostal = newData.CodePostal;
                this.NomRue = newData.NomRue;
                this.Website = newData.Website;
                this.Url = newData.Url;
                this.Description = newData.Description;
                this.RestaurateurID = newData.RestaurateurID;
            }
        }

        public void Insert()
        {
            accesRestaurant.Insert(this);
        }

        public void Update()
        {
            accesRestaurant.Update(this);
        }

        public List<Menu> GetMenus()
        {
            return accesMenu.Select(this);
        }


        public void Delete()
        {
            List<Menu> menus = GetMenus();
            if (menus != null || menus.Count != 0)
            {
                foreach (Menu menu in menus)
                {
                    menu.Delete();
                }
            }
            accesRestaurant.Delete(this);

        }

        public List<Commande> GetCommandes()
        {
            return accesCommande.Select(this);
        }

    }

}