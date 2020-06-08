using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class VevoiRendelesT
    {
        public VevoiRendelesT()
        {
            CsomagT = new HashSet<CsomagT>();
            Reklamacio = new HashSet<Reklamacio>();
        }

        public int Id { get; set; }
        public int VevoiRendF { get; set; }
        public int Termek { get; set; }
        public int? Sorszam { get; set; }
        public int Mertekegyseg { get; set; }
        public decimal Menny { get; set; }
        public string Allapot { get; set; }
        public decimal CsomagoltMenny { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Termekmert Termekmert { get; set; }
        public virtual VevoiRendelesF VevoiRendFNavigation { get; set; }
        public virtual ICollection<CsomagT> CsomagT { get; set; }
        public virtual ICollection<Reklamacio> Reklamacio { get; set; }
    }
}
