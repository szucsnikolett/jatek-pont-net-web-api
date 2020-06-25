using System;
using System.Collections.Generic;

namespace jatek_pont_net.Domain.Models
{
    public partial class Mertekegyseg
    {
        public Mertekegyseg()
        {
            Termekmert = new HashSet<Termekmert>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nev { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual ICollection<Termekmert> Termekmert { get; set; }
    }
}
