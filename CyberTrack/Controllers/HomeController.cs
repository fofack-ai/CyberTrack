using System;
using System.Web;
using System.Web.Mvc;

namespace CyberTrack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Vérifier si le cookie existe
            if (Request.Cookies["AcceptCookies"] == null)
            {
                ViewBag.ShowCookieBanner = true;
            }

            // Données statiques pour l'instant (seront dynamiques plus tard)
            ViewBag.TotalSignalements = 4821;
            ViewBag.TauxResolution = 92;
            ViewBag.CouvertureNationale = 10;

            return View();
        }

        [HttpPost]
        public JsonResult AcceptCookies()
        {
            var cookie = new HttpCookie("AcceptCookies")
            {
                Value = "true",
                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Add(cookie);

            return Json(new { success = true });
        }
    }
}