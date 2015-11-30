using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adattárolás.Táblák
{
    [Alias("Lada")]
    public class Láda
    {
        [AutoIncrement]
        public Int64 Id { get; set; }
        [Alias("Kod")]
        [StringLength(10)]
        public string Kód { get; set; }
        [Alias("Nev")]
        [StringLength(30)]
        public string Név { get; set; }
        [Alias("Tara")]
        public decimal Tára { get; set; }
        [Alias("Brutto")]
        public decimal Brutto { get; set; }
        [Alias("TaraTolTobb")]
        public decimal TáraTólTöbb { get; set; }
        [Alias("TaraTolKevesebb")]
        public decimal TáraTólKevesebb { get; set; }
        [Alias("BruttoTolTobb")]
        public decimal BruttoTólTöbb { get; set; }
        [Alias("BruttoTolKevesebb")]
        public decimal BruttoTólKevesebb { get; set; }
    }
}
