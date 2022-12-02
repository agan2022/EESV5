using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewEblaghRep
    {
        public int IdeblaghRep { get; set; }
        public string Tarikh { get; set; }
        public string DescRep { get; set; }
        public string DescNavaghes { get; set; }
        public int? Darsad { get; set; }
        public string Ip { get; set; }
        public int EblaghId { get; set; }
        public int? Idpr { get; set; }
        public string EmNoEblagh { get; set; }
        public int? UnitId { get; set; }
        public string Expr1 { get; set; }
        public string Saat { get; set; }
        public long? Hazineh { get; set; }
        public int? Long { get; set; }
        public byte? IntOk { get; set; }
        public string TarikhBa { get; set; }
        public string SaatBa { get; set; }
        public string Ipba { get; set; }
        public long? Padash30 { get; set; }
        public string Semat { get; set; }
    }
}
