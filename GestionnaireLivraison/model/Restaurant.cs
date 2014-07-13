using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionnaireLivraison_LOG210.model
{
    public class Restaurant
    {

   // public IAccesCommande accesCommande  { get; set; }
//	public IAccesMenu accesMenu  { get; set; }
	
	public String id  { get; set; }
	
	public String nom  { get; set; }
	
	public String noTelephone  { get; set; }
	
	public String noRue  { get; set; }
	
	public String noCodePostal  { get; set; }
	
	public String nomRue  { get; set; }
	
	public String website  { get; set; }


	public String url { get; set; }
	
	//Size(max=250) 
	public String description  { get; set; }
	
	public String restaurateur  { get; set; }
	
	public Restaurant()// throws UnknownHostException
	{
		this.id = Guid.NewGuid().ToString();
	//	accesCommande = GestionnaireLivraison.accesCommande;
		//accesMenu = GestionnaireLivraison.accesMenu;
	}
	
	/**
	 * 
	 * @param parametre 0=nom 1=prenom 2=courriel 3=motDePasse 4=dateDeNaissance 5=noTelephone 6=noRue 7=nomRue 8=codePostal
	 */
	public Restaurant(String nom, String noTelephone, String noRue, String nomRue, String noCodePostal, 
        String restaurateur, String description, String webSite, String url)
	{
        this.nom = nom;
        this.noTelephone = noTelephone;
        this.noRue = noRue;
        this.nomRue = nomRue;
        this.noCodePostal = noCodePostal;
        this.restaurateur = restaurateur;
        this.description = description;
		this.website= webSite;
        this.url = url;
	}	
    }
}