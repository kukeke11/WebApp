using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using UritusedData;
using UritusedData.Models;
using ÜritusedWebApplication.Models.Uritused;

namespace ÜritusedWebApplication.Controllers
{
    public class ÜritusedController : Controller
    {
        private IUritusedInterface _uritus;
        public ÜritusedController(IUritusedInterface uritus)
        {
            _uritus = uritus;
        }

        public IActionResult Index()//Loob avalehe ja kuvab kõik üritused
        {
            var uritusModels = _uritus.GetAll();//Leiab kõik üritused

            var listResult = uritusModels
                .Select(result => new UritusedListingModel
                {
                    Id = result.Id,
                    Uritusenimi = result.Uritusenimi,
                    Toimumisaeg = result.Toimumisaeg.ToString("dd/MM/yyy"),
                    toimus = DateTime.Compare(DateTime.Today, result.Toimumisaeg.Date)//var ürituse toimumis aja sorteerimiseks
                });
            var model = new UritusedIndexModel()
            {
                Uritused = listResult
            };
            return View(model);
        }
        public IActionResult Osalejad(int id)//Kuvab ürituse lehe koos osalejatega
        {
            var uritus = _uritus.GetById(id);//Leiab ürituse andmebaasist 
            var model = new UritusedListingModel//Loob mudeli kuvamiseks
            {
                Id = id,
                Uritusenimi = uritus.Uritusenimi,
                Toimumisaeg = uritus.Toimumisaeg.ToString("dd/MM/yyy"),
                Koht = uritus.Koht,
                Lisainfo = uritus.Lisainfo,
                Osalejad = uritus.Osalejad,
                Ettevotted = uritus.Ettevotted
            };
            return View(model);
        }

        public IActionResult OsalejaDetail(int id, int IDO)//Kuvab osaleja info lehe
        {

            var osaleja = _uritus.GetOsaleja(id,IDO);
            var model = new OsalejaDetailModel
            {
                UID = id,
                ID = IDO,
                Eesnimi = osaleja.Eesnimi,
                Perenimi = osaleja.Perenimi,
                Isikukood = osaleja.Isikukood,
                Makseviis = osaleja.Makseviis,
                Lisainfo = osaleja.Lisainfo,
            };
            return View(model);
        }
        public IActionResult EttevoteDetail(int id, int IDO)//Kuvab ettevõtte info lehe
        {

            var ettevote = _uritus.GetEttevote(id, IDO);
            var model = new EttevoteDetailModel
            {
                UID = id,
                ID = IDO,
                EttevotteNimi = ettevote.EttevõtteNimi,
                EttevõtteRegistrikood = ettevote.EttevõtteRegistrikood,
                OsalejateArv = ettevote.OsalejateArv,
                Makseviis = ettevote.Makseviis,
                Lisainfo = ettevote.Lisainfo,
            };
            return View(model);
        }
        public IActionResult ÜrituseLisamine()//Kuvab ürituse lisamise lehe
        {
            return View("ÜrituseLisamine");
        }
        public IActionResult AddU(Uritused uritus)//Kasutab ürituse lisamise service, et lisada see andmebaasi
        {
            _uritus.AddU(uritus);
            return this.RedirectToAction("Index", "Üritused");
        }
        public IActionResult AddO(int id)//Lisa osaleja
        {
            Osalejad osaleja = new Osalejad
            {
                Eesnimi = Request.Form["eesnimi"].ToString(),
                Perenimi = Request.Form["perenimi"].ToString(),
                Isikukood = (long)Convert.ToDouble(Request.Form["isikukood"]),
                Makseviis = Int32.Parse(Request.Form["makseviis"]),
                Lisainfo = Request.Form["lisainfo"].ToString()
            };
            _uritus.AddO(id,osaleja);
            return this.RedirectToAction("Index", "Üritused");
        }
        public IActionResult AddE(int id)//Lisa ettevote
        {
            Ettevote ettevote = new Ettevote
            {
                EttevõtteNimi = Request.Form["ettevotenimi"].ToString(),
                EttevõtteRegistrikood = (long)Convert.ToDouble(Request.Form["registrikood"]),
                OsalejateArv = Int32.Parse(Request.Form["osalejatearv"]),
                Makseviis = Int32.Parse(Request.Form["makseviis"]),
                Lisainfo = Request.Form["lisainfo"].ToString()
            };
            _uritus.AddE(id, ettevote);
            return this.RedirectToAction("Index", "Üritused");
        }
        public IActionResult UpdateO(int id, int IDO)//Uuendab osaleja
        {
            Osalejad osaleja = _uritus.GetOsaleja(id, IDO);
            osaleja.Eesnimi = Request.Form["eesnimi"].ToString();
            osaleja.Perenimi = Request.Form["perenimi"].ToString();
            osaleja.Isikukood = (long)Convert.ToDouble(Request.Form["isikukood"]);
            osaleja.Makseviis = Int32.Parse(Request.Form["makseviis"]);
            osaleja.Lisainfo = Request.Form["lisainfo"].ToString();
            _uritus.UpdateO(osaleja);
            return this.RedirectToAction("Index", "Üritused");
        }
        public IActionResult UpdateE(int id, int IDO)//Uuendab ettevotte informatsiooni
        {
            Ettevote ettevote = _uritus.GetEttevote(id, IDO); 
            ettevote.EttevõtteNimi = Request.Form["ettevottenimi"].ToString();
            ettevote.EttevõtteRegistrikood = (long)Convert.ToDouble(Request.Form["registrikood"]);
            ettevote.OsalejateArv = Int32.Parse(Request.Form["osalejatearv"]);
            ettevote.Makseviis = Int32.Parse(Request.Form["makseviis"]);
            ettevote.Lisainfo = Request.Form["lisainfo"].ToString();
            _uritus.UpdateE(ettevote);
            return this.RedirectToAction("Index", "Üritused");
        }

        public IActionResult Remove(int id) //Kustutab ürituse andmebaasist
        {
            _uritus.DeleteU(id);
            return this.RedirectToAction("Index", "Üritused");
        }
        public IActionResult RemoveE(int id, int IDO) //Kustutab ettevõtte andmebaasist
        {
            _uritus.DeleteE(id, IDO);
            return this.RedirectToAction("Index", "Üritused");
        }
        public IActionResult RemoveO(int id, int IDO)//Kustutab osaleja andmebaasist
        {
            _uritus.DeleteO(id, IDO);
            return this.RedirectToAction("Index", "Üritused");
        }
    }
}
