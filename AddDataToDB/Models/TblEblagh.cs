using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblEblagh
    {
        public int EblaghId { get; set; }
        public int? Idpr { get; set; }
        public string EmNoEblagh { get; set; }
        public int? UnitId { get; set; }
        public string Tarikh { get; set; }
        public string Saat { get; set; }
        public long? Hazineh { get; set; }
        public int? Long { get; set; }
        public byte? IntOk { get; set; }
        public string TarikhBa { get; set; }
        public string SaatBa { get; set; }
        public string Ipba { get; set; }
        public long? Padash30 { get; set; }
        public string Datepadash30 { get; set; }
        public long? Padash70 { get; set; }
        public string Datepadash70 { get; set; }
        public long? Padash100 { get; set; }
        public string Datepadash100 { get; set; }
        public string Totalpishraft { get; set; }
        public string Lastpishraft { get; set; }
        public string LastRe { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string SharhEjrai { get; set; }
        public bool? Pardakht30 { get; set; }
        public string Pardakh30tDate { get; set; }
        public bool? Pardakht70 { get; set; }
        public string Pardakht70Date { get; set; }
        public bool? Pardakht100 { get; set; }
        public string Pardakht100Date { get; set; }
    }
}
