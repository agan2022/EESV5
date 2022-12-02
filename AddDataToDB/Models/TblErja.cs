using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblErja
    {
        public int ErjaId { get; set; }
        public int? Idpr { get; set; }
        public int? ArzyabIdSrc { get; set; }
        public int? ArzyabIdDes { get; set; }
        public string Description { get; set; }
        public string Tarikh { get; set; }
        public string SaAt { get; set; }
        public string Ip { get; set; }
        public string JalaseNo { get; set; }
        public bool? Flag4Tasvib { get; set; }
    }
}
