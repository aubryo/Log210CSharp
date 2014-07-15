using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GestionnaireLivraison.model;

namespace GestionnaireLivraison.presentation
{
    public partial class AccueilClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];
            if (!IsPostBack)
            {
                Client client = new Client(new Compte() { Id = id.ToObjectId() });
                client.Select();
                SetClientData(client);
            }

        }

        private void SetClientData(Client client)
        {
            throw new NotImplementedException();
        }

        protected void btnCommander_Click(object sender, EventArgs e)
        {

        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {

        }

        protected void btnCacherInfo_Click(object sender, EventArgs e)
        {

        }
    }
}