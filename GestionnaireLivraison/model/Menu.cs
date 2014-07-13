﻿using System;
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
            this.accesPlat = new AccesPlat(DataBases.Databases());
            this.accesMenu = new AccesMenu(DataBases.Databases());

        }

        internal void Load()
        {
            Menu nouveauMenu = new Menu();
            Populeur.populer(this, accesMenu.Select(this));
        }
    }
}