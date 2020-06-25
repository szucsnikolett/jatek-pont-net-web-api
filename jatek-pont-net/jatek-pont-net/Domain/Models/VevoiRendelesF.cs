using System;
using System.Collections.Generic;

namespace jatek_pont_net.Domain.Models
{
    public partial class VevoiRendelesF
    {
        public VevoiRendelesF()
        {
            Reklamacio = new HashSet<Reklamacio>();
            VevoiRendelesT = new HashSet<VevoiRendelesT>();
        }

        public int Id { get; set; }
        public string Hivszam { get; set; }
        public int Megrendelo { get; set; }
        public DateTime BeerkDat { get; set; }
        public DateTime? TeljDat { get; set; }
        public string Allapot { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Ugyfel MegrendeloNavigation { get; set; }
        public virtual ICollection<Reklamacio> Reklamacio { get; set; }
        public virtual ICollection<VevoiRendelesT> VevoiRendelesT { get; set; }
    }
}
