using System;
using System.Collections.Generic;

namespace RentalKendaraan_014.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }
        public string NamaKendaraan { get; set; }
        public string N0Polisi { get; set; }
        public string N0Stnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        public string Ketersediaan { get; set; }
    }
}
