using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Szamla
    {
        public Szamla()
        {
            CsomagF = new HashSet<CsomagF>();
        }

        public int Id { get; set; }
        public int Szlaszam { get; set; }
        public int Megrendelo { get; set; }
        public string Allapot { get; set; }
        public DateTime KiallDatum { get; set; }
        public DateTime? TeljDatum { get; set; }
        public decimal? Osszeg { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Ugyfel MegrendeloNavigation { get; set; }
        public virtual ICollection<CsomagF> CsomagF { get; set; }
    }
}
