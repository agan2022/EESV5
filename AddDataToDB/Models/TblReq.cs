using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblReq
    {
        public int Idreq { get; set; }
        public string DocId { get; set; }
        public string UserText { get; set; }
        public string UserName { get; set; }
        public string Date { get; set; }
        public int? StateusId { get; set; }
        public int? TypeReqId { get; set; }
        public string Time { get; set; }
        public string DateEnd { get; set; }
        public int? DoreZamani { get; set; }
        public string FileNameS { get; set; }
    }
}
