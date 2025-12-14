using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstokk.Models.Entity;

namespace mvcstokk.Controllers
{
    public class kategoriController : Controller
    {

        mvcstokkEntities db = new mvcstokkEntities();

        public ActionResult Index()
        {
            var degerler = db.kategoriler.ToList();

            return View(degerler);
        }


        [HttpGet]

        public ActionResult Yenikategori()
        {
            return View(); 
        }


        [HttpPost]


        public ActionResult Yenikategori(kategoriler p1)
        {
            if(!ModelState.IsValid)
            {
                return View("YeniKategori");

            }

            db.kategoriler.Add(p1);
            db.SaveChanges();
            return View();
        }



        public ActionResult SİL(int id)
        {
            var kategori = db.kategoriler.Find(id);
            db.kategoriler.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.kategoriler.Find(id);
            return View("KategoriGetir", ktgr);
        }



        public ActionResult Güncelle(kategoriler p1)
        {
            var ktgr = db.kategoriler.Find(p1.KATEGORİID);
            ktgr.KATEGORİAD = p1.KATEGORİAD;
            db.SaveChanges(); 
            return RedirectToAction("Index");
        }

    }
}