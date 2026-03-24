using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CyberTrack.Models.ViewModels;

namespace CyberTrack.DAL
{
    public class SignalementDAO
    {
        public ConfirmationViewModel GetByTicket(string ticket)
        {
            if (string.IsNullOrWhiteSpace(ticket))
                return null;

            return new ConfirmationViewModel
            {
                SignalementID = 1,
                TicketNumber = ticket,
                ReferenceInterne = "#2025-LT-04827",

                Categorie = "Fraude & Arnaque",
                Statut = "En cours d'analyse",
                Region = "Littoral (Douala)",
                NiveauUrgence = "Urgent",
                DelaiTraitement = "48 – 72 heures ouvrées",

                Url = "https://orangemoney-transfert-cm.site",
                ObjetSignalement = "Faux site de transfert Mobile Money imitant Orange Money",
                Description = "Un site frauduleux imitant l'interface officielle Orange Money collecte les codes PIN et informations bancaires des utilisateurs. Le site utilise un nom de domaine similaire à celui d'Orange Cameroun et propose de faux transferts d'argent. Plusieurs victimes ont signalé des pertes financières suite à l'utilisation de ce service. Le site est accessible depuis les régions Littoral et Centre principalement.",

                Email = "j.mbala@exemple.cm",
                NomDeclarant = "Jean Mbala",
                ModeDeclaration = "En ligne — Interface web",
                AdresseIP = "✱✱✱.✱✱✱.✱✱✱.✱✱✱ (anonymisée)",

                ImagePath = "/Uploads/capture_ecran_site.png",
                PieceJointe1 = "capture_ecran_site.png",
                PieceJointe2 = "preuve_transaction.pdf",

                DateSignalement = new DateTime(2025, 1, 15, 14, 32, 0),

                SupportEmail = "support@cybertrack.cm",
                SupportPhone = "+237 222 22 38 48",
                PlateformeName = "CyberTrack",
                SiteWeb = "www.cybertrack.cm"
            };
        }
    }
}