using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Kedvezmeny
    {
        public Kedvezmeny()
        {
            CsomagT = new HashSet<CsomagT>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public int? Termekcsoport { get; set; }
        public int? Ugyfel { get; set; }
        public decimal Szazalek { get; set; }
        public DateTime ErvKezd { get; set; }
        public DateTime? ErvVeg { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Termekcsoport TermekcsoportNavigation { get; set; }
        public virtual Ugyfel UgyfelNavigation { get; set; }
        public virtual ICollection<CsomagT> CsomagT { get; set; }
    }
}
