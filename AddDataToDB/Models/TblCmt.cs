using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblCmt
    {
        public int CmtId { get; set; }
        public string CmtFname { get; set; }
        public string CmtPhone { get; set; }
        public string CmtEmail { get; set; }
        public string CmtText { get; set; }
        public string Ip { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
