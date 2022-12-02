using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblPayesh
    {
        public int Idpayesh { get; set; }
        public string DefinePayesh { get; set; }
        public string MeyarGhabol { get; set; }
        public string MghdrAndGiSho { get; set; }
        public bool? SignMghdr { get; set; }
        public string MiEnBeAm { get; set; }
        public string DalEnBeAm { get; set; }
        public int? Carno { get; set; }
        public int? Mrc { get; set; }
        public string DlRaShKe { get; set; }
        public string DateBegin { get; set; }
        public string DateEnd { get; set; }
        public string DoreyeZamani { get; set; }
        public string DateControl { get; set; }
        public string DateTakmil { get; set; }
    }
}
