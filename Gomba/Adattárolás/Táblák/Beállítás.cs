using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adattárolás.Táblák
{
    [Alias("Beallitas")]
    public class Beállítás
    {
        [AutoIncrement]
        public Int64 Id { get; set; }
        [Alias("Megnevezes")]
        [StringLength(20)]
        public string Megnevezés { get; set; }
        [Alias("Erteke")]
        [StringLength(10)]
        public string Értéke { get; set; }
    }
}
