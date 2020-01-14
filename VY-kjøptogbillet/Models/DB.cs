using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using static VY_kjøptogbillet.Models.DBModel;

namespace VY_kjøptogbillet.Models
{
   
        
    public class DB : DbContext
    {


        public DB() : base("name=NSB")
        {
            Database.CreateIfNotExists();
           // Database.SetInitializer(new DBInit());

        }
        
       public virtual DbSet<Strekning> Strekninger { get; set; }
       public virtual DbSet<Avgang> Avganger { get; set; }
       public virtual DbSet<Bestilling> Bestillinger { get; set; }
       public virtual DbSet<Togstasjon>Togstasjoner { get; set; }
      
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }


}
