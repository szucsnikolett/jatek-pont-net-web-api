using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class Preferencia
    {
        public int Id { get; set; }
        public string Kod { get; set; }
        public string Nev { get; set; }
        public string Ertek { get; set; }
        public string Rkf { get; set; }
        public DateTime? Rkd { get; set; }
        public string Umf { get; set; }
        public DateTime? Umd { get; set; }
    }
}
