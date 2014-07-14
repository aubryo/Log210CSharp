using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.controleur;

namespace GestionnaireLivraison
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnDeconnection_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect(ControleurLogin.GetLoginPage(), true);
        }
    }
}