using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class SzlevT
    {
        public int Id { get; set; }
        public int CsomagF { get; set; }
        public int SzlevF { get; set; }
        public int? Sorszam { get; set; }
        public string Allapot { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }

        public virtual CsomagF CsomagFNavigation { get; set; }
        public virtual SzlevF SzlevFNavigation { get; set; }
    }
}
