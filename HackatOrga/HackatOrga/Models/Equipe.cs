using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("equipe")]
    [Index("IdHackaton", Name = "IDX_2449BA15E0C15918")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Equipe
    {
        public Equipe()
        {
            Utilisateurs = new HashSet<Utilisateur>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("dateInsc")]
        public DateOnly DateInsc { get; set; }
        [Column("idHackaton", TypeName = "int(11)")]
        public int? IdHackaton { get; set; }
        [Column("nomEquipe")]
        [StringLength(255)]
        public string NomEquipe { get; set; } = null!;
        [Column("numInsc")]
        [StringLength(255)]
        public string NumInsc { get; set; } = null!;

        [ForeignKey("IdHackaton")]
        [InverseProperty("Equipes")]
        public virtual Hackaton? IdHackatonNavigation { get; set; }

        [ForeignKey("EquipeId")]
        [InverseProperty("Equipes")]
        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
