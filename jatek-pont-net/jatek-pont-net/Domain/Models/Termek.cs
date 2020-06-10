using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Termek
    {
        public Termek()
        {
            Ar = new HashSet<Ar>();
            InverseOstermekNavigation = new HashSet<Termek>();
            Termekmert = new HashSet<Termekmert>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nev { get; set; }
        public string Tipus { get; set; }
        public DateTime GyartasKezd { get; set; }
        public DateTime? GyartasVeg { get; set; }
        public int? Ostermek { get; set; }
        public int Gyarto { get; set; }
        public int? GyartasiOrszag { get; set; }
        public string MinKovetelmeny { get; set; }
        public string IdealisRendszer { get; set; }
        public int? Tcsoport { get; set; }
        public string Allapot { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Orszag GyartasiOrszagNavigation { get; set; }
        public virtual Gyarto GyartoNavigation { get; set; }
        public virtual Termek OstermekNavigation { get; set; }
        public virtual Termekcsoport TcsoportNavigation { get; set; }
        public virtual ICollection<Ar> Ar { get; set; }
        public virtual ICollection<Termek> InverseOstermekNavigation { get; set; }
        public virtual ICollection<Termekmert> Termekmert { get; set; }
    }
}
