using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CyberTrack.DAL;
using CyberTrack.Models.ViewModels;

namespace CyberTrack.Controllers
{
    public class ConfirmationController : Controller
    {
        private readonly SignalementDAO _signalementDAO;

        public ConfirmationController()
        {
            _signalementDAO = new SignalementDAO();
        }

        public ActionResult Index()
        {
            string ticket = TempData["Ticket"] as string;
            TempData.Keep("Ticket");

            if (string.IsNullOrWhiteSpace(ticket))
            {
                ticket = "SGN-2025-04827";
            }

            ConfirmationViewModel model = _signalementDAO.GetByTicket(ticket);

            if (model == null)
            {
                return View("TicketIntrouvable");
            }

            return View(model);
        }

        public ActionResult Print(string ticket)
        {
            if (string.IsNullOrWhiteSpace(ticket))
            {
                return RedirectToAction("Index", "Home");
            }

            ConfirmationViewModel model = _signalementDAO.GetByTicket(ticket);

            if (model == null)
            {
                return View("TicketIntrouvable");
            }

            return View(model);
        }
    }
}