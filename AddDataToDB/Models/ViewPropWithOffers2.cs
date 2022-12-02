using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewPropWithOffers2
    {
        public int Idpr { get; set; }
        public string Usrid { get; set; }
        public string DateN { get; set; }
        public string TimeN { get; set; }
        public string SubjectPr { get; set; }
        public string CurrentDescPr { get; set; }
        public string NewDesPr { get; set; }
        public decimal EjraDaily { get; set; }
        public decimal? EjraMonthly { get; set; }
        public decimal? EjraYear { get; set; }
        public decimal? Ejra5Year { get; set; }
        public decimal? GetDaily { get; set; }
        public decimal? GetMonthly { get; set; }
        public decimal? GetYear { get; set; }
        public decimal? Get5Year { get; set; }
        public decimal? SarfeDaily { get; set; }
        public decimal? SarfeMonthly { get; set; }
        public decimal? SarfeYear { get; set; }
        public decimal? Sarfe5Year { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public string CodeBazr { get; set; }
        public int? Dabir { get; set; }
        public string AtF { get; set; }
        public string NahveyeMohasebe { get; set; }
        public string DesDabir { get; set; }
        public int Idof { get; set; }
        public string Emno { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Semat { get; set; }
        public int? UnitId { get; set; }
        public string Unit { get; set; }
    }
}
