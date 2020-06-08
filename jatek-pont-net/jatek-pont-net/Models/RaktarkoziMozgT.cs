using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class RaktarkoziMozgT
    {
        public int Id { get; set; }
        public int RaktarkoziMozgF { get; set; }
        public int Termek { get; set; }
        public int? Sorszam { get; set; }
        public int Mertekegyseg { get; set; }
        public decimal? Menny { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual RaktarkoziMozgF RaktarkoziMozgFNavigation { get; set; }
        public virtual Termekmert Termekmert { get; set; }
    }
}
