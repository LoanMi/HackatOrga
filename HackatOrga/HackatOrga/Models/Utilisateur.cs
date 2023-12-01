using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("utilisateur")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Equipes = new HashSet<Equipe>();
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
        [Column("email")]
        [StringLength(255)]
        public string? Email { get; set; }
        [Column("tel")]
        [StringLength(255)]
        public string? Tel { get; set; }
        [Column("mdp")]
        [StringLength(255)]
        public string Mdp { get; set; } = null!;
        [Column("sel")]
        [StringLength(255)]
        public string Sel { get; set; } = null!;
        [Column("dateNaiss")]
        public DateOnly? DateNaiss { get; set; }

        [ForeignKey("UtilisateurId")]
        [InverseProperty("Utilisateurs")]
        public virtual ICollection<Equipe> Equipes { get; set; }
    }
}
