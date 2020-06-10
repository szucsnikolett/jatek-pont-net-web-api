using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class CsomagT
    {
        public int Id { get; set; }
        public int VevoiRendT { get; set; }
        public int CsomagF { get; set; }
        public int? Sorszam { get; set; }
        public string Allapot { get; set; }
        public decimal Menny { get; set; }
        public int? Kedvezmeny { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual CsomagF CsomagFNavigation { get; set; }
        public virtual Kedvezmeny KedvezmenyNavigation { get; set; }
        public virtual VevoiRendelesT VevoiRendTNavigation { get; set; }
    }
}
