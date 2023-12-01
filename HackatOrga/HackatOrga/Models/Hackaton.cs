using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("hackaton")]
    [Index("IdVille", Name = "IDX_B362734354079ADE")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Hackaton
    {
        public Hackaton()
        {
            Equipes = new HashSet<Equipe>();
            Evenements = new HashSet<Evenement>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("nbPlace", TypeName = "int(11)")]
        public int NbPlace { get; set; }
        [Column("theme")]
        [StringLength(255)]
        public string Theme { get; set; } = null!;
        [Column("addresse")]
        [StringLength(255)]
        public string Addresse { get; set; } = null!;
        [Column("idVille", TypeName = "int(11)")]
        public int? IdVille { get; set; }
        [Column("dateDeb")]
        public DateOnly DateDeb { get; set; }
        [Column("dateFin")]
        public DateOnly DateFin { get; set; }

        [ForeignKey("IdVille")]
        [InverseProperty("Hackatons")]
        public virtual Ville? IdVilleNavigation { get; set; }
        [InverseProperty("IdHackatonNavigation")]
        public virtual ICollection<Equipe> Equipes { get; set; }
        [InverseProperty("IdHackatonNavigation")]
        public virtual ICollection<Evenement> Evenements { get; set; }
    }
}
