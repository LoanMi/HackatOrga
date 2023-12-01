using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HackatOrga.Models
{
    [Table("evenement")]
    [Index("IdIntervenant", Name = "IDX_B26681E338DEB24")]
    [Index("IdHackaton", Name = "IDX_B26681EE0C15918")]
    [MySqlCollation("utf8mb4_unicode_ci")]
    public partial class Evenement
    {
        public Evenement()
        {
            Participants = new HashSet<Participant>();
        }

        [Key]
        [Column("id", TypeName = "int(11)")]
        public int Id { get; set; }
        [Column("idHackaton", TypeName = "int(11)")]
        public int? IdHackaton { get; set; }
        [Column("salle")]
        [StringLength(255)]
        public string Salle { get; set; } = null!;
        [Column("dateDeb")]
        public DateOnly DateDeb { get; set; }
        [Column("dateFin")]
        public DateOnly DateFin { get; set; }
        [Column("dateLimit")]
        public DateOnly DateLimit { get; set; }
        [Column("type")]
        [StringLength(255)]
        public string Type { get; set; } = null!;
        [Column("theme")]
        [StringLength(255)]
        public string? Theme { get; set; }
        [Column("nbPlace", TypeName = "int(11)")]
        public int? NbPlace { get; set; }
        [Column("idIntervenant", TypeName = "int(11)")]
        public int? IdIntervenant { get; set; }

        [ForeignKey("IdHackaton")]
        [InverseProperty("Evenements")]
        public virtual Hackaton? IdHackatonNavigation { get; set; }
        [ForeignKey("IdIntervenant")]
        [InverseProperty("Evenements")]
        public virtual Intervenant? IdIntervenantNavigation { get; set; }
        [InverseProperty("IdAtelierNavigation")]
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
