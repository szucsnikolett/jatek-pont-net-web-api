using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Orszag
    {
        public Orszag()
        {
            Gyarto = new HashSet<Gyarto>();
            Raktar = new HashSet<Raktar>();
            Termek = new HashSet<Termek>();
        }

        public int Id { get; set; }
        public string Kod2 { get; set; }
        public string Kod3 { get; set; }
        public string Nev { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual ICollection<Gyarto> Gyarto { get; set; }
        public virtual ICollection<Raktar> Raktar { get; set; }
        public virtual ICollection<Termek> Termek { get; set; }
    }
}
