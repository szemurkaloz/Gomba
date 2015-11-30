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
    [Table("Dolgozo")]
    public partial class Dolgozó : Entity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Column("Nev")]
        [MaxLength(50)]
        public string Név { get; set; }
        [Column("SzuletesIdeje")]
        public DateTime SzületésIdeje { get; set; }
        [Column("Adoszam")]
        [MaxLength(30)]
        public string Adószám { get; set; }
        [Column("Kod")]
        [MaxLength(10)]
        public string Kód { get; set; }
    }
}
