using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblLogPrint
    {
        public int IdlogPrint { get; set; }
        public int? Idpr { get; set; }
        public string DatePrint { get; set; }
        public string TimePrint { get; set; }
        public string UsrPrint { get; set; }
        public string Ipprint { get; set; }
    }
}
