using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class SzlevF
    {
        public SzlevF()
        {
            SzlevT = new HashSet<SzlevT>();
        }

        public int Id { get; set; }
        public string Hivszam { get; set; }
        public string Allapot { get; set; }
        public DateTime KiallDat { get; set; }
        public DateTime? AtadDat { get; set; }
        public DateTime? TeljDat { get; set; }
        public int? Futar { get; set; }
        public DateTime? VisszavDat { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Ugyfel FutarNavigation { get; set; }
        public virtual ICollection<SzlevT> SzlevT { get; set; }
    }
}
