using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Hackaton
    {
        public Hackaton()
        {
            Equipes = new HashSet<Equipe>();
            Evenements = new HashSet<Evenement>();
            Utilisateurs = new HashSet<Utilisateur>();
        }

        public int Id { get; set; }
        public int NbPlace { get; set; }
        public string Theme { get; set; } = null!;
        public string Addresse { get; set; } = null!;
        public int? IdVille { get; set; }
        public DateOnly DateDeb { get; set; }
        public DateOnly DateFin { get; set; }
        public string Nom { get; set; } = null!;
        public string? Image { get; set; }

        public virtual Ville? IdVilleNavigation { get; set; }
        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<Evenement> Evenements { get; set; }

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}
