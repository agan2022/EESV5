using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblEblaghHamkar
    {
        public int HamkarId { get; set; }
        public int? EblaghId { get; set; }
        public string EmNo { get; set; }
    }
}
