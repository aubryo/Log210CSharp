using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.controleur;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ICompte compte = ControleurLogin.ValidateUser(txtCourriel.Text, txtMotDePasse.Text);
            if (compte != null)
            {
                FormsAuthenticationTicket tkt = new FormsAuthenticationTicket(1, compte.Id.ToString(), DateTime.Now, DateTime.Now.AddMinutes(30), true, compte.TypeCompte.ToString());
                string cookiestr = FormsAuthentication.Encrypt(tkt);
                HttpCookie ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                ck.Expires = tkt.Expiration;
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);
                Response.Redirect(ControleurLogin.GetAcceuilPage(compte), true);
            }
        }
    }
}