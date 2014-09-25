using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Firs_App.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int saat = DateTime.Now.Hour;
            if (saat > 5 && saat < 11)
            {
                ViewBag.SaatlikDurum = "Gunaydin.";
            }
            else if (saat > 11 && saat < 14)
            {
                ViewBag.SaatlikDurum = "Oglen olmus :O";
            }
            else
            {
                ViewBag.SaatlikDurum = "Iyi Aksamlar.";
            }
            return View();
        }

    }
}
