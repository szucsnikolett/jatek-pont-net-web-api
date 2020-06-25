using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class Reklamacio
    {
        public int Id { get; set; }
        public int VevoiRendT { get; set; }
        public int VevoiRendFRekl { get; set; }
        public string Allapot { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual VevoiRendelesF VevoiRendFReklNavigation { get; set; }
        public virtual VevoiRendelesT VevoiRendTNavigation { get; set; }
    }
}
