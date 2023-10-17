using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BazaDati : DbContext 
    {


        public BazaDati() : base("BazaDati")
        {
            // Constructor code here
        }
        public DbSet<Mushteri> Client { get; set; }
        public DbSet<Gelirler> Incomes { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Bank> Banks { get; set; }
    }



}