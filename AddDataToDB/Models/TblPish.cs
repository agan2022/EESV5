using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblPish
    {
        public int CmtId { get; set; }
        public string PiEmNo { get; set; }
        public string PiFlname { get; set; }
        public string PiNoeEst { get; set; }
        public string PiText { get; set; }
        public string PiVahed { get; set; }
        public string Ip { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
