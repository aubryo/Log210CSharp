using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace GestionnaireLivraison.model
{
    public static class StatutChangeEmail
    {
        private const string fromAdresse = "gestionnairelivraison@gmail.com";
        private const string fromMotDePasse = "adm1n6789";
        private const string subject = "Changement d'état de votre commande";

        public static void Advise(Client client, Commande commande)
        {
            var fromCourriel = new MailAddress(fromAdresse, "Gestionnaire Livraison");
            var toCourriel = new MailAddress(client.Courriel, client.Prenom + " " + client.Nom);
            string body = getBody(commande);
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromCourriel.Address, fromMotDePasse)
            };
            using (var message = new MailMessage(fromCourriel, toCourriel)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }

        private static string getBody(Commande commande)
        {
            EnumCommandeStatut statut = (EnumCommandeStatut)Enum.Parse(typeof(EnumCommandeStatut), commande.Statut);
            string body = "Le statut de votre commande {0} est: {1}";
            switch (statut)
            {
                case EnumCommandeStatut.Acceptee:
                    body = String.Format(body, commande.NoCommande, "Acceptée");
                    break;
                case EnumCommandeStatut.EnPreparation:
                    body = String.Format(body, commande.NoCommande, "En Preparation");
                    break;
                case EnumCommandeStatut.Passee:
                    body = String.Format(body, commande.NoCommande, "Passée");
                    break;
                case EnumCommandeStatut.Prete:
                    body = String.Format(body, commande.NoCommande, "Prête");
                    break;
            }
            return body;
        }
    }
}