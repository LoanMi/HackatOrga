using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Equipes = new HashSet<Equipe>();
            Hackatons = new HashSet<Hackaton>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string? Email { get; set; }
        public string? Tel { get; set; }
        public string Mdp { get; set; } = null!;
        public DateOnly? DateNaiss { get; set; }
        /// <summary>
        /// (DC2Type:json)
        /// </summary>
        public string Roles { get; set; } = null!;

        public virtual ICollection<Equipe> Equipes { get; set; }
        public virtual ICollection<Hackaton> Hackatons { get; set; }
    }
}
