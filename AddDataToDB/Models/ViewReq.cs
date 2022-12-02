using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewReq
    {
        public int Idreq { get; set; }
        public string DocId { get; set; }
        public string FormName { get; set; }
        public string UserText { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? ActiveFlag { get; set; }
        public string Semat { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string AddressHome { get; set; }
        public string WorkPhone { get; set; }
        public string EmP { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int TypeReqId { get; set; }
        public string TypeReqName { get; set; }
        public int StateusId { get; set; }
        public string StateusName { get; set; }
        public string DateEnd { get; set; }
        public int? DoreZamani { get; set; }
        public string FileNameS { get; set; }
    }
}
