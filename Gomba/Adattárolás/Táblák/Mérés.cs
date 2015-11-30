using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adattárolás.Táblák
{
    [Alias("Meres")]
    public class Mérés
    {
        [AutoIncrement]
        public Int64 Id { get; set; }
        [Alias("DolgozoId")]
        [Required]
        public int DolgozóId { get; set; }
        [Alias("LadaId")]
        [Required]
        public Int64 LádaId { get; set; }
        [Alias("Tomeg")]
        [Required]//("Tömeget meg kell adni!")
        public decimal Tömeg { get; set; }
        [Alias("Ido")]
        [Required]
        public DateTime Idő { get; set; }
        [Alias("Helye")]
        [StringLength(30)]
        [Required]
        public string Helye { get; set; }
    }
}
