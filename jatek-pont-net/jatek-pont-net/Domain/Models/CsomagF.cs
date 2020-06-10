using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class CsomagF
    {
        public CsomagF()
        {
            CsomagT = new HashSet<CsomagT>();
        }

        public int Id { get; set; }
        public string Kod { get; set; }
        public string Allapot { get; set; }
        public DateTime SzallHatarido { get; set; }
        public int Raktar { get; set; }
        public int? Szamla { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual Raktar RaktarNavigation { get; set; }
        public virtual Szamla SzamlaNavigation { get; set; }
        public virtual SzlevT SzlevT { get; set; }
        public virtual ICollection<CsomagT> CsomagT { get; set; }
    }
}
