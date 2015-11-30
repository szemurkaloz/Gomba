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
    [Table("Lada")]
    public partial class Láda : Entity
    {
        [Key]
        public Int64 Id { get; set; }
        [Column("Kod")]
        [MaxLength(10)]
        public string Kód { get; set; }
        [Column("Nev")]
        [MaxLength(30)]
        public string Név { get; set; }
        [Column("Tara")]
        public decimal Tára { get; set; }
        [Column("Brutto")]
        public decimal Brutto { get; set; }
        [Column("TaraTolTobb")]
        public decimal TáraTólTöbb { get; set; }
        [Column("TaraTolKevesebb")]
        public decimal TáraTólKevesebb { get; set; }
        [Column("BruttoTolTobb")]
        public decimal BruttoTólTöbb { get; set; }
        [Column("BruttoTolKevesebb")]
        public decimal BruttoTólKevesebb { get; set; }
    }
}
