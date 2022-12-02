using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblEblaghRep
    {
        public int IdeblaghRep { get; set; }
        public string Tarikh { get; set; }
        public string DescRep { get; set; }
        public string DescNavaghes { get; set; }
        public int? EblaghId { get; set; }
        public int? Darsad { get; set; }
        public string Ip { get; set; }
        public string AttachFile { get; set; }
    }
}
