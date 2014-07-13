using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;


namespace GestionnaireLivraison.model
{
    public class Entrepreneur : ICompte
    {
     
       private Compte compte; 

	public Entrepreneur(Compte compte) 
    {
        this.compte = compte;
	
    }


    #region ICompte Members

    public ObjectId Id
    {
        get
        {
            return compte.Id;
         
        }
        set
        {
           compte.Id = value;
        }
    }

    public string Nom
    {
        get
        {
            return compte.Nom;
        }
        set
        {
            compte.Nom = value;
        }
    }

    public string Prenom
    {
        get
        {
            return compte.Prenom;
        }
        set
        {
            compte.Prenom = value;
        }
    }

    public DateTime DateNaissance
    {
        get
        {
            return compte.DateNaissance;
        }
        set
        {
            compte.DateNaissance = value;
        }
    }

    public string NoTelephone
    {
        get
        {
            return compte.NoTelephone;
        }
        set
        {
            compte.NoTelephone = value;
        }
    }

    public ObjectId AdresseId
    {
        get
        {
            return compte.AdresseId;
        }
        set
        {
            compte.AdresseId = value;
        }
    }

    public string Courriel
    {
        get
        {
            return compte.Courriel;
        }
        set
        {
            compte.Courriel = value;
        }
    }

    public string MotDePasse
    {
        get
        {
            return compte.MotDePasse;
        }
        set
        {
            compte.MotDePasse = value;
        }
    }

    public EnumAccesCompte AccesCompte
    {
        get
        {
            return AccesCompte;
        }
        set
        {
            compte.AccesCompte = value;
        }
    }

    #endregion
    
    }
}