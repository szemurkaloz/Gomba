using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adattárolás.Táblák
{
    [Alias("Kezelo")]
    public class Kezelő
    {
        [AutoIncrement]
        public Int64 Id { get; set; }
        [Alias("Kod")]
        [StringLength(10)]
        public string Kód { get; set; }
        [Alias("Nev")]
        [StringLength(50)]
        public string Név { get; set; }
        [Alias("UjAdat")]
        public int ÚjAdat { get; set; }
        //int flag = (boolValue)? 1 : 0;
        [Alias("Kimutatas")]
        public int Kimutatás { get; set; }
        [Alias("Beallitas")]
        public int Beállítás { get; set; }
        [Alias("Jog1")]
        public int Jog1 { get; set; }
        [Alias("Jog2")]
        public int Jog2 { get; set; }
        [Alias("Jog3")]
        public int Jog3 { get; set; }
        [Alias("Jog4")]
        public int Jog4 { get; set; }
        [Alias("Jog5")]
        public int Jog5 { get; set; }
        [Alias("Jog6")]
        public int Jog6 { get; set; }
        [Alias("Jog7")]
        public int Jog7 { get; set; }
    }
}
