using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class View3level
    {
        public int Idmasole { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ActiveFlag { get; set; }
        public string Semat { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
        public string EmP { get; set; }
        public short? Kpimode { get; set; }
        public string ThreeLevelId { get; set; }
        public string ThreeLevelName { get; set; }
        public int Idpayesh { get; set; }
        public string DefinePayesh { get; set; }
        public string MeyarGhabol { get; set; }
        public string MghdrAndGiSho { get; set; }
        public bool? SignMghdr { get; set; }
        public string MiEnBeAm { get; set; }
        public string DalEnBeAm { get; set; }
        public int? Carno { get; set; }
        public int IdstatusPayesh { get; set; }
        public string StatusPayeshName { get; set; }
        public string DlRaShKe { get; set; }
        public string DateBegin { get; set; }
        public string DateEnd { get; set; }
        public string DoreyeZamani { get; set; }
        public string DateControl { get; set; }
        public string DateTakmil { get; set; }
    }
}
