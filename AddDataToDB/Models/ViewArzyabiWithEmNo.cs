using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewArzyabiWithEmNo
    {
        public int ArzyabiId { get; set; }
        public int ErjaId { get; set; }
        public int? Idpr { get; set; }
        public int? ArzyabIdSrc { get; set; }
        public string EmNo { get; set; }
        public double? HrWork { get; set; }
        public string DateArz { get; set; }
        public bool? PishOk { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string SubjectPr { get; set; }
    }
}
