using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class KimenoRendelesT
    {
        public KimenoRendelesT()
        {
            Beszallitas = new HashSet<Beszallitas>();
        }

        public int Id { get; set; }
        public int KimenoRendF { get; set; }
        public int Termek { get; set; }
        public int? Sorszam { get; set; }
        public int Mertekegyseg { get; set; }
        public decimal Menny { get; set; }
        public string Allapot { get; set; }
        public DateTime? TeljDatum { get; set; }
        public decimal TeljMenny { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual KimenoRendelesF KimenoRendFNavigation { get; set; }
        public virtual Termekmert Termekmert { get; set; }
        public virtual ICollection<Beszallitas> Beszallitas { get; set; }
    }
}
