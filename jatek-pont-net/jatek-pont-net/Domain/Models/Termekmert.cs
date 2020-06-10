using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class Termekmert
    {
        public Termekmert()
        {
            Keszlet = new HashSet<Keszlet>();
            KimenoRendelesT = new HashSet<KimenoRendelesT>();
            RaktarkoziMozgT = new HashSet<RaktarkoziMozgT>();
            VevoiRendelesT = new HashSet<VevoiRendelesT>();
        }

        public int Id { get; set; }
        public int Termek { get; set; }
        public int Mertekegyseg { get; set; }
        public string Alape { get; set; }
        public decimal Szorzo { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Mertekegyseg MertekegysegNavigation { get; set; }
        public virtual Termek TermekNavigation { get; set; }
        public virtual ICollection<Keszlet> Keszlet { get; set; }
        public virtual ICollection<KimenoRendelesT> KimenoRendelesT { get; set; }
        public virtual ICollection<RaktarkoziMozgT> RaktarkoziMozgT { get; set; }
        public virtual ICollection<VevoiRendelesT> VevoiRendelesT { get; set; }
    }
}
