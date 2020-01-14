using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using VY_kjøptogbillet.Models;
using static VY_kjøptogbillet.Models.DBModel;

namespace VY_kjøptogbillet.Controllers
{
    public class TogBestillingController : Controller
    {

       public  ActionResult Index()
        {
          
           return View();
        }

        
        public JsonResult FinnTurAvganger(string fra,string til)
           {
            
                var db1 = new DBAvgang();
                var db = new DBStrekning();
                int id = db.FinnStrekningId(fra,til);
                List<Avgang> alleAvganger = db1.HentalleAvganger(id);
              
            return Json(alleAvganger, JsonRequestBehavior.AllowGet);


        }


        public JsonResult FinnReturAvganger(string til, string fra)

        {
          var db1 = new DBAvgang();
            var db = new DBStrekning();
            int id = db.FinnStrekningId(til, fra);
            List<Avgang> alleAvganger = db1.HentalleAvganger(id);
            return Json(alleAvganger, JsonRequestBehavior.AllowGet);


        }


      public string Bestilling(TogBestilling togBillet)
        {
            var db = new DBTogbillet();
            db.lageTogBestilling(togBillet);
            var jsonSerializer = new JavaScriptSerializer();
            return jsonSerializer.Serialize("OK");



      }

        public ActionResult Bestill()
        {
            return View();
        }

        public ActionResult HentBestilling()
        {
            var db1 = new DBTogbillet();
            List<TogBestilling> nybestilling = db1.bekrift();


           return View(nybestilling);

        }


        public ActionResult GetStasjon()
        {

            var db = new DBTogstasjon();
            List<Togstasjon> allebyer = db.HentStasjon();
            return Json(allebyer, JsonRequestBehavior.AllowGet);

        }

    }
}
