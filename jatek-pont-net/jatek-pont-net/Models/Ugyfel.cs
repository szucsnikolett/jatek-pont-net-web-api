using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Ugyfel
    {
        public Ugyfel()
        {
            Gyarto = new HashSet<Gyarto>();
            Kedvezmeny = new HashSet<Kedvezmeny>();
            Szamla = new HashSet<Szamla>();
            SzlevF = new HashSet<SzlevF>();
            VevoiRendelesF = new HashSet<VevoiRendelesF>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nev { get; set; }
        public string Cim { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Mobil { get; set; }
        public string Fax { get; set; }
        public string Tipus { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual ICollection<Gyarto> Gyarto { get; set; }
        public virtual ICollection<Kedvezmeny> Kedvezmeny { get; set; }
        public virtual ICollection<Szamla> Szamla { get; set; }
        public virtual ICollection<SzlevF> SzlevF { get; set; }
        public virtual ICollection<VevoiRendelesF> VevoiRendelesF { get; set; }
    }
}
