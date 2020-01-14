using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

namespace VY_kjøptogbillet.Models
{
    public class TogBestilling
    {
        

   public int BId { get; set; }
   public string Fra { get; set; }
   public string Til { get; set; }
   public int Voksen { get; set; }
   public int Barn { get; set; }
   public int Student { get; set; }
   public int Honnør { get; set; }
   public string Utreisedato { get; set; }
   public string Returdato { get; set; }
   public string AvgangogPrice { get; set; }
   public string ReturAvgangogPrice { get; set; }
    }

}