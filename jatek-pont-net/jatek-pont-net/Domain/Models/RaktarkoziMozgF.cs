using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class RaktarkoziMozgF
    {
        public RaktarkoziMozgF()
        {
            RaktarkoziMozgT = new HashSet<RaktarkoziMozgT>();
        }

        public int Id { get; set; }
        public string Hivszam { get; set; }
        public int Honnan { get; set; }
        public int Hova { get; set; }
        public DateTime? KezdDatum { get; set; }
        public string Allapot { get; set; }
        public DateTime? TeljDatum { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Raktar HonnanNavigation { get; set; }
        public virtual Raktar HovaNavigation { get; set; }
        public virtual ICollection<RaktarkoziMozgT> RaktarkoziMozgT { get; set; }
    }
}
