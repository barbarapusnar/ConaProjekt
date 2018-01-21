using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test3.Controllers
{
    public class MojController : Controller
    {
        // GET: Moj
        public ActionResult Index()
        {
            data podatki = Helper.Beri();

            if (podatki != null)
            {
                return View(podatki);
            }
            else
            {
                podatki = new data();
                return View(podatki);
            }
        }
    }
}