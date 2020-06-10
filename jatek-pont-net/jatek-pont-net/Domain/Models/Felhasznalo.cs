using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Felhasznalo
    {
        public Felhasznalo()
        {
            InverseFelettesNavigation = new HashSet<Felhasznalo>();
            Jogosultsag = new HashSet<Jogosultsag>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nev { get; set; }
        public string Statusz { get; set; }
        public string Email { get; set; }
        public int? Felettes { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Felhasznalo FelettesNavigation { get; set; }
        public virtual ICollection<Felhasznalo> InverseFelettesNavigation { get; set; }
        public virtual ICollection<Jogosultsag> Jogosultsag { get; set; }
    }
}
