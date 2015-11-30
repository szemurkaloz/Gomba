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
    [Table("Meres")]
    public partial class Mérés : Entity
    {
        [Key]
        public Int64 Id { get; set; }
        [Column("DolgozoId")]
        [Required]
        public int DolgozóId { get; set; }
        [Column("LadaId")]
        [Required]
        public Int64 LádaId { get; set; }
        [Column("Tomeg")]
        [Required(ErrorMessage = "Tömeget meg kell adni!")]
        public decimal Tömeg { get; set; }
        [Column("Ido")]
        [Required]
        public DateTime Idő { get; set; }
        [Column("Helye")]
        [MaxLength(30)]
        [Required]
        public string Helye { get; set; }


        [ForeignKey("DolgozóId")]
        public Dolgozó Dolgozó { get; set; }
        [ForeignKey("LádaId")]
        public Láda Láda { get; set; }
    }
}
