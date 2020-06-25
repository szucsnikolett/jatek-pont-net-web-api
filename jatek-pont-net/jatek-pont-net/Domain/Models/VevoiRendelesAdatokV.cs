using System;

namespace jatek_pont_net.Domain.Models
{
    public partial class VevoiRendelesAdatokV
    {
        public int VevoiRendelesFejId { get; set; }
        public int VevoiRendelesTetelId { get; set; }
        public DateTime VevoiRendelesFejBeerkDat { get; set; }
        public string VevoiRendelesFejHivszam { get; set; }
        public DateTime? VevoiRendelesFejTeljDat { get; set; }
        public string VevoiRendelesFejAllapot { get; set; }
        public string CsomagFejKod { get; set; }
        public decimal? CsomagTetelMenny { get; set; }
        public string RaktarKod { get; set; }
        public string RaktarLeiras { get; set; }
        public string TermekKod { get; set; }
        public string TermekNev { get; set; }
        public string MertekegysegKod { get; set; }
        public string MertekegysegNev { get; set; }
        public decimal VevoiRendelesTetelMenny { get; set; }
        public decimal VevoiRendelesTetelCsomagoltMenny { get; set; }
        public decimal? TermekEgysegar { get; set; }
        public decimal? KedvezmenySzazalek { get; set; }
        public string KedvezmenyezettUgyfelKod { get; set; }
        public string KedvezmenyezettTermekcsoportKod { get; set; }
        public decimal? CsomagTetelKedvezmenyezettAr { get; set; }
        public string MegrendeloKod { get; set; }
        public string MegrendeloNev { get; set; }
        public string SzamlaAllapot { get; set; }
        public DateTime? SzamlaKiallDatum { get; set; }
        public decimal? SzamlaOsszeg { get; set; }
        public int? SzamlaSzamlaszam { get; set; }
        public DateTime? SzamlaTeljDatum { get; set; }
        public string SzamlaUgyfelKod { get; set; }
        public string SzamlaUgyfelNev { get; set; }
        public string FutarKod { get; set; }
        public string FutarNev { get; set; }
        public string TermekGyartoKod { get; set; }
        public string TermekGyartoNev { get; set; }
        public string GyartoOrszagKod { get; set; }
        public string GyartoOrszagNev { get; set; }
    }
}
