using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Equipe
    {
        public Equipe()
        {
            Utilisateurs = new HashSet<Utilisateur>();
        }

        public int Id { get; set; }
        public DateOnly DateInsc { get; set; }
        public int? IdHackaton { get; set; }
        public string NomEquipe { get; set; } = null!;

        public virtual Hackaton? IdHackatonNavigation { get; set; }

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
