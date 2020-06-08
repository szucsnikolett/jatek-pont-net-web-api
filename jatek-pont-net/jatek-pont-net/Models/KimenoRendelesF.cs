using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class KimenoRendelesF
    {
        public KimenoRendelesF()
        {
            KimenoRendelesT = new HashSet<KimenoRendelesT>();
        }

        public int Id { get; set; }
        public string Allapot { get; set; }
        public int? Gyarto { get; set; }
        public DateTime? ElkuldDatum { get; set; }
        public DateTime? TeljDatum { get; set; }
        public int Raktar { get; set; }
        public string Hivszam { get; set; }
        public string Megj { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Gyarto GyartoNavigation { get; set; }
        public virtual Raktar RaktarNavigation { get; set; }
        public virtual ICollection<KimenoRendelesT> KimenoRendelesT { get; set; }
    }
}
