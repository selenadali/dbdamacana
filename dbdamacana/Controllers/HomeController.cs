using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dbdamacana.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
         //  ESKİ HALİ carts.Add(cart1);
           // purchases.Add(purchase1);
            //view -> products
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
    }
}