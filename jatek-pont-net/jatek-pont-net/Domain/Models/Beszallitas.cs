using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class Beszallitas
    {
        public int Id { get; set; }
        public DateTime BevDat { get; set; }
        public int KimenoRendT { get; set; }
        public int Sorszam { get; set; }
        public decimal Menny { get; set; }
        public string Hivszam { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual KimenoRendelesT KimenoRendTNavigation { get; set; }
    }
}
