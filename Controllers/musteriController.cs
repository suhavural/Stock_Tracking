using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcstokk.Models.Entity;

namespace mvcstokk.Controllers
{
    public class musteriController : Controller
    {

        mvcstokkEntities db = new mvcstokkEntities();

        public ActionResult Index()
        {
            var degerler = db.musteriler.ToList();
            return View(degerler);
        }


        [HttpGet]

        public ActionResult YeniMusteri()
        {
            return View();
        }

        [HttpPost]

        public ActionResult YeniMusteri(musteriler p1)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniMusteri");
            }
            db.musteriler.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult SİL(int id)
        {
            var musteri = db.musteriler.Find(id);
            db.musteriler.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MusteriGetir(int id)
        {
            var mus = db.musteriler.Find(id);
            return View("MusteriGetir", mus);
        }

        public ActionResult Güncelle(musteriler p1)
        {
            var musteri = db.musteriler.Find(p1.MUSTERİID);
            musteri.MUSTERİAD = p1.MUSTERİAD;
            musteri.MUSTERİSOYAD = p1.MUSTERİSOYAD;
            db.SaveChanges();
            return RedirectToAction("Index");
        }



















        /*// GET: musteri
        public ActionResult Index()
        {
            return View();
        } */
    }
}