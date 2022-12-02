using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewEblagh4safariReport
    {
        public int EblaghId { get; set; }
        public int? Idpr { get; set; }
        public int? TotalPishraft { get; set; }
        public string EmNo { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? Expr1 { get; set; }
        public int ArzyabiId { get; set; }
    }
}
