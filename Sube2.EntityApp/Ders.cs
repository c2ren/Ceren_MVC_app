using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sube2.EntityApp
{
    [Table("tblDersler")]
    internal class Ders
    {
        public int Dersid { get; set; }

        [Column(TypeName ="varchar")]
        [MaxLength(30)]
        [Required]
        public string Dersad { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(10)]
        [Required]
        public string? Derskod { get; set; }

    }
}
