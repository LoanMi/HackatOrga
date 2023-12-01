using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("intervenant")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Intervenant
    {
        public Intervenant()
        {
            Evenements = new HashSet<Evenement>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nom")]
        [StringLength(255)]
        public string Nom { get; set; } = null!;
        [Column("prenom")]
        [StringLength(255)]
        public string Prenom { get; set; } = null!;

        [InverseProperty("IdIntervenantNavigation")]
        public virtual ICollection<Evenement> Evenements { get; set; }
    }
}
