using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class Oldpishnahadat
    {
        public int? ShomarePishnahad { get; set; }
        public string Onvan { get; set; }
        public string NamePishnahadDahande { get; set; }
        public string PersonelCode { get; set; }
        public DateTime? TarikhSabt { get; set; }
        public byte? NoePishnahad { get; set; }
        public DateTime? TarikhJalaseShora { get; set; }
        public byte? VaziatPishnahad { get; set; }
        public bool? Vosool { get; set; }
        public decimal? SarfeJooeArzi { get; set; }
        public decimal? SoodSarfe { get; set; }
        public decimal? PadashKarshenasiArzyabi { get; set; }
        public decimal? PadashHamkariEjrai { get; set; }
        public decimal? PadashPishnahad { get; set; }
        public DateTime? TarikhTasvib { get; set; }
        public bool? PadashOk { get; set; }
        public string Pasokh { get; set; }
        public string Hadaya { get; set; }
        public string DigarP { get; set; }
        public int? ShomareJalase { get; set; }
        public string NazaryehKarshenas { get; set; }
        public int? Year { get; set; }
        public byte? Month { get; set; }
        public byte? Day { get; set; }
        public byte? Kind { get; set; }
        public bool? Group { get; set; }
        public byte? Sen { get; set; }
        public byte? Madrak { get; set; }
        public int? VahedeMojri { get; set; }
        public int? Wpcode { get; set; }
        public byte? DarsadPishraft { get; set; }
        public byte? VaziatEjra { get; set; }
        public DateTime? TarikhPayaneEjra { get; set; }
        public string DalileAdamEjra { get; set; }
    }
}
