using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Termekcsoport
    {
        public Termekcsoport()
        {
            Kedvezmeny = new HashSet<Kedvezmeny>();
            Termek = new HashSet<Termek>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nev { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual ICollection<Kedvezmeny> Kedvezmeny { get; set; }
        public virtual ICollection<Termek> Termek { get; set; }
    }
}
