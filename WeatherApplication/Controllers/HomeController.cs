using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeatherApplication.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize]
        public ActionResult Index()
        {
            ViewBag.Message = "UK daily forecast and weekly forecast";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "UK weather Forecast Application Description";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Chatura Roche";

            return View();
        }
    }
}
