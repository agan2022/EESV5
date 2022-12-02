using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblProtest
    {
        public int Idprotest { get; set; }
        public int? Idpr { get; set; }
        public string Emno { get; set; }
        public string Descr { get; set; }
        public string Tarikh { get; set; }
        public string Saat { get; set; }
        public string Answ { get; set; }
    }
}
