using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyberTrack.Models.ViewModels
{
    public class ConfirmationViewModel
    {
        public int SignalementID { get; set; }

        public string TicketNumber { get; set; }
        public string ReferenceInterne { get; set; }

        public string Categorie { get; set; }
        public string Statut { get; set; }
        public string Region { get; set; }
        public string NiveauUrgence { get; set; }
        public string DelaiTraitement { get; set; }

        public string Url { get; set; }
        public string ObjetSignalement { get; set; }
        public string Description { get; set; }

        public string Email { get; set; }
        public string NomDeclarant { get; set; }
        public string ModeDeclaration { get; set; }
        public string AdresseIP { get; set; }

        public string ImagePath { get; set; }
        public string PieceJointe1 { get; set; }
        public string PieceJointe2 { get; set; }

        public DateTime DateSignalement { get; set; }

        public string SupportEmail { get; set; }
        public string SupportPhone { get; set; }
        public string PlateformeName { get; set; }
        public string SiteWeb { get; set; }
    }
}