using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionnaireLivraison_LOG210.model
{
    public class Restaurateur : Compte
    {

  //  public IAccesRestaurant accesRestaurant  { get; set; }
	
	/*public Restaurateur(IAccesRestaurant acces) : base(TypeAccesCompte.Restaurateur)
    {
		
		if(acces == null) throw new ArgumentNullException("L'acces ne doit pas être nul");
		this.accesRestaurant = acces;
	}

	public List<Restaurant> getRestaurants() //throws Exception
    {
		return accesRestaurant.selectRestaurants(this);
	}
	
	public Restaurateur(): base(TypeAccesCompte.Restaurateur)    {
	
	}
        */
    }
}