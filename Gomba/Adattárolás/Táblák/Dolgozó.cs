using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adattárolás.Táblák
{
    [Alias("Dolgozo")]
    public class Dolgozó
    {
        [AutoIncrement]
        [Required]
        public int Id { get; set; }
        [Alias("Nev")]
        [StringLength(50)]
        public string Név { get; set; }
        [Alias("SzuletesIdeje")]
        public DateTime SzületésIdeje { get; set; }
        [Alias("Adoszam")]
        [StringLength(30)]
        public string Adószám { get; set; }
        [Alias("Kod")]
        [StringLength(10)]
        public string Kód { get; set; }
        
      /*  [AutoIncrement]
        [Alias("AuthorID")]
        public Int32 Id { get; set; }
        [Index(Unique = true)]
        [StringLength(40)]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime? LastActivity { get; set; }
        public Decimal? Earnings { get; set; }
        public bool Active { get; set; }
        [StringLength(80)]
        [Alias("JobCity")]
        public string City { get; set; }
        [StringLength(80)]
        [Alias("Comment")]
        public string Comments { get; set; }
        public Int16 Rate { get; set; }*/
    }
}
