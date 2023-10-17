using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Gelirler
    {
        [Key]
        public int Id { get; set; }
   
        [Required]
        public string Qaime { get; set; }

        [Required]
        public float Qiymet { get; set; }

        [Required]
        public DateTime Tarix { get; set; }

        
        public int MushteriID { get; set; }

        [ForeignKey("MushteriID")]
        public Mushteri MushterinADI { get; set; }
    }
}