using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class Ar
    {
        public int Id { get; set; }
        public int Termek { get; set; }
        public DateTime ErvKezd { get; set; }
        public DateTime? ErvVeg { get; set; }
        public decimal Ar1 { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Termek TermekNavigation { get; set; }
    }
}
