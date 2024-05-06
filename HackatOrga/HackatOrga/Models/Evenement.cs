using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Evenement
    {
        public Evenement()
        {
            Participants = new HashSet<Participant>();
        }

        public int Id { get; set; }
        public int? IdHackaton { get; set; }
        public string Salle { get; set; } = null!;
        public DateOnly DateDeb { get; set; }
        public DateOnly DateFin { get; set; }
        public string Type { get; set; } = null!;
        public string? Theme { get; set; }
        public int? NbPlace { get; set; }
        public int? IdIntervenant { get; set; }

        public virtual Hackaton? IdHackatonNavigation { get; set; }
        public virtual Intervenant? IdIntervenantNavigation { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }
    }
}
