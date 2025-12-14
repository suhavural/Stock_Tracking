using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstokk.Models.Entity;

namespace mvcstokk.Controllers
{
    public class satisController : Controller
    {
        mvcstokkEntities db = new mvcstokkEntities();

        public ActionResult Index()
        {
            var degerler = db.satis.ToList();
            return View(degerler);
        }


    }


}