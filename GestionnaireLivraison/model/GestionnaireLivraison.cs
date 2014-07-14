using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using GestionnaireLivraison.mongoDB;

namespace GestionnaireLivraison.model
{
    public static class GestionnaireLivraison
    {

     



	/*private static void checkForEntrepreneur() //throws Exception
    {
		List<Compte> comptes = accesCompte.select(TypeAccesCompte.Entrepreneur);
		if(comptes.Count == 0){
			accesCompte.insertCompte(getDefaultEntrepreneur());
		}		
	}

/*	private static Compte getDefaultEntrepreneur()// throws Exception
    {
	
   
		Compte entrepreneur = getCompte(TypeAccesCompte.Entrepreneur);

        entrepreneur.Nom = "Torvalds";
		entrepreneur.Courriel = "entrepreneur@log210.com";
        entrepreneur.DateNaissance = new DateTime(1990, 7, 4, new GregorianCalendar());
		entrepreneur.MotDePasse = "equipe9";
		//entrepreneur.NoCodePostal ="J2M 1K2";
		//entrepreneur.NomRue = "Wall Street";
		entrepreneur.NoRue = "2011";
		entrepreneur.NoTelephone = "514-123-4567";
		entrepreneur.Prenom = "Linus";
		return entrepreneur;
	}*/
/*
	public static Compte getCompte(TypeAccesCompte typeAcces) //throws UnknownHostException 
	{
		
        switch(typeAcces){
            case Client
			return new Client(getAccesCommande());
		case Entrepreneur:
			return new Entrepreneur();
		case Livreur:
			return new Livreur();
		case Restaurateur:
			return new Restaurateur(getAccesRestaurant());
		default:
			throw new InvalidParameterException("le parametre typeAcces n'est pas connu");		
		}
	}*/
	
	public static List<Restaurant> GetRestaurants()
    {
		AccesRestaurant accesRestaurant = new AccesRestaurant(DataBases.NomDataBase());
        return accesRestaurant.Select();
	}

    }
}