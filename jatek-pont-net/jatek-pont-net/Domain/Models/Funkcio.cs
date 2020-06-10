using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Funkcio
    {
        public Funkcio()
        {
            Jogosultsag = new HashSet<Jogosultsag>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Leiras { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual ICollection<Jogosultsag> Jogosultsag { get; set; }
    }
}
