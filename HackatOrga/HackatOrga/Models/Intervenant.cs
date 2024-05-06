using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Intervenant
    {
        public Intervenant()
        {
            Evenements = new HashSet<Evenement>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;

        public virtual ICollection<Evenement> Evenements { get; set; }
    }
}
