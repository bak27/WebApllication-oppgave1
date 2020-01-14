using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VY_kjøptogbillet.Models
{
    public class jsAvgang
    {
        public int id { get; set; }
        public string fratid { get; set; }
        public string tiltid { get; set; }
        public string lengdne{ get; set; }
        public double price { get; set; }


    }
}