using System;
using System.Collections.Generic;

namespace jatek_pont_net.Domain.Models
{
    public partial class Raktar
    {
        public Raktar()
        {
            CsomagF = new HashSet<CsomagF>();
            Keszlet = new HashSet<Keszlet>();
            KimenoRendelesF = new HashSet<KimenoRendelesF>();
            RaktarkoziMozgFHonnanNavigation = new HashSet<RaktarkoziMozgF>();
            RaktarkoziMozgFHovaNavigation = new HashSet<RaktarkoziMozgF>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Leiras { get; set; }
        public string Cim { get; set; }
        public int Orszag { get; set; }
        public string Tipus { get; set; }
        public string Statusz { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Orszag OrszagNavigation { get; set; }
        public virtual ICollection<CsomagF> CsomagF { get; set; }
        public virtual ICollection<Keszlet> Keszlet { get; set; }
        public virtual ICollection<KimenoRendelesF> KimenoRendelesF { get; set; }
        public virtual ICollection<RaktarkoziMozgF> RaktarkoziMozgFHonnanNavigation { get; set; }
        public virtual ICollection<RaktarkoziMozgF> RaktarkoziMozgFHovaNavigation { get; set; }
    }
}
