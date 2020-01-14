using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using VY_kjøptogbillet.Models;
using static VY_kjøptogbillet.Models.DBModel;

namespace VY_kjøptogbillet
{
    public class DBAvgang
    {
        public bool lagreAvgang(Avgang lagreAvgang)
        {

            using (var db = new DB())
            {
                try
                {
                    var nyAvgangRad = new Avgang();

                    nyAvgangRad.FraogTiltid = lagreAvgang.FraogTiltid;
                    nyAvgangRad.Lengdne = lagreAvgang.Lengdne;
                    nyAvgangRad.Price = lagreAvgang.Price;
                    nyAvgangRad.Strekning = lagreAvgang.Strekning;


                    db.Avganger.Add(nyAvgangRad);
                    db.SaveChanges();
                    return true;

                }
                catch (Exception feil)
                {
                    return false;
                }

            }
        }


       
public List<Avgang> HentalleAvganger(int id)

        {

           using (var db1 = new DB())
                    {
                        var avgang = new Avgang();
                List<Avgang> alleAvganger = db1.Avganger.Where( a=>a.Strekning.SId==id).ToList().Select(a => new Avgang
                        {

                            AId=a.AId,
                            FraogTiltid = a.FraogTiltid,
                            Lengdne = a.Lengdne,
                            Price = a.Price

                        }).ToList();
               // Debug.WriteLine(alleAvganger);
                return alleAvganger;
                    }
                }
            
            
           
        }

    }

    
