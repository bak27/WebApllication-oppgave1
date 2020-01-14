using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VY_kjøptogbillet.Models;


namespace VY_kjøptogbillet
{
    public class DBTogbillet
    {


         public bool lageTogBestilling(TogBestilling togbillet)
         {
             using (var db = new DB())
             {
                 try
                 {
                     var nytogbestilling = new DBModel.Bestilling();

                    nytogbestilling.Fra = togbillet.Fra;
                    nytogbestilling.Til = togbillet.Til;
                    nytogbestilling.Voksen = togbillet.Voksen;
                    nytogbestilling.Barn = togbillet.Barn;
                    nytogbestilling.Student = togbillet.Student;
                    nytogbestilling.Honnør = togbillet.Honnør;
                    nytogbestilling.Utreisedato = togbillet.Utreisedato;
                    nytogbestilling.Returdato = togbillet.Returdato;
                    nytogbestilling.AvgangogPrice = togbillet.AvgangogPrice;
                    nytogbestilling.ReturAvgangogPrice = togbillet.ReturAvgangogPrice;

                        db.Bestillinger.Add(nytogbestilling);
                        db.SaveChanges();
                        //db.Entry(nytogbestilling).GetDatabaseValues();



                     return true;
                 }
                 catch(Exception feil)
                 {
                     return false;
                 }


                 }
         }




         public List<TogBestilling> AlleBestillinger()
         {
             using (var db = new DB())
             {

                 List<TogBestilling> bestillinger = db.Bestillinger.Where(b => b.BId>0).ToList().Select(b => new TogBestilling
                 {
                     BId = b.BId,
                     Fra = b.Fra,
                     Til = b.Til,
                     Voksen=b.Voksen,
                     Barn=b.Barn,
                     Student=b.Student,
                     Honnør=b.Honnør,
                     Utreisedato =b.Utreisedato,
                     Returdato=b.Returdato,
                     AvgangogPrice = b.AvgangogPrice,
                     ReturAvgangogPrice = b.ReturAvgangogPrice

                 }).ToList();

                 return bestillinger;
             }
         }
   public  List<TogBestilling> bekrift()
              {


             using (var db=new DB())
             {

                 int count1 = db.Bestillinger.OrderByDescending(p => p.BId).First().BId;
                 List<TogBestilling> nybestilling = db.Bestillinger.Where(b => b.BId ==count1).ToList().Select(b => new TogBestilling
                 {
                     BId = b.BId,
                     Fra = b.Fra,
                     Til = b.Til,
                     Voksen = b.Voksen,
                     Barn = b.Barn,
                     Student = b.Student,
                     Honnør = b.Honnør,
                     Utreisedato = b.Utreisedato,
                     Returdato = b.Returdato,
                     AvgangogPrice =b.AvgangogPrice,
                     ReturAvgangogPrice = b.ReturAvgangogPrice
                 }).ToList(); 

                 return nybestilling;

             }


         } 


    }



}