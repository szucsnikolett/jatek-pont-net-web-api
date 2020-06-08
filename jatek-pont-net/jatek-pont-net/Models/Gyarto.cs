using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Gyarto
    {
        public Gyarto()
        {
            KimenoRendelesF = new HashSet<KimenoRendelesF>();
            Termek = new HashSet<Termek>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nev { get; set; }
        public int Kapcsolattarto { get; set; }
        public string Cim { get; set; }
        public string Email { get; set; }
        public int? Orszag { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Ugyfel KapcsolattartoNavigation { get; set; }
        public virtual Orszag OrszagNavigation { get; set; }
        public virtual ICollection<KimenoRendelesF> KimenoRendelesF { get; set; }
        public virtual ICollection<Termek> Termek { get; set; }
    }
}
