using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Mushteri
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string ShirketAdi { get; set; }
        [Required]
        public string VOEN { get; set; }
        [Required]
        public string AldigiXidmet { get; set; }
        [Required]
        public string MugavileNomresi { get; set; }
        [Required]
        public DateTime MugavileTarixi { get; set; }
        [Required]
        public decimal MonthlyPayment { get; set; }

        public ICollection<Gelirler> rasxodlar { get; set; }
    }
}