using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class TblErjaProb
    {
        public int ErId { get; set; }
        public string JalaseNo { get; set; }
        public string JalaseDate { get; set; }
        public string Descr { get; set; }
        public int? Idpr { get; set; }
        public string EmP { get; set; }
        public int? WgId { get; set; }
        public byte? Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Q5 { get; set; }
        public string Q6 { get; set; }
        public string Q7 { get; set; }
        public string Q8 { get; set; }
        public string Q9 { get; set; }
        public string Q10 { get; set; }
        public string ErjraDaily { get; set; }
        public string EjraMonth { get; set; }
        public string EjraYear { get; set; }
        public string Ejra5Year { get; set; }
        public string SamarDaily { get; set; }
        public string SamarMonth { get; set; }
        public string SamarYear { get; set; }
        public string Sama5Year { get; set; }
        public string SarfeDaily { get; set; }
        public string SarfeMonth { get; set; }
        public string SarfeYear { get; set; }
        public string Sarfe5Year { get; set; }
        public byte? Quality { get; set; }
        public string MablaghNahaiNumber { get; set; }
        public string MablaghNahaiAlphabet { get; set; }
        public string DateArz { get; set; }
        public double? HrWork { get; set; }
        public bool? PishOk { get; set; }
    }
}
