using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VY_kjøptogbillet.Models;
using static VY_kjøptogbillet.Models.DBModel;

namespace VY_kjøptogbillet
{
    public class DBTogstasjon
    {
        public bool lagreTogstasjon(Togstasjon lagreTogstasjon)
        {

            using (var db = new DB())
            {
                try
                {
                    var nystasjonRad = new Togstasjon();

                    nystasjonRad.Stasjon = lagreTogstasjon.Stasjon;
                   


                    db.Togstasjoner.Add(nystasjonRad);
                    db.SaveChanges();
                    return true;

                }
                catch (Exception feil)
                {
                    return false;
                }

            }
        }
        public List<Togstasjon> HentStasjon()

        {
            using (var db1 = new DB())
            {
                List<Togstasjon> alleStasjoner = db1.Togstasjoner.Where(k => k.Id > 0).ToList().Select(k => new Togstasjon
                {
                    
                    Stasjon = k.Stasjon
                   

                }).ToList();

                return alleStasjoner;
            }
        }


    }
}