using System;
using System.Collections.Generic;

#nullable disable

namespace EESV2.AddDataToDB.Models
{
    public partial class ViewTotalProb
    {
        public int Idof { get; set; }
        public string Emno { get; set; }
        public int ManId { get; set; }
        public string ManName { get; set; }
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
        public string Usrid { get; set; }
        public int? StatusId { get; set; }
        public string Status { get; set; }
        public int? Idpr { get; set; }
        public string DateN { get; set; }
    }
}
