using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class Jogosultsag
    {
        public int Id { get; set; }
        public int Felhasznalo { get; set; }
        public int Funkcio { get; set; }
        public DateTime HozzaferesKezd { get; set; }
        public DateTime? HozzaferesVeg { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Felhasznalo FelhasznaloNavigation { get; set; }
        public virtual Funkcio FunkcioNavigation { get; set; }
    }
}
