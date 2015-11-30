using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatElérés.Egyedek
{
    [Table("Kezelo")]
    public partial class Kezelő : Entity
    {
        [Key]
        public Int64 Id { get; set; }
        [Column("Kod")]
        [MaxLength(10)]
        public string Kód { get; set; }
        [Column("Nev")]
        [MaxLength(50)]
        public string Név { get; set; }
        [Column("UjAdat")]
        public int ÚjAdat { get; set; }
        //int flag = (boolValue)? 1 : 0;
        [Column("Kimutatas")]
        public int Kimutatás { get; set; }
        [Column("Beallitas")]
        public int Beállítás { get; set; }
        [Column("Jog1")]
        public int Jog1 { get; set; }
        [Column("Jog2")]
        public int Jog2 { get; set; }
        [Column("Jog3")]
        public int Jog3 { get; set; }
        [Column("Jog4")]
        public int Jog4 { get; set; }
        [Column("Jog5")]
        public int Jog5 { get; set; }
        [Column("Jog6")]
        public int Jog6 { get; set; }
        [Column("Jog7")]
        public int Jog7 { get; set; }
    }
}
