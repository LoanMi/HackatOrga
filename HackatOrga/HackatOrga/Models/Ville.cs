using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("ville")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Ville
    {
        public Ville()
        {
            Hackatons = new HashSet<Hackaton>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nom")]
        [StringLength(255)]
        public string Nom { get; set; } = null!;
        [Column("cp")]
        [StringLength(255)]
        public string Cp { get; set; } = null!;

        [InverseProperty("IdVilleNavigation")]
        public virtual ICollection<Hackaton> Hackatons { get; set; }
    }
}
