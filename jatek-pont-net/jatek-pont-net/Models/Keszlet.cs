using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Keszlet
    {
        public int Id { get; set; }
        public int Termek { get; set; }
        public int Mertekegyseg { get; set; }
        public int Raktar { get; set; }
        public decimal Menny { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Raktar RaktarNavigation { get; set; }
        public virtual Termekmert Termekmert { get; set; }
    }
}
