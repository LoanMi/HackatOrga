using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Participant
    {
        public int Id { get; set; }
        public int? IdAtelier { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Mail { get; set; } = null!;

        public virtual Evenement? IdAtelierNavigation { get; set; }
    }
}
