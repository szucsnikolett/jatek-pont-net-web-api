using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class SzamlaV
    {
        public int SzamlaId { get; set; }
        public string SzamlaAllapot { get; set; }
        public DateTime SzamlaKiallDatum { get; set; }
        public decimal? SzamlaOsszeg { get; set; }
        public int SzamlaSzlaszam { get; set; }
        public DateTime? SzamlaTeljDatum { get; set; }
        public string MegrendeloKod { get; set; }
        public string MegrendeloNev { get; set; }
        public string CsomagFejKod { get; set; }
        public DateTime CsomagFejSzallHatarido { get; set; }
        public string RaktarKod { get; set; }
        public string RaktarLeiras { get; set; }
        public string RaktarCim { get; set; }
        public string SzlevTAllapot { get; set; }
        public int? SzlevTSorszam { get; set; }
        public DateTime? SzlevFAtadDat { get; set; }
        public string SzlevFAllapot { get; set; }
        public string SzlevFHivszam { get; set; }
        public string FutarKod { get; set; }
        public string FutarNev { get; set; }
    }
}
