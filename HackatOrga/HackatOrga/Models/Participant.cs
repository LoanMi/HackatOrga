using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("participant")]
    [Index("IdAtelier", Name = "IDX_D79F6B11F10273D1")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Participant
    {
        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("idAtelier", TypeName = "int(11)")]
        public int? IdAtelier { get; set; }
        [Column("nom")]
        [StringLength(255)]
        public string Nom { get; set; } = null!;
        [Column("prenom")]
        [StringLength(255)]
        public string Prenom { get; set; } = null!;
        [Column("mail")]
        [StringLength(255)]
        public string Mail { get; set; } = null!;

        [ForeignKey("IdAtelier")]
        [InverseProperty("Participants")]
        public virtual Evenement? IdAtelierNavigation { get; set; }
    }
}
