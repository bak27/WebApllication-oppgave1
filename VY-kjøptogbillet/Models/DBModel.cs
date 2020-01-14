using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VY_kjøptogbillet.Models
{
    public class DBModel
    {
        public class Strekning
        {
            [Key]
            public int SId { get; set; }
            public string Fra { get; set; }
            public string Til { get; set; }
            public virtual List<Avgang> Avganger { get; set; }

        }


        public class Avgang
        {
            [Key]
            public int AId { get; set; }
            public string FraogTiltid { get; set; }
            public string Lengdne { get; set; }
            public double Price { get; set; }
            public virtual Strekning Strekning { get; set; }
            

        }

        public class Togstasjon
        {

            [Key]
            public int Id { get; set; }
            public string Stasjon { get; set; }

        }

       

        public class Bestilling
        {


            [Key]
            public int BId { get; set; }

           // [Required]
            public string Fra { get; set; }

           // [Required]
            public string Til { get; set; }
            public int Voksen { get; set; }
            public int Barn { get; set; }
            public int Student { get; set; }
            public int Honnør { get; set; }
           // [Required]
            public string Utreisedato { get; set; }
           // [Required]
            public string Returdato { get; set; }
            //[Required]
            public string AvgangogPrice { get; set; }
            //[Required]
            public string ReturAvgangogPrice { get; set; }


        }

    }
}