using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using VY_kjøptogbillet.Models;
using static VY_kjøptogbillet.Models.DBModel;

namespace VY_kjøptogbillet
{
    public class DBStrekning
    {
        public bool lagreStrekning(Strekning lagreStrekning)
        {

            using (var db = new DB())
            {
                try
                {
                    var nyStrekningRad = new Strekning();

                    nyStrekningRad.Fra = lagreStrekning.Fra;
                    nyStrekningRad.Til = lagreStrekning.Til;


                    db.Strekninger.Add(nyStrekningRad);
                    db.SaveChanges();
                    return true;

                }
                catch (Exception feil)
                {
                    return false;
                }

            }
        }
   public List<Strekning> FraStrekninger()

                    {
                    using (var db1 = new DB())
                    {
                        List<Strekning> alleStrekning = db1.Strekninger.OrderBy(k=>k.Fra).Distinct().ToList().Select(k => new Strekning
                        {

                            SId = k.SId,
                            Fra = k.Fra
                            
                            }).ToList();

                        return alleStrekning;
                    }
                }




  public int FinnStrekningId(string fra,string til)

        {

            using (var db1 = new DB())
            {

                int str = db1.Strekninger.Where(r=>r.SId>0 && r.Fra==fra && r.Til==til).Select(r=>r.SId).FirstOrDefault();
               // Debug.WriteLine(str);
                return str;
            }

        }
        

public List<Strekning> TilStrekninger(string fra,string til)

        {
            using (var db1 = new DB())
            {
                List<Strekning> alleStrekning = db1.Strekninger.Where(k=>k.Fra==fra && k.Til==til).ToList().Select(k => new Strekning
                {

                    SId=k.SId,
                    Fra=k.Fra,
                    Til = k.Til

                }).ToList();

                return alleStrekning;
            }
        }

public List<Strekning> HentalleStrekning()

        {
            using (var db1 = new DB())
            {
                List<Strekning> alleStrekning = db1.Strekninger.Where(k => k.SId > 0).ToList().Distinct().Select(k => new Strekning
                {
                    SId = k.SId,
                    Fra=k.Fra,
                    Til = k.Til

                }).ToList();

                return alleStrekning;
            }
        }


    }


        }




    
