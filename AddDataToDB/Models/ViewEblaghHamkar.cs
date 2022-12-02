using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewEblaghHamkar
    {
        public int HamkarId { get; set; }
        public int? EblaghId { get; set; }
        public string EmNo { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Semat { get; set; }
        public int? UnitId { get; set; }
        public string UnitName { get; set; }
    }
}
