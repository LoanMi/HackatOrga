using System;
using System.Collections.Generic;

namespace HackatOrga.Models
{
    public partial class Ville
    {
        public Ville()
        {
            Hackatons = new HashSet<Hackaton>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Cp { get; set; } = null!;

        public virtual ICollection<Hackaton> Hackatons { get; set; }
    }
}
