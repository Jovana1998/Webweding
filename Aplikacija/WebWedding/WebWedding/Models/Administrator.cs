using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebWedding.Models;

namespace WebWedding
{
    public class Administrator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Ime { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Prezime { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Email { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]   //Proveriti ogranicenja
        public string Sifra { get; set; }

        
    }
}
