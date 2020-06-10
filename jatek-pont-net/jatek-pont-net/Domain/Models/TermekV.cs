using System;
using System.Collections.Generic;

namespace jatek_pont_net.Models
{
    public partial class TermekV
    {
        public int TermekId { get; set; }
        public string TermekKod { get; set; }
        public string TermekNev { get; set; }
        public string TermekTipus { get; set; }
        public DateTime TermekGyartasKezd { get; set; }
        public DateTime? TermekGyartasVeg { get; set; }
        public string OstermekKod { get; set; }
        public string OstermekNev { get; set; }
        public string GyartoKod { get; set; }
        public string GyartoNev { get; set; }
        public string GyartasiOrszagKod { get; set; }
        public string GyartasiOrszagNev { get; set; }
        public string TermekcsoportKod { get; set; }
        public string TermekcsoportNev { get; set; }
        public string RaktarKod { get; set; }
        public string RaktarLeiras { get; set; }
        public string RaktarOrszagKod { get; set; }
        public string RaktarOrszagNev { get; set; }
        public decimal? KeszletMenny { get; set; }
        public string KeszletMertekegysegKod { get; set; }
        public string KeszletMertekegysegNev { get; set; }
    }
}
