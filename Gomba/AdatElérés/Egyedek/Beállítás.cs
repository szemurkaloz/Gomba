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
    [Table("Beallitas")]
    public partial class Beállítás : Entity
    {
        [Key]
        public Int64 Id { get; set; }
        [Column("Megnevezes")]
        [MaxLength(20)]
        public string Megnevezés { get; set; }
        [Column("Erteke")]
        [MaxLength(10)]
        public string Értéke { get; set; }

    }
}
